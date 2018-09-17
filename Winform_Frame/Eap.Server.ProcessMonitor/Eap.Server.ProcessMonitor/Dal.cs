using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Eap.Entity;
using Eap.DbUnit;

namespace Eap.Server.ProcessMonitor
{
    class Dal
    {
        private static Dal dal;
        /// <summary>
        /// 返回默认对象
        /// </summary>
        /// <returns></returns>
        public static Dal GetDal()
        {
            if (dal == null)
                dal = new Dal();

            return dal;
        }

        /// <summary>
        /// 获取应用服务进程监控表数据
        /// </summary>
        /// <returns>应用服务进程监控表</returns>
        internal List<EapProcess> GeEapProcessList(string server_flag)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t.process_id,t.process_name,t.refresh_date,t.process_status,t.process_socket_status,sysdate as DbTime,t.process_url from t_eap_process_status t");
            sql.Append(" where t.server_flag = " + server_flag);
            return Oracle.GetOracle().QueryToList<EapProcess>(sql);
        }

        internal string UpProcess(EapProcess entity)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("update T_EAP_PROCESS_STATUS set process_status = " + entity.PROCESS_STATUS + " where process_id='" + entity.PROCESS_ID + "'");

            return Oracle.GetOracle().ExecSql(sql);
        }

        /// <summary>
        /// 获取获取应用服务进程刷新超时时间
        /// </summary>
        /// <returns></returns>
        internal EapParameter GetProcessRefreshTime()
        {
            return Oracle.GetOracle().GetParameter("ProcessRefreshTimeout");
        }
    }
}
