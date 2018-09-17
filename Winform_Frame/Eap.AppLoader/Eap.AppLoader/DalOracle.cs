using System.Text;
using System.Collections.Generic;
using System.Data.OracleClient;

using Eap.DbUnit;
using Eap.Entity;

namespace Eap.AppLoader
{
    class DalOracle
    {
        //默认对象
        private static DalOracle daloracle;

        /// <summary>
        /// 获取默认对象
        /// </summary>
        /// <returns></returns>
        public static DalOracle GetDalOracle()
        {
            if (daloracle == null)
                daloracle = new DalOracle();

            return daloracle;
        }

        /// <summary>
        /// 根据菜单ID获取菜单信息
        /// </summary>
        /// <param name="menuid">菜单ID</param>
        /// <returns>菜单信息</returns>
        internal EapMenu GetMenuById(string menuid)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t.MENU_ID,t.MENU_NAME,t.ASSEMBLY_NAME,t.FORM_NAME from T_EAP_MENU t");
            sql.Append(" where t.MENU_ID=:MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":MENU_ID", OracleType.VarChar)
            };
            para[0].Value = menuid;

            List<EapMenu> list = Oracle.GetOracle().QueryToList<EapMenu>(sql, para);
            if (list == null || list.Count != 1)
                return null;

            return list[0];
        }

        /// <summary>
        /// 获取用户指定菜单的子菜单权限
        /// </summary>
        /// <param name="menuid"></param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>指定菜单的子菜单权限列表</returns>
        internal List<EapMenu> GetUserSubMenuRight(string menuid, int pageno, int pagesize, out int icnt)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t1.MENU_ID,t1.MENU_NAME,t1.PARENT_MENU_ID,t1.FORM_NAME from T_EAP_MENU t1");
            sql.Append(" where t1.MENU_ID in (select t2.MENU_ID from T_EAP_USER_MENU_RIGHT t2 where t2.USER_ID=:USER_ID)");
            sql.Append(" and t1.PARENT_MENU_ID=:MENU_ID");
            sql.Append(" order by t1.MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":MENU_ID", OracleType.VarChar)
            };
            para[0].Value = Config.GetConfig().user.USER_ID;
            para[1].Value = menuid;

            return Oracle.GetOracle().QueryToPage<EapMenu>(sql, para, pageno, pagesize, out icnt);
        }

        /// <summary>
        /// 获取用户一级菜单权限
        /// </summary>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>指定页一级菜单列表</returns>
        internal List<EapMenu> GetUserRight(int pageno, int pagesize, out int icnt)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t1.MENU_ID,t1.MENU_NAME,t1.PARENT_MENU_ID,t1.FORM_NAME from T_EAP_MENU t1");
            sql.Append(" where t1.MENU_ID in (select t2.MENU_ID from T_EAP_USER_MENU_RIGHT t2 where t2.USER_ID=:USER_ID)");
            sql.Append(" and t1.PARENT_MENU_ID is null");
            sql.Append(" order by t1.MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar)
            };
            para[0].Value = Config.GetConfig().user.USER_ID;

            return Oracle.GetOracle().QueryToPage<EapMenu>(sql, para, pageno, pagesize, out icnt);
        }

        /// <summary>
        /// 获取更新程序和配置文件
        /// </summary>
        /// <returns>更新程序和配置文件</returns>
        internal List<EapFile> GetUpdate()
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.FILE_ID,t.FILE_DATA,t.FILE_EDIT_TIME from T_EAP_FILE t");
            sql.Append(" where t.FILE_ID in ('Eap.config','Eap.AppUpdate.exe')");

            return Oracle.GetOracle().QueryToList<EapFile>(sql);
        }

        /// <summary>
        /// 从数据库获取应用文件清单
        /// </summary>
        /// <returns>应用文件清单</returns>
        internal List<EapFile> GetAppFiles()
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.FILE_ID,t.FILE_VERSION,t.FILE_EDIT_TIME from T_EAP_FILE t");

            return Oracle.GetOracle().QueryToList<EapFile>(sql);
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">登录用户信息</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string Login(EapUser user)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t.USER_ID,t.USER_NAME,t.IS_STOP from T_EAP_USER t");
            sql.Append(" where t.USER_ID=:USER_ID and t.PWD=:PWD");

            //system用户，不能登录系统
            sql.Append(" and t.USER_ID!='system'");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":PWD", OracleType.VarChar)
            };
            para[0].Value = user.USER_ID;
            para[1].Value = Func.EncryptString(user.PWD, Config.GetConfig().DB_KEY);

            List<EapUser> list = Oracle.GetOracle().QueryToList<EapUser>(sql, para);
            if (list == null)
            {
                return "网络错误，无法连接到数据库！";
            }
            else if (list.Count != 1)
            {
                return "登录失败，错误的用户名或密码！";
            }
            else
            {
                if (list[0].IS_STOP == 1)//已停用用户，不能登录系统
                {
                    return "用户已经停用，不能登录！";
                }

                //登录成功，保存登录信息
                Config.GetConfig().user = list[0];
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取用户菜单权限
        /// </summary>
        /// <returns>菜单列表</returns>
        internal List<EapMenu> GetUserMenu(string userID)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t1.* from T_EAP_MENU t1");
            sql.Append(" where t1.MENU_ID in (select t2.MENU_ID from T_EAP_USER_MENU_RIGHT t2 where t2.USER_ID=:USER_ID)");
            sql.Append(" order by t1.MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar)
            };
            para[0].Value = userID;

            return Oracle.GetOracle().QueryToList<EapMenu>(sql, para);
        }
    }
}
