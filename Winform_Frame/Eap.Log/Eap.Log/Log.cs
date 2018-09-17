using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data.OracleClient;

using Eap.Enum;
using Eap.DbUnit;

namespace Eap
{
    public class Log
    {
        //写日志到数据库
        private delegate void delWrite(MessageType mt, string msg, string user);
        private static delWrite log = new delWrite(WriteLog);

        //写日志到文件
        private delegate void delWriteFile(MessageType mt, string msg);
        private static delWriteFile logfile = new delWriteFile(WriteLogFile);

        public static void Write(MessageType mt, string msg, string user)
        {
            log.Invoke(mt, msg, user);
        }

        public static void WriteFile(MessageType mt, string msg)
        {
            logfile.Invoke(mt, msg);
        }

        private static void WriteLog(MessageType mt, string msg, string user)
        {
            try
            {
                //Oracle
                if (Config.GetConfig().DB_TYPE == "1")
                {
                    StringBuilder sql = new StringBuilder(200);
                    sql.Append("insert into T_EAP_LOG(LOG_ID,LOG_TYPE,OPERATE_NOTE,OPERATE_USER,OPERATE_TIME)");
                    sql.Append(" values(SEQ_EAP_LOG.NEXTVAL,:LOG_TYPE,:OPERATE_NOTE,:OPERATE_USER,sysdate)");

                    OracleParameter[] para = {
                        new OracleParameter(":LOG_TYPE", OracleType.Int32),
                        new OracleParameter(":OPERATE_NOTE", OracleType.VarChar),
                        new OracleParameter(":OPERATE_USER", OracleType.VarChar)
                    };
                    para[0].Value = (int)mt;
                    para[1].Value = msg;

                    if (user == null || user == string.Empty)
                        para[2].Value = "system";
                    else
                        para[2].Value = user;

                    Oracle.GetOracle().ExecSql(sql, para);
                }
                //Sqlserver
                else if (Config.GetConfig().DB_TYPE == "2")
                {
                }
            }
            catch
            {
            }
        }

        private static void WriteLogFile(MessageType mt, string msg)
        {
            try
            {
                DateTime dt = DateTime.Now;

                string path = AppDomain.CurrentDomain.BaseDirectory + Config.GetConfig().LOG_DIR
                    + "\\" + dt.Year.ToString().PadLeft(4, '0')
                    + "\\" + dt.Month.ToString().PadLeft(2, '0'); 

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string filename = path + "\\" + Func.FormatDate(dt, true) + ".log";

                string title = string.Empty;
                switch (mt)
                {
                    case MessageType.Information:
                        title = "提示";
                        break;
                    case MessageType.Warning:
                        title = "警告";
                        break;
                    case MessageType.Error:
                        title = "错误";
                        break;
                }

                string fmsg = "[" + Func.FormatDate(dt, true) + " " + Func.FormatTime(dt, true, true)
                        + "][" + title + "]：" + msg + "\r\n";

                File.AppendAllText(filename, fmsg);
            }
            catch
            {
            }
        }
    }
}
