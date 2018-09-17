//不显示函数过期警告
#pragma warning disable 0618

using System;
using System.Windows.Forms;
using System.Xml;
using System.Data.OracleClient;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Eap.AppUpdate
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Process[] process = Process.GetProcessesByName("Eap.AppLoader");
                foreach (Process sub in process)
                {
                    sub.Kill();
                }
                
                //读取配置文件
                XmlDocument xml = new XmlDocument();
                xml.Load("Eap.config");

                string db_type = xml.SelectSingleNode("config/db/db_type").InnerText;
                string db_ip = xml.SelectSingleNode("config/db/db_ip").InnerText;
                string db_name = xml.SelectSingleNode("config/db/db_name").InnerText;
                string db_uid = xml.SelectSingleNode("config/db/db_uid").InnerText;
                string db_pwd = xml.SelectSingleNode("config/db/db_pwd").InnerText;
                string db_key = xml.SelectSingleNode("config/db/db_key").InnerText;

                string app_download = xml.SelectSingleNode("config/app/app_download").InnerText;
                string app_name = xml.SelectSingleNode("config/app/app_name").InnerText;

                string log_dir = xml.SelectSingleNode("config/log/log_dir").InnerText;

                //获取文件清单
                if (db_type == "1")
                {
                    //打开数据库连接
                    string constr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={1})));User ID={2};Password={3};";
                    constr = string.Format(constr, db_ip, DecryptString(db_name, db_key), DecryptString(db_uid, db_key), DecryptString(db_pwd, db_key));
                    OracleConnection con = new OracleConnection(constr);
                    con.Open();

                    //查询文件清单
                    string sql = "select t.FILE_ID,t.FILE_VERSION,t.FILE_EDIT_TIME,t.FILE_DATA from T_EAP_FILE t where t.FILE_ID not in ('Eap.config','Eap.AppUpdate.exe')";
                    OracleDataAdapter ada = new OracleDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);

                    //更新文件
                    Update(ds.Tables[0]);

                    //断开数据库连接
                    con.Close();
                }

                //重新启动主程序
                Process.Start(Application.StartupPath + "\\Eap.AppLoader.exe");

                //关闭更新程序
                Application.Exit();
            }
            catch (Exception ex)
            {
                //发生异常，更新失败，退出更新程序
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// 更新文件
        /// </summary>
        /// <param name="dt">文件清单</param>
        private static void Update(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string fileid = dr["FILE_ID"].ToString();
                string path = Application.StartupPath + "\\" + fileid;

                //判断文件是否存在
                if (!File.Exists(path))
                {
                    WriteFile(path, dr);
                    continue;
                }

                //比较文件
                if (dr["FILE_VERSION"].ToString() == string.Empty)
                {
                    //没有版本信息时，比较最后修改时间（Oracle数据库Date字段不包括毫秒）
                    FileInfo fi = new FileInfo(path);
                    DateTime dt1 = fi.LastWriteTime;
                    DateTime dt2 = (DateTime)dr["FILE_EDIT_TIME"];

                    if (dt1.Year != dt2.Year || dt1.Month != dt2.Month || dt1.Day != dt2.Day
                        || dt1.Hour != dt2.Hour || dt1.Minute != dt2.Minute || dt1.Second != dt2.Second)
                    {
                        WriteFile(path, dr);

                        //没有版本信息时，有时会出现文件修改时间变成新创建文件的时间，需要同步
                        File.SetLastWriteTime(path, dt2);
                        continue;
                    }
                }
                else
                {
                    //比较版本
                    if (FileVersionInfo.GetVersionInfo(path).FileVersion != dr["FILE_VERSION"].ToString())
                    {
                        WriteFile(path, dr);
                        continue;
                    }
                }
            }
        }

        private static void WriteFile(string path, DataRow dr)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            byte[] data = (byte[])dr["FILE_DATA"];
            fs.Write(data, 0, data.Length);
            fs.Close();
        }

        /// <summary>
        /// 解密字符串
        /// </summary>
        /// <param name="str">要解密的字符串</param>
        /// <param name="key">密钥（8位），要求和加密密钥相同</param>
        /// <returns>成功返回解密后的字符串，失败返回源串</returns>
        private static string DecryptString(string str, string key)
        {
            byte[] keys = { 0x34, 0x12, 0x78, 0x56, 0xAB, 0x90, 0xEF, 0xCD };

            if (key.Length != 8)
            {
                return str;
            }

            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(key);
                byte[] rgbIV = keys;
                byte[] strArray = Convert.FromBase64String(str);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();

                ICryptoTransform ict = des.CreateDecryptor(rgbKey, rgbIV);
                CryptoStream cs = new CryptoStream(ms, ict, CryptoStreamMode.Write);
                cs.Write(strArray, 0, strArray.Length);
                cs.FlushFinalBlock();

                return Encoding.UTF8.GetString(ms.ToArray());
            }
            catch
            {
                return str;
            }
        }
    }
}
