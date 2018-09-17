using System.Collections.Generic;

using Eap.Entity;
using Eap.DbUnit;
using Eap;
//using Mes.Entity;

namespace Eap.AppForm
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
        /// 查询值列表数据
        /// </summary>
        /// <param name="query_entity">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>值列表数据清单</returns>
        internal List<EapValueList> QueryValueList(EapValueList query_entity, int pno, int psize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().QueryValueList(query_entity, pno, psize, out icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 删除值列表数据
        /// </summary>
        /// <param name="vlist_id">删除条件，值列表ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelValueList(string vlist_id)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().DelValueList(vlist_id);

            return string.Empty;
        }

        /// <summary>
        /// 修改值列表数据
        /// </summary>
        /// <param name="modify_entity">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifyValueList(EapValueList modify_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().ModifyValueList(modify_entity);

            return string.Empty;
        }

        /// <summary>
        /// 添加值列表数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddValueList(EapValueList add_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().AddValueList(add_entity);

            return string.Empty;
        }

        /// <summary>
        /// 添加值列表明细数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddValueListDetail(EapValueListDetail add_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().AddValueListDetail(add_entity);

            return string.Empty;
        }

        /// <summary>
        /// 删除值列表明细数据
        /// </summary>
        /// <param name="vlist_id">删除条件，值列表ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelValueListDetail(EapValueListDetail del_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().DelValueListDetail(del_entity);

            return string.Empty;
        }

        /// <summary>
        /// 添加系统参数
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddSystemParameter(EapParameter add_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().AddSystemParameter(add_entity);

            return string.Empty;
        }

        /// <summary>
        /// 删除系统参数
        /// </summary>
        /// <param name="para_id">删除条件，系统参数ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelSystemParameter(string para_id)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().DelSystemParameter(para_id);

            return string.Empty;
        }

        /// <summary>
        /// 修改系统参数
        /// </summary>
        /// <param name="modify_entity">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifySystemParameter(EapParameter modify_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().ModifySystemParameter(modify_entity);

            return string.Empty;
        }

        /// <summary>
        /// 查询系统参数数据
        /// </summary>
        /// <param name="query_entity">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>值列表数据清单</returns>
        internal List<EapParameter> QuerySystemParameter(EapParameter query_entity, int pno, int psize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().QuerySystemParameter(query_entity, pno, psize, out icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 查询菜单数据
        /// </summary>
        /// <param name="query">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>菜单数据清单</returns>
        internal List<EapMenu> QueryMenu(EapMenu query_entity, int pno, int psize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().QueryMenu(query_entity, pno, psize, out  icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 修改菜单数据
        /// </summary>
        /// <param name="modify">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifyMenu(EapMenu modify_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().ModifyMenu(modify_entity);

            return string.Empty;
        }

        /// <summary>
        /// 新增菜单数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddMenu(EapMenu add_entity)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().AddMenu(add_entity);

            return string.Empty;
        }


        /// <summary>
        /// 删除菜单数据
        /// </summary>
        /// <param name="menu_id">删除条件，菜单编码</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelMenuByMenuId(string menu_id)
        {
            if (Config.GetConfig().DB_TYPE == "1")
            {
                //1.判断除admin外是否已经
                List<EapUserMenuRight> list = DalOracle.GetDalOracle().GetNotInAdminMenuRight(menu_id);
                if (list == null)
                {
                    return "获取拥有该菜单权限的用户失败";
                }
                if (list.Count == 0)
                {
                    string ret = Oracle.GetOracle().BeginTran();
                    if (ret != string.Empty)
                    {
                        return ret;
                    }

                    ret = DalOracle.GetDalOracle().DeleteAdminMenuRight(menu_id);
                    if (ret != string.Empty)
                    {
                        Oracle.GetOracle().Rollback();
                        return ret;
                    }

                    ret = DalOracle.GetDalOracle().DelMenuByMenuId(menu_id);
                    if (ret != string.Empty)
                    {
                        Oracle.GetOracle().Rollback();
                        return ret;
                    }

                    Oracle.GetOracle().Commit();

                    return string.Empty;
                }

                return "功能菜单编码[" + menu_id + "]已经分配权限，无法删除";
            }
            return string.Empty;
        }

        /// <summary>
        /// 判断菜单是否存在
        /// </summary>
        /// <param name="menu_id">菜单编码</param>
        /// <returns>存在返回true，不存在返回false</returns>
        internal bool IsExistMenu(string menu_id)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().IsExistMenu(menu_id);

            return false;
        }

        /// <summary>
        /// 查询日志数据
        /// </summary>
        /// <param name="query_entity">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>值列表数据清单</returns>
        internal List<EapLog> QueryEapLog(EapLog query_entity, int pno, int psize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().QueryEapLog(query_entity, pno, psize, out icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 从数据库下载文件
        /// </summary>
        /// <param name="fileid">文件ID</param>
        /// <returns>文件数据内容实体</returns>
        internal EapFile DownloadFile(string fileid)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().DownloadFile(fileid);

            return null;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fileid">文件ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DeleteFile(string fileid)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().DeleteFile(fileid);

            return string.Empty;
        }

        /// <summary>
        /// 上传文件数据到数据库
        /// </summary>
        /// <param name="file">文件实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string UploadFile(EapFile file)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().UploadFile(file);

            return string.Empty;
        }

        /// <summary>
        /// 根据菜单ID获取菜单信息
        /// </summary>
        /// <param name="menuid">菜单ID</param>
        /// <returns>菜单信息</returns>
        internal EapMenu GetMenuById(string menuid)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetMenuById(menuid);

            return null;
        }

        /// <summary>
        /// 从数据库获取应用文件清单
        /// </summary>
        /// <param name="query">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>应用文件清单</returns>
        internal List<EapFile> GetAppFiles(EapFile query, int pageno, int pagesize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetAppFiles(query, pageno, pagesize, out icnt);

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 获取用户信息列表
        /// </summary>
        /// <param name="username">查询条件</param>
        /// <param name="pageno"></param>
        /// <param name="pagesize"></param>
        /// <param name="icnt"></param>
        /// <returns></returns>
        internal List<EapUser> GetUserList(EapUser user, int pageno, int pagesize, out int icnt)
        {
            if (Config.GetConfig().DB_TYPE == "1")
            {
                if (string.IsNullOrEmpty(user.USER_NAME))
                {
                    user.USER_NAME = "-1";
                }
                if (string.IsNullOrEmpty(user.USER_ID))
                {
                    user.USER_ID = "-1";
                }

                return DalOracle.GetDalOracle().GetUserList(user, pageno, pagesize, out icnt);
            }

            icnt = 0;
            return null;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string AddUser(EapUser user)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().AddUser(user);

            return string.Empty;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string UpdateUser(EapUser user)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().UpdateUser(user);

            return string.Empty;
        }

        /// <summary>
        /// 是否存在用户（修改密码用）
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal bool IsUserExist(EapUser user)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().IsUserExist(user);

            return false;
        }

        internal bool IsUserExist(string userid)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().IsUserExist(userid);

            return false;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string UpdatePwd(EapUser user)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().UpdatePwd(user);

            return string.Empty;
        }

        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal List<EapMenu> GetUserAuthority()
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetUserAuthority();

            return null;
        }
        /// <summary>
        /// 根据用户获取权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal List<EapUserMenuRight> GetAuthoritybyUser(string userid)
        {
            if (Config.GetConfig().DB_TYPE == "1")
                return DalOracle.GetDalOracle().GetAuthoritybyUser(userid);

            return null;
        }

        /// <summary>
        /// 保存用户权限
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="list_right"></param>
        /// <returns></returns>
        internal string SaveUserMenuRight(string userid, List<EapUserMenuRight> list_right)
        {
            return DalOracle.GetDalOracle().SaveUserMenuRight(userid, list_right);
        }

         /// <summary>
        /// 应用服务进程监控
        /// </summary>
        /// <returns>应用服务进程数据集</returns>
        internal List<EapProcess> GetProcessStatus()
        {
            return DalOracle.GetDalOracle().GetProcessStatus();
        }

        /// <summary>
        /// 获取获取应用服务进程刷新超时时间
        /// </summary>
        /// <returns></returns>
        internal EapParameter GetProcessRefreshTime()
        {
            return DalOracle.GetDalOracle().GetProcessRefreshTime();
        }

        /// <summary>
        /// 获取自定窗体权限按钮
        /// </summary>
        /// <param name="form_full_name"></param>
        /// <returns>按钮集合</returns>
        internal List<EapButton> GetFormUserAuthorityButton(EapMenu form_menu)
        {
            return DalOracle.GetDalOracle().GetFormUserAuthorityButton(form_menu);
        }

        /// <summary>
        /// 删除用户指定菜单已有按钮权限
        /// </summary>
        /// <param name="user_id">用户</param>
        /// <param name="button_right_menu">菜单</param>
        /// <returns>错误信息，成功为空</returns>
        internal string DeleteUserButtonRight(string user_id, EapMenu button_right_menu)
        {
            return DalOracle.GetDalOracle().DeleteUserButtonRight(user_id, button_right_menu);
        }

         /// <summary>
        /// 创建用户按钮权限
        /// </summary>
        /// <param name="UserButton">权限实体</param>
        /// <returns>错误信息，成功为空</returns>
        private string CreateUserFormButtonRight(EapUserButtonRight UserButton)
        {
            return DalOracle.GetDalOracle().CreateUserFormButtonRight(UserButton);
        }

        /// <summary>
        /// 保存用户权限
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="list_right"></param>
        /// <returns></returns>
        internal string SaveUserButtonRight(string user_id, List<EapUserButtonRight> list_button_right,EapMenu button_right_menu)
        {
            //打开事务
            string ret = Oracle.GetOracle().BeginTran();
            if (ret != string.Empty)
            {
                return ret;
            }

            //删除已经拥有该菜单的权限
            ret = DalOracle.GetDalOracle().DeleteUserButtonRight(user_id, button_right_menu);
            if (ret != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return ret;
            }

            if (button_right_menu.MENU_ID == "M0922" || button_right_menu.MENU_ID == "M1816")
            {
                string print_position = null;
                string new_print_position = null;
                //创建用户权限
                foreach (EapUserButtonRight sub in list_button_right)
                {
                    ret = DalOracle.GetDalOracle().CreateUserFormButtonRight(sub);

                    if (ret != string.Empty)
                    {
                        Oracle.GetOracle().Rollback();
                        return ret;
                    }

                    if (sub.BUTTON_ID == 1145)
                    {
                        print_position = print_position + ",1";
                    }
                    if (sub.BUTTON_ID == 1147)
                    {
                        print_position = print_position + ",2";
                    }
                    if (sub.BUTTON_ID == 1146)
                    {
                        print_position = print_position + ",3";
                    }
                    if (sub.BUTTON_ID == 1144)
                    {
                        print_position = ",4";
                    }                                                        
                }
                if (print_position != null)
                {
                    print_position = print_position.TrimStart(',');
                    string[] a = print_position.Split(',');
                    for(int i=0;i<a.Length-1;i++)
                    {
                        for (int j=i+1; j < a.Length;j++ )
                        {
                            if (decimal.Parse(a[i])>decimal.Parse(a[j]))
                            {
                                string b = a[i];
                                a[i] = a[j];
                                a[j] = b;
                            }
                        }
                    }                    
                    for (int i = 0; i < a.Length; i++)
                    {
                        new_print_position = new_print_position + "," + a[i];
                    }
                    new_print_position = new_print_position.Trim(',');
                }
                else
                    print_position = "";
                DalOracle.GetDalOracle().update_print_position(new_print_position, user_id);
            }
            else
            {
                //创建用户权限
                foreach (EapUserButtonRight sub in list_button_right)
                {
                    ret = DalOracle.GetDalOracle().CreateUserFormButtonRight(sub);

                    if (ret != string.Empty)
                    {
                        Oracle.GetOracle().Rollback();
                        return ret;
                    }
                }
            }

            Oracle.GetOracle().Commit();
            return string.Empty;
        }

          /// <summary>
        /// 根据用户获取按钮权限
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <returns>按钮权限集合</returns>
        internal List<EapUserButtonRight> GetButtonAuthoritybyUser(string user_id)
        {
            return DalOracle.GetDalOracle().GetButtonAuthoritybyUser(user_id);
        }

        /// <summary>
        /// 获取部门类型
        /// </summary>
        /// <returns></returns>
        internal List<EapDepartment> GetDepartmant_TYPE()
        {
            return DalOracle.GetDalOracle().GetDEPARTMENT_TYPE();
        }
        /// <summary>
        /// 获取部门类型
        /// </summary>
        /// <returns></returns>
        internal List<EapDepartment> GetASSEMBLY_LINE()
        {
            return DalOracle.GetDalOracle().GetASSEMBLY_LINE();
        }

        /// <summary>
        /// 绑定部门数据
        /// </summary>
        /// <param name="entity">数据源</param>
        /// <param name="pageno">页数</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">条数</param>
        /// <returns></returns>
        internal List<EapDepartment> GetDEPARTMENTList(EapDepartment entity, int pageno, int pagesize, out int icnt) 
        {
            return DalOracle.GetDalOracle().GetDEPARTMENTList(entity, pageno, pagesize, out icnt);
        }
        
        /// <summary>
        /// 获取部门值
        /// </summary>
        /// <param name="DEPARTMENT_ID">部门id</param>
        /// <returns></returns>
        internal EapDepartment GetDEPARTMENTValue(string DEPARTMENT_ID)
        {
            return DalOracle.GetDalOracle().GetDEPARTMENTValue(DEPARTMENT_ID);
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal string UpdateDEPARTMENT(EapDepartment entity) 
        {
            return DalOracle.GetDalOracle().UpdateDEPARTMENT(entity);
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal string AddDEPARTMENT(EapDepartment entity)
        {
            return DalOracle.GetDalOracle().AddDEPARTMENT(entity);
        }

        /// <summary>
        /// 计算部门id
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal decimal GetDEPARTMENT_ID()
        {
            return DalOracle.GetDalOracle().GetDEPARTMENT_ID();
        }

        /// <summary>
        /// 判断部门是否重复
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal bool RepeatDEPARTMENT(string DEPARTMENT_NAME, decimal DEPARTMENT_ID)
        {
            return DalOracle.GetDalOracle().RepeatDEPARTMENT(DEPARTMENT_NAME, DEPARTMENT_ID);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal string DeleteDEPARTMENT(string DEPARTMENT_ID)
        {
            return DalOracle.GetDalOracle().DeleteDEPARTMENT(DEPARTMENT_ID);
        }

        /// <summary>
        /// 根据用户获取生产线权限
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <returns>按钮权限集合</returns>
        internal List<EapUserTrimLine> GetLineAuthoritybyUser(string user_id)
        {
            return DalOracle.GetDalOracle().GetLineAuthoritybyUser(user_id);
        }

        /// <summary>
        /// 保存用户生产线权限
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="list_right"></param>
        /// <returns></returns>
        internal string SaveUserTrimLine(List<EapUserTrimLine> list_line)
        {
            //打开事务
            string ret = Oracle.GetOracle().BeginTran();
            if (ret != string.Empty)
            {
                return ret;
            }

            //删除已经拥有的权限
            ret = DalOracle.GetDalOracle().DelUserLine(list_line[0].USER_ID);
            if (ret != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return ret;
            }

            //创建用户权限
            foreach (EapUserTrimLine sub in list_line)
            {
                ret = DalOracle.GetDalOracle().CreateUserLine(sub);
                if (ret != string.Empty)
                {
                    Oracle.GetOracle().Rollback();
                    return ret;
                }
            }

            Oracle.GetOracle().Commit();
            return string.Empty;
        }
    }
}
