using System.Collections.Generic;

using Eap.Entity;
using Eap.Enum;

namespace Eap.AppLoader
{
    class Bll
    {
        private static Bll bll;

        /// <summary>
        /// 获取默认对象
        /// </summary>
        /// <returns>默认对象</returns>
        public static Bll GetBll()
        {
            if (bll == null)
                bll = new Bll();

            return bll;
        }

        /// <summary>
        /// 根据菜单ID获取菜单信息
        /// </summary>
        /// <param name="menuid">菜单ID</param>
        /// <returns>菜单信息</returns>
        internal EapMenu GetMenuById(string menuid)
        {
            if (Config.GetConfig().DB_TYPE=="1")
                return DalOracle.GetDalOracle().GetMenuById(menuid);

            return null;
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
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetUserSubMenuRight(menuid, pageno, pagesize, out icnt);

            icnt = 0;
            return null;
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
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetUserRight(pageno, pagesize, out icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 获取更新程序和配置文件
        /// </summary>
        /// <returns>更新程序和配置文件</returns>
        internal List<EapFile> GetUpdate()
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetUpdate();

            return null;
        }

        /// <summary>
        /// 从数据库获取应用文件清单
        /// </summary>
        /// <returns>应用文件清单</returns>
        internal List<EapFile> GetAppFiles()
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetAppFiles();

            return null;
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">登录用户信息</param>
        /// <returns>true：登录成功；false：登录失败</returns>
        internal bool Login(EapUser user)
        {
            string ret = string.Empty;

            if (Config.GetConfig().DB_TYPE == "1")
                ret = DalOracle.GetDalOracle().Login(user);

            if (ret != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, ret);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取用户菜单
        /// </summary>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>指定页一级菜单列表</returns>
        internal List<EapMenu> GetUserMenu(string userID)
        {
            if (Config.GetConfig().DB_TYPE == "1")
            {
                return DalOracle.GetDalOracle().GetUserMenu(userID);
            }

            return null;
        }
    }
}
