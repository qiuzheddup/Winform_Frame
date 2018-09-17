using System.Collections.Generic;
using System.Reflection;
using System.Data.OleDb;

using Microsoft.Win32;
using System;
using System.IO;

namespace Eap
{
    public class Excel
    {
        /// <summary>
        /// 根据类型获取创建表需要的字符串
        /// </summary>
        /// <param name="t">类型</param>
        /// <returns></returns>
        private static string GetTypeString(Type t)
        {
            switch (t.ToString())
            {
                case "System.Int16":
                case "System.Int32":
                    return "int";

                case "System.DateTime":
                    return "datetime";

                default:
                    return "text";
            }
        }

        /// <summary>
        /// 判定是否安装的excel2003
        /// </summary>
        /// <returns>true：2003；false：其他excle版本</returns>
        private static bool IsExcel03()
        {
            RegistryKey regk = Registry.LocalMachine;
            RegistryKey bkey = regk.OpenSubKey(@"SOFTWARE\\Microsoft\\Office\\11.0\\Word\\InstallRoot\\");
            if (bkey != null)
            {
                string file03 = bkey.GetValue("Path").ToString();
                if (File.Exists(file03 + "Excel.exe"))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 把实体集写入到指定的Excel文件
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <param name="tablename">Sheet名</param>
        /// <param name="title">标题行</param>
        /// <param name="list">数据集</param>
        public static string WriteExcel<T>(string filename, string tablename, string[] title, List<T> list)
        {
            //如果指定的文件已存在，删除该文件
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            //连接字符串
            string constr;
            if (IsExcel03())
            {
                constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0";
                filename += ".xls";
            }
            else
            {
                constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0 Xml";
                filename += ".xlsx";
            }

            constr = string.Format(constr, filename);

            //连接到Excel文件
            OleDbConnection con = new OleDbConnection(constr);

            try
            {
                //打开Excel文件
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;

                //创建表
                string table = "create table [" + tablename + "](";
                int i = 0;
                foreach (PropertyInfo pro in typeof(T).GetProperties())
                {
                    table += "[" + title[i] + "] " + GetTypeString(pro.PropertyType) + ",";
                    i++;
                }
                table = table.Remove(table.Length - 1);
                table += ")";

                cmd.CommandText = table;
                cmd.ExecuteNonQuery();

                //定义基础插入数据语句
                string str = "insert into [" + tablename + "$](";
                i = 0;
                foreach (PropertyInfo pro in typeof(T).GetProperties())
                {
                    str += "[" + title[i] + "],";
                    i++;
                }
                str = str.Remove(str.Length - 1);
                str += ") values(";

                //逐行写入记录
                foreach (T t in list)
                {
                    string sql = str;

                    foreach (PropertyInfo pro in typeof(T).GetProperties())
                    {
                        if (pro.GetValue(t, null) == null)
                            sql += "'',";
                        else
                            sql += "'" + pro.GetValue(t, null).ToString() + "',";
                    }

                    sql = sql.Remove(sql.Length - 1);
                    sql += ")";

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
