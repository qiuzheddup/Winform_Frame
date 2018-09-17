using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

using Eap.Entity;
using Eap.Enum;

namespace Eap.AppLoader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////禁止应用程序重复启动
            //string appname = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            //System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName(appname);
            //if (p.Length > 1)
            //{
            //    Func.ShowMessage(MessageType.Error, "应用程序已经启动");
            //    return;
            //}

            //比较本地文件和服务器文件清单，如果有更新，启动更新程序
            if (CompareFiles())
            {
                Update();

                Process.Start(Application.StartupPath + "\\Eap.AppUpdate.exe");
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        /// <summary>
        /// 下载并写入最新的配置文件和更新程序
        /// </summary>
        private static void Update()
        {
            List<EapFile> list = Bll.GetBll().GetUpdate();

            foreach (EapFile sub in list)
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\" + sub.FILE_ID, FileMode.Create, FileAccess.Write);
                fs.Write(sub.FILE_DATA, 0, sub.FILE_DATA.Length);
                fs.Close();

                if (sub.FILE_ID == "Eap.config")
                    File.SetLastWriteTime(Application.StartupPath + "\\" + sub.FILE_ID, sub.FILE_EDIT_TIME);
            }
        }

        /// <summary>
        /// 比较本地文件和服务器文件清单
        /// </summary>
        /// <returns>true：文件不一致，需要更新；false：文件一致，不需要更新</returns>
        private static bool CompareFiles()
        {
            bool flag = false;
            
            List<EapFile> list = Bll.GetBll().GetAppFiles();

            //获取文件清单失败或者文件清单为空，为保证程序可运行，不做处理
            if (list == null || list.Count == 0)
                return false;

            foreach (EapFile sub in list)
            {
                string path = Application.StartupPath + "\\" + sub.FILE_ID;

                //判断文件是否存在
                if (!File.Exists(path))
                {
                    flag = true;
                    break;
                }

                //比较文件
                if (sub.FILE_VERSION == null || sub.FILE_VERSION == string.Empty)
                {
                    //没有版本信息时，比较最后修改时间（Oracle数据库Date字段不包括毫秒）
                    FileInfo fi = new FileInfo(path);
                    if (Func.FormatDate(fi.LastWriteTime, false) + Func.FormatTime(fi.LastWriteTime, false, false)
                        != Func.FormatDate(sub.FILE_EDIT_TIME, false) + Func.FormatTime(sub.FILE_EDIT_TIME, false, false))
                    {
                        flag = true;
                        break;
                    }
                }
                else
                {
                    //比较版本
                    if (FileVersionInfo.GetVersionInfo(path).FileVersion != sub.FILE_VERSION)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }
    }
}
