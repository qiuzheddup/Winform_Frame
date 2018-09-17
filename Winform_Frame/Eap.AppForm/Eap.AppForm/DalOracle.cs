using System.Text;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;

using Eap.Entity;
using Eap.DbUnit;
//using Mes.Entity;

namespace Eap.AppForm
{
    class DalOracle
    {
        //默认对象
        private static DalOracle dal_oracle;

        /// <summary>
        /// 返回默认对象
        /// </summary>
        /// <returns></returns>
        public static DalOracle GetDalOracle()
        {
            if (dal_oracle == null)
                dal_oracle = new DalOracle();

            return dal_oracle;
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
            int para_count = 0;
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select T.VLIST_ID,T.VLIST_NAME from T_EAP_VALUE_LIST T where 1=1");
            if (query_entity.VLIST_ID != string.Empty)
            {
                sql.Append(" and T.VLIST_ID like '%'||:VLIST_ID||'%'");
                para_count++;
            }
            if (query_entity.VLIST_NAME != string.Empty)
            {
                sql.Append(" and T.VLIST_NAME like '%'||:VLIST_NAME||'%'");
                para_count++;
            }
            sql.Append(" order by T.VLIST_ID");


            OracleParameter[] para = new OracleParameter[para_count];

            for (int i = 0; i < para_count; i++)
            {
                if (query_entity.VLIST_ID != string.Empty)
                {
                    para[i] = new OracleParameter(":VLIST_ID", OracleType.VarChar);
                    para[i].Value = query_entity.VLIST_ID;
                    query_entity.VLIST_ID = string.Empty;
                    continue;
                }
                if (query_entity.VLIST_NAME != string.Empty)
                {
                    para[i] = new OracleParameter(":VLIST_NAME", OracleType.VarChar);
                    para[i].Value = query_entity.VLIST_NAME;
                    query_entity.VLIST_NAME = string.Empty;
                    continue;
                }
            }

            return Oracle.GetOracle().QueryToPage<EapValueList>(sql, para, pno, psize, out icnt);
        }

        /// <summary>
        /// 删除值列表数据
        /// </summary>
        /// <param name="vlist_id">删除条件，值列表ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelValueList(string vlist_id)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("delete T_EAP_VALUE_LIST T where T.VLIST_ID=:VLIST_ID");
            OracleParameter[] para = {
                new OracleParameter(":VLIST_ID", OracleType.VarChar)
            };
            para[0].Value = vlist_id;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 修改值列表数据
        /// </summary>
        /// <param name="modify_entity">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifyValueList(EapValueList modify_entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("update T_EAP_VALUE_LIST T set T.VLIST_NAME=:VLIST_NAME where T.VLIST_ID=:VLIST_ID");

            OracleParameter[] para = {
                new OracleParameter(":VLIST_ID", OracleType.VarChar),
                new OracleParameter(":VLIST_NAME", OracleType.VarChar)
            };
            para[0].Value = modify_entity.VLIST_ID;
            para[1].Value = modify_entity.VLIST_NAME;
            
            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 添加值列表数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddValueList(EapValueList add_entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("insert into T_EAP_VALUE_LIST T(T.VLIST_ID,T.VLIST_NAME) values(:VLIST_ID,:VLIST_NAME)");

            OracleParameter[] para = {
                new OracleParameter(":VLIST_ID", OracleType.VarChar),
                new OracleParameter(":VLIST_NAME", OracleType.VarChar)
            };
            para[0].Value = add_entity.VLIST_ID;
            para[1].Value = add_entity.VLIST_NAME;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 添加值列表明细数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddValueListDetail(EapValueListDetail add_entity)
        {
            StringBuilder sql = new StringBuilder(150);
            sql.Append("insert into T_EAP_VALUE_LIST_DETAIL T(T.VLIST_DETAIL_ID,T.VLIST_ID,T.VLIST_DETAIL_VALUE,T.VLIST_DETAIL_NAME)");
            sql.Append(" values(SEQ_EAP_VALUE_LIST_DETAIL.Nextval,:VLIST_ID,:VLIST_DETAIL_VALUE,:VLIST_DETAIL_NAME)");

            OracleParameter[] para = {
                new OracleParameter(":VLIST_ID", OracleType.VarChar),
                new OracleParameter(":VLIST_DETAIL_VALUE", OracleType.Number),
                new OracleParameter(":VLIST_DETAIL_NAME", OracleType.VarChar)
            };
            para[0].Value = add_entity.VLIST_ID;
            para[1].Value = add_entity.VLIST_DETAIL_VALUE;
            para[2].Value = add_entity.VLIST_DETAIL_NAME;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 删除值列表明细数据
        /// </summary>
        /// <param name="vlist_id">删除条件，值列表ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelValueListDetail(EapValueListDetail del_entity)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("delete T_EAP_VALUE_LIST_DETAIL T WHERE T.VLIST_DETAIL_ID=:VLIST_DETAIL_ID");

            OracleParameter[] para = {
                new OracleParameter(":VLIST_DETAIL_ID", OracleType.Number)
            };
            para[0].Value = del_entity.VLIST_DETAIL_ID;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 添加系统参数
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddSystemParameter(EapParameter add_entity)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into T_EAP_PARAMETER T(T.PARA_ID,PARA_NAME,PARA_VALUE) values(:PARA_ID,:PARA_NAME,:PARA_VALUE)");

            OracleParameter[] para = {
                new OracleParameter(":PARA_ID", OracleType.VarChar),
                new OracleParameter(":PARA_NAME", OracleType.VarChar),
                new OracleParameter(":PARA_VALUE", OracleType.VarChar)
            };
            para[0].Value = add_entity.PARA_ID;
            para[1].Value = add_entity.PARA_NAME;
            para[2].Value = add_entity.PARA_VALUE;

            return Oracle.GetOracle().ExecSql(sql, para);

        }

        /// <summary>
        /// 删除系统参数
        /// </summary>
        /// <param name="para_id">删除条件，系统参数ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelSystemParameter(string para_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete T_EAP_PARAMETER T WHERE T.PARA_ID=:PARA_ID");
            OracleParameter[] para = {
                new OracleParameter(":PARA_ID", OracleType.VarChar)
            };
            para[0].Value = para_id;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 修改系统参数
        /// </summary>
        /// <param name="modify_entity">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifySystemParameter(EapParameter modify_entity)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update T_EAP_PARAMETER T set T.PARA_NAME=:PARA_NAME,T.PARA_VALUE=:PARA_VALUE where T.PARA_ID=:PARA_ID");

            OracleParameter[] para = {
                new OracleParameter(":PARA_ID", OracleType.VarChar),
                new OracleParameter(":PARA_NAME", OracleType.VarChar),
                new OracleParameter(":PARA_VALUE", OracleType.VarChar)
            };
            para[0].Value = modify_entity.PARA_ID;
            para[1].Value = modify_entity.PARA_NAME;
            para[2].Value = modify_entity.PARA_VALUE;

            return Oracle.GetOracle().ExecSql(sql, para);
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
            int para_count = 0;
            StringBuilder sql = new StringBuilder();
            sql.Append(" select T.PARA_ID,T.PARA_NAME,T.PARA_VALUE from T_EAP_PARAMETER T where 1=1");
            if (query_entity.PARA_ID != string.Empty)
            {
                sql.Append(" and T.PARA_ID like '%'||:PARA_ID||'%'");
                para_count++;
            }
            if (query_entity.PARA_NAME != string.Empty)
            {
                sql.Append(" and T.PARA_NAME like '%'||:PARA_NAME||'%'");
                para_count++;
            }

            OracleParameter[] para = new OracleParameter[para_count];

            for (int i = 0; i < para_count; i++)
            {
                if (query_entity.PARA_ID != string.Empty)
                {
                    para[i] = new OracleParameter(":PARA_ID", OracleType.VarChar);
                    para[i].Value = query_entity.PARA_ID;
                    query_entity.PARA_ID = string.Empty;
                    continue;
                }
                if (query_entity.PARA_NAME != string.Empty)
                {
                    para[i] = new OracleParameter(":PARA_NAME", OracleType.VarChar);
                    para[i].Value = query_entity.PARA_NAME;
                    query_entity.PARA_NAME = string.Empty;
                    continue;
                }
            }
            return Oracle.GetOracle().QueryToPage<EapParameter>(sql, para, pno, psize, out icnt);
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
            int para_count = 0;
            StringBuilder sql = new StringBuilder();
            sql.Append(" select T.MENU_ID,T.MENU_NAME,T.PARENT_MENU_ID,T.FORM_NAME,T.ASSEMBLY_NAME from T_EAP_MENU T where 1=1");

            if (query_entity.MENU_ID != string.Empty)
            {
                sql.Append(" and upper(T.MENU_ID) like '%'||:MENU_ID||'%'");
                para_count++;
            }
            if (query_entity.MENU_NAME != string.Empty)
            {
                sql.Append(" and T.MENU_NAME like '%'||:MENU_NAME||'%'");
                para_count++;
            }
            if (query_entity.PARENT_MENU_ID != string.Empty)
            {
                sql.Append(" and upper(T.PARENT_MENU_ID) like '%'||:PARENT_MENU_ID||'%'");
                para_count++;
            }
            sql.Append(" order by T.MENU_ID");

            OracleParameter[] para = new OracleParameter[para_count];

            for (int i = 0; i < para_count; i++)
            {
                if (query_entity.MENU_ID != string.Empty)
                {
                    para[i] = new OracleParameter(":MENU_ID", OracleType.VarChar);
                    para[i].Value = query_entity.MENU_ID;
                    query_entity.MENU_ID = string.Empty;
                    continue;
                }
                if (query_entity.MENU_NAME != string.Empty)
                {
                    para[i] = new OracleParameter(":MENU_NAME", OracleType.VarChar);
                    para[i].Value = query_entity.MENU_NAME;
                    query_entity.MENU_NAME = string.Empty;
                    continue;
                }
                if (query_entity.PARENT_MENU_ID != string.Empty)
                {
                    para[i] = new OracleParameter(":PARENT_MENU_ID", OracleType.VarChar);
                    para[i].Value = query_entity.PARENT_MENU_ID;
                    query_entity.PARENT_MENU_ID = string.Empty;
                    continue;
                }
            }

            return Oracle.GetOracle().QueryToPage<EapMenu>(sql, para, pno, psize, out icnt);
        }

        /// <summary>
        /// 修改菜单数据
        /// </summary>
        /// <param name="modify">修改实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string ModifyMenu(EapMenu modify_entity)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update T_EAP_MENU T set T.MENU_NAME=:MENU_NAME,T.PARENT_MENU_ID=:PARENT_MENU_ID,T.FORM_NAME=:FORM_NAME,");
            sql.Append(" T.ASSEMBLY_NAME=:ASSEMBLY_NAME where T.MENU_ID=:MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":MENU_ID", OracleType.VarChar),
                new OracleParameter(":MENU_NAME", OracleType.VarChar),
                new OracleParameter(":PARENT_MENU_ID", OracleType.VarChar),
                new OracleParameter(":FORM_NAME", OracleType.VarChar),
                new OracleParameter(":ASSEMBLY_NAME", OracleType.VarChar)
            };
            para[0].Value = modify_entity.MENU_ID;
            para[1].Value = modify_entity.MENU_NAME;
            para[2].Value = modify_entity.PARENT_MENU_ID;
            para[3].Value = modify_entity.FORM_NAME;
            para[4].Value = modify_entity.ASSEMBLY_NAME;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 新增菜单数据
        /// </summary>
        /// <param name="add_entity">新增实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string AddMenu(EapMenu add_entity)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" insert into T_EAP_MENU T( T.MENU_ID,T.MENU_NAME,T.PARENT_MENU_ID,T.FORM_NAME,T.ASSEMBLY_NAME)");
            sql.Append(" values(:MENU_ID,:MENU_NAME,:PARENT_MENU_ID,:FORM_NAME,:ASSEMBLY_NAME)");

            OracleParameter[] para = {
                new OracleParameter(":MENU_ID", OracleType.VarChar),
                new OracleParameter(":MENU_NAME", OracleType.VarChar),
                new OracleParameter(":PARENT_MENU_ID", OracleType.VarChar),
                new OracleParameter(":FORM_NAME", OracleType.VarChar),
                new OracleParameter(":ASSEMBLY_NAME", OracleType.VarChar)
            };
            para[0].Value = add_entity.MENU_ID;
            para[1].Value = add_entity.MENU_NAME;
            para[2].Value = add_entity.PARENT_MENU_ID;
            para[3].Value = add_entity.FORM_NAME;
            para[4].Value = add_entity.ASSEMBLY_NAME;

            string ret = Oracle.GetOracle().BeginTran();
            if (ret != string.Empty)
            {
                return "打开事务失败，原因[" + ret + "]";
            }

            ret = Oracle.GetOracle().ExecSql(sql, para);
            if (ret != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return ret;
            }

            //添加admin用户权限
            sql.Clear();
            sql.Append(" insert into t_eap_user_menu_right  (user_menu_right_id,user_id,menu_id)");
            sql.Append(" values(seq_eap_user_menu_right.nextval,'admin',:MENU_ID)");
            OracleParameter[] para1 = {
                                           new OracleParameter(":MENU_ID", OracleType.VarChar)                                      
                                       };
            para1[0].Value = add_entity.MENU_ID;

            ret = Oracle.GetOracle().ExecSql(sql, para1);
            if (ret != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return ret;
            }

            Oracle.GetOracle().Commit();
            return string.Empty;
        }

        /// <summary>
        /// 删除菜单数据
        /// </summary>
        /// <param name="memu_id">删除条件，菜单编码</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DelMenuByMenuId(string memu_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete T_EAP_MENU T where T.MENU_ID=:MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":MENU_ID", OracleType.VarChar)
            };
            para[0].Value = memu_id;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 判断菜单是否存在
        /// </summary>
        /// <param name="menu_id">菜单编码</param>
        /// <returns>存在返回true，不存在返回false</returns>
        internal bool IsExistMenu(string menu_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select 1 from T_EAP_MENU T WHERE T.MENU_ID=:MENU_ID");

            OracleParameter[] para = {
                new OracleParameter(":MENU_ID", OracleType.VarChar)
            };
            para[0].Value = menu_id;

            if (Oracle.GetOracle().GetSqlCount(sql, para) > 0)
                return true;

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
            int para_count = 2;
            StringBuilder sql = new StringBuilder();
            sql.Append("select t.LOG_ID,t.LOG_TYPE,t1.VLIST_DETAIL_NAME as LOG_TYPE_NAME,t.OPERATE_NOTE,t2.USER_NAME as OPERATE_USER,t.OPERATE_TIME from T_EAP_LOG t");
            sql.Append(" left join T_EAP_VALUE_LIST_DETAIL t1 on t1.VLIST_DETAIL_VALUE=t.LOG_TYPE");
            sql.Append(" left join T_EAP_USER t2 on t.OPERATE_USER=t2.USER_ID");
            sql.Append(" where t1.VLIST_ID='log_type'");
            sql.Append(" and to_char(t.OPERATE_TIME,'YYYYMMDD')>=to_char(:BEGIN_TIME,'YYYYMMDD')");
            sql.Append(" and to_char(t.OPERATE_TIME,'YYYYMMDD')<=to_char(:END_TIME,'YYYYMMDD')");
            if (query_entity.LOG_TYPE != -1)
            {
                sql.Append(" and t.LOG_TYPE=:LOG_TYPE");
                para_count++;
            }
            if (query_entity.OPERATE_NOTE !=string.Empty)
            {
                sql.Append(" and t.OPERATE_NOTE like '%'||:OPERATE_NOTE||'%'");
                para_count++;
            }
            if (query_entity.OPERATE_USER != string.Empty)
            {
                sql.Append(" and t.OPERATE_USER like '%'||:OPERATE_USER||'%'");
                para_count++;
            }
            sql.Append(" order by t.LOG_ID desc");

            OracleParameter[] para = new OracleParameter[para_count];
            para[0] = new OracleParameter(":BEGIN_TIME", OracleType.DateTime);
            para[0].Value = query_entity.BEGIN_TIME;
            para[1] = new OracleParameter(":END_TIME", OracleType.DateTime);
            para[1].Value = query_entity.END_TIME;

            for (int i = 2; i < para_count; i++)
            {
                if (query_entity.LOG_TYPE != -1)
                {
                    para[i] = new OracleParameter(":LOG_TYPE", OracleType.Number);
                    para[i].Value = query_entity.LOG_TYPE;
                    query_entity.LOG_TYPE = -1;
                    continue;
                }
                if (query_entity.OPERATE_NOTE != string.Empty)
                {
                    para[i] = new OracleParameter(":OPERATE_NOTE", OracleType.VarChar);
                    para[i].Value = query_entity.OPERATE_NOTE;
                    query_entity.OPERATE_NOTE = string.Empty;
                    continue;
                }
                if (query_entity.OPERATE_USER != string.Empty)
                {
                    para[i] = new OracleParameter(":OPERATE_USER", OracleType.VarChar);
                    para[i].Value = query_entity.OPERATE_USER;
                    query_entity.OPERATE_USER = string.Empty;
                    continue;
                }
            }

            return Oracle.GetOracle().QueryToPage<EapLog>(sql, para, pno, psize, out icnt);
        }

        /// <summary>
        /// 从数据库下载文件
        /// </summary>
        /// <param name="fileid">文件ID</param>
        /// <returns>文件数据内容实体</returns>
        internal EapFile DownloadFile(string fileid)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.FILE_ID,t.FILE_DATA from T_EAP_FILE t where t.FILE_ID=:FILE_ID");

            OracleParameter[] para = {
                new OracleParameter(":FILE_ID", OracleType.VarChar)
            };
            para[0].Value = fileid;

            List<EapFile> list = Oracle.GetOracle().QueryToList<EapFile>(sql, para);
            if (list == null || list.Count == 0 || list.Count > 1)
                return null;

            return list[0];
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fileid">文件ID</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string DeleteFile(string fileid)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("delete from T_EAP_FILE t where t.FILE_ID=:FILE_ID");

            OracleParameter[] para = {
                new OracleParameter(":FILE_ID", OracleType.VarChar)
            };
            para[0].Value = fileid;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 上传文件数据到数据库
        /// </summary>
        /// <param name="file">文件实体</param>
        /// <returns>错误消息，为空表示成功</returns>
        internal string UploadFile(EapFile file)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("insert into T_EAP_FILE(FILE_ID,FILE_VERSION,FILE_EDIT_TIME,FILE_UPLOAD_TIME,FILE_DATA)");
            sql.Append(" values(:FILE_ID,:FILE_VERSION,:FILE_EDIT_TIME,sysdate,:FILE_DATA)");

            OracleParameter[] para = {
                new OracleParameter(":FILE_ID", OracleType.VarChar),
                new OracleParameter(":FILE_VERSION", OracleType.VarChar),
                new OracleParameter(":FILE_EDIT_TIME", OracleType.DateTime),
                new OracleParameter(":FILE_DATA", OracleType.Blob)
            };
            para[0].Value = file.FILE_ID;
            para[1].Value = file.FILE_VERSION;
            para[2].Value = file.FILE_EDIT_TIME;
            para[3].Value = file.FILE_DATA;

            return Oracle.GetOracle().ExecSql(sql, para);
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
        /// 从数据库获取应用文件清单
        /// </summary>
        /// <param name="query">查询条件实体</param>
        /// <param name="pageno">要查询的页</param>
        /// <param name="pagesize">页大小</param>
        /// <param name="icnt">结果记录条数</param>
        /// <returns>应用文件清单</returns>
        internal List<EapFile> GetAppFiles(EapFile query, int pageno, int pagesize, out int icnt)
        {
            int paracnt = 0;

            StringBuilder sql = new StringBuilder(600);
            sql.Append("select t.FILE_ID,t.FILE_VERSION,t.FILE_EDIT_TIME,t.FILE_UPLOAD_TIME from T_EAP_FILE t");
            sql.Append(" where 1=1");

            if (query.FILE_ID != string.Empty)
            {
                sql.Append("and t.FILE_ID like '%'||:FILE_ID||'%'");
                paracnt++;
            }

            if (query.FILE_VERSION != string.Empty)
            {
                sql.Append("and t.FILE_VERSION like '%'||:FILE_VERSION||'%'");
                paracnt++;
            }

            sql.Append(" order by t.FILE_ID");

            OracleParameter[] para = new OracleParameter[paracnt];

            for (int i = 0; i < paracnt; i++)
            {
                if (query.FILE_ID != string.Empty)
                {
                    para[i] = new OracleParameter(":FILE_ID", OracleType.VarChar);
                    para[i].Value = query.FILE_ID;
                    query.FILE_ID = string.Empty;
                    continue;
                }

                if (query.FILE_VERSION != string.Empty)
                {
                    para[i] = new OracleParameter(":FILE_VERSION", OracleType.VarChar);
                    para[i].Value = query.FILE_VERSION;
                    query.FILE_VERSION = string.Empty;
                    continue;
                }
            }

            return Oracle.GetOracle().QueryToPage<EapFile>(sql, para, pageno, pagesize, out icnt);
        }

        internal List<EapUser> GetUserList(EapUser user, int pageno, int pagesize, out int icnt)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.USER_ID,t.USER_NAME,t.IS_STOP,t1.vlist_detail_name as IS_STOP_NAME from T_EAP_USER t");
            sql.Append(" left join T_EAP_VALUE_LIST_DETAIL t1 on t.is_stop=t1.vlist_detail_value");
            sql.Append(" where t1.vlist_id='is_flag' and t.USER_ID!='admin' and t.USER_ID!='system'");
            sql.Append(" and (USER_NAME like '%'||:USER_NAME||'%' or :USER_NAME='-1')");
            sql.Append(" and (USER_ID like '%'||:USER_ID||'%' or :USER_ID='-1')");

            OracleParameter[] para ={
                                        new OracleParameter(":USER_NAME", OracleType.VarChar),
                                        new OracleParameter(":USER_ID", OracleType.VarChar)
                                    };
            para[0].Value = user.USER_NAME;
            para[1].Value = user.USER_ID;

            return Oracle.GetOracle().QueryToPage<EapUser>(sql, para, pageno, pagesize, out icnt);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string AddUser(EapUser user)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("insert into T_EAP_USER ");
            sql.Append("(USER_ID,USER_NAME,PWD,IS_STOP)");
            sql.Append(" values (:USER_ID,:USER_NAME,:PWD,:IS_STOP)");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":USER_NAME", OracleType.VarChar),
                new OracleParameter(":PWD", OracleType.VarChar),
                new OracleParameter(":IS_STOP", OracleType.Number)
            };
            para[0].Value = user.USER_ID;
            para[1].Value = user.USER_NAME;
            para[2].Value = Func.EncryptString("1", Config.GetConfig().DB_KEY);
            para[3].Value = user.IS_STOP;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string UpdateUser(EapUser user)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("update T_EAP_USER");
            sql.Append(" set USER_NAME=:USER_NAME,IS_STOP=:IS_STOP");
            sql.Append(" where USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":USER_NAME", OracleType.VarChar),
                new OracleParameter(":IS_STOP", OracleType.Number)
            };
            para[0].Value = user.USER_ID;
            para[1].Value = user.USER_NAME;
            para[2].Value = user.IS_STOP;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 是否存在用户（修改密码用）
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal bool IsUserExist(EapUser user)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select 1 from T_EAP_USER");
            sql.Append(" where USER_ID=:USER_ID and PWD=:PWD");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":PWD", OracleType.VarChar)
            };
            para[0].Value = user.USER_ID;
            para[1].Value = user.PWD;
            List<EapUser> list = new List<EapUser>();
            list = Oracle.GetOracle().QueryToList<EapUser>(sql, para);

            if (list == null)
                return false;

            if (list.Count <= 0)
                return false;

            return true;
        }

        internal bool IsUserExist(string userid)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select 1 from T_EAP_USER");
            sql.Append(" where USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar)
            };
            para[0].Value = userid;

            List<EapUser> list = new List<EapUser>();
            list = Oracle.GetOracle().QueryToList<EapUser>(sql, para);

            if (list == null)
                return false;

            if (list.Count <= 0)
                return false;

            return true;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string UpdatePwd(EapUser user)
        {

            StringBuilder sql = new StringBuilder(200);
            sql.Append("update T_EAP_USER");
            sql.Append(" set PWD=:PWD");
            sql.Append(" where USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":PWD", OracleType.VarChar)
            };
            para[0].Value = user.USER_ID;
            para[1].Value = user.PWD;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal List<EapMenu> GetUserAuthority()
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.menu_id,t.menu_name,t.parent_menu_id,t.form_name,t.assembly_name from t_eap_menu t");

            return Oracle.GetOracle().QueryToList<EapMenu>(sql);
        }

        /// <summary>
        /// 根据用户获取权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal List<EapUserMenuRight> GetAuthoritybyUser(string userid)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select r.user_menu_right_id,r.user_id,r.menu_id,m.menu_name from t_eap_user_menu_right r,t_eap_menu m where r.menu_id=m.menu_id");
            sql.Append(" and r.USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
            };
            para[0].Value = userid;
            return Oracle.GetOracle().QueryToList<EapUserMenuRight>(sql,para);
        }

        /// <summary>
        /// 创建用户权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private string CreateUserMenu(EapUserMenuRight UserMenu)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" insert into T_EAP_USER_MENU_RIGHT (USER_MENU_RIGHT_ID, USER_ID, MENU_ID)");
            sql.Append(" values (SEQ_EAP_USER_MENU_RIGHT.Nextval, :USER_ID,:MENU_ID)");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":MENU_ID", OracleType.VarChar)
            };
            para[0].Value = UserMenu.USER_ID;
            para[1].Value = UserMenu.MENU_ID;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 删除用户权限
        /// </summary>
        private string DelUserMenu(string UserID)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("delete T_EAP_USER_MENU_RIGHT T WHERE T.USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar)
            };
            para[0].Value = UserID;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 保存用户权限
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="list_right"></param>
        /// <returns></returns>
        internal string SaveUserMenuRight(string user_id, List<EapUserMenuRight> list_right)
        {
            //打开事务
            string ret = Oracle.GetOracle().BeginTran();
            if (ret != string.Empty)
            {
                return ret;
            }

            //删除已经拥有的权限
            ret = DelUserMenu(user_id);
            if (ret != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return ret;
            }

            //创建用户权限
            foreach (EapUserMenuRight sub in list_right)
            {
                ret = CreateUserMenu(sub);
                if (ret != string.Empty)
                {
                    Oracle.GetOracle().Rollback();
                    return ret;
                }
            }

            Oracle.GetOracle().Commit();
            return string.Empty;
        }

        /// <summary>
        /// 获取拥有指定菜单权限的用户（admin除外）
        /// </summary>
        /// <param name="menu_id">菜单编号</param>
        /// <returns></returns>
        internal List<EapUserMenuRight> GetNotInAdminMenuRight(string menu_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT USER_MENU_RIGHT_ID, USER_ID, MENU_ID FROM T_EAP_USER_MENU_RIGHT WHERE USER_ID!='admin' AND MENU_ID=:MENU_ID");

            OracleParameter[] para = { 
                                         new OracleParameter(":MENU_ID",OracleType.VarChar)
                                     };
            para[0].Value = menu_id;

            return Oracle.GetOracle().QueryToList<EapUserMenuRight>(sql, para);
        }

        /// <summary>
        /// 删除admin用户指定菜单权限
        /// </summary>
        /// <param name="menu_id"></param>
        /// <returns></returns>
        internal string DeleteAdminMenuRight(string menu_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE T_EAP_USER_MENU_RIGHT WHERE USER_ID='admin' AND MENU_ID=:MENU_ID");

            OracleParameter[] para = { 
                                         new OracleParameter(":MENU_ID",OracleType.VarChar)
                                     };
            para[0].Value = menu_id;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 应用服务进程监控
        /// </summary>
        /// <returns>应用服务进程数据集</returns>
        internal List<EapProcess> GetProcessStatus()
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t.process_id,a.vlist_detail_name as server_flag_name,t.process_name,");
            sql.Append("t.refresh_date,t.process_status,t.process_socket_status,t.server_flag,sysdate as DBTIME");
            sql.Append(" from t_eap_process_status t");
            sql.Append(" left outer join t_eap_value_list_detail a on a.vlist_id='server_flag' and t.server_flag=a.vlist_detail_value");
            sql.Append(" order by t.server_flag,t.process_id");
           return Oracle.GetOracle().QueryToList<EapProcess>(sql);
        }

        /// <summary>
        /// 获取获取应用服务进程刷新超时时间
        /// </summary>
        /// <returns></returns>
        internal EapParameter GetProcessRefreshTime()
        {
            return Oracle.GetOracle().GetParameter("ProcessRefreshTimeout");
        }

        /// <summary>
        /// 获取自定窗体权限按钮
        /// </summary>
        /// <param name="form_full_name"></param>
        /// <returns>按钮集合</returns>
        internal List<EapButton> GetFormUserAuthorityButton(EapMenu form_menu)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append(" SELECT T.BUTTON_ID,T.BUTTON_NAME,T.BUTTON_TEXT,T.MENU_ID FROM T_EAP_BUTTON T");
            sql.Append(" WHERE T.MENU_ID IN (SELECT A.MENU_ID FROM T_EAP_MENU A WHERE A.FORM_NAME=:FORM_NAME)");

            OracleParameter[] para = { 
                                         new OracleParameter(":FORM_NAME",OracleType.VarChar)
                                     };
            para[0].Value = form_menu.FORM_NAME;

            return Oracle.GetOracle().QueryToList<EapButton>(sql,para);
        }

        /// <summary>
        /// 删除用户指定菜单已有按钮权限
        /// </summary>
        /// <param name="user_id">用户</param>
        /// <param name="button_right_menu">菜单</param>
        /// <returns>错误信息，成功为空</returns>
        internal string DeleteUserButtonRight(string user_id, EapMenu button_right_menu)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("DELETE T_EAP_USER_BUTTON_RIGHT T WHERE T.USER_ID=:USER_ID");
            sql.Append(" AND T.BUTTON_ID IN (SELECT A.BUTTON_ID FROM T_EAP_BUTTON A WHERE A.MENU_ID IN (SELECT B.MENU_ID FROM T_EAP_MENU B WHERE B.FORM_NAME=:FORM_NAME))");

            OracleParameter[] para = { 
                                        new OracleParameter(":USER_ID",OracleType.VarChar),
                                        new OracleParameter(":FORM_NAME",OracleType.VarChar)
                                     };
            para[0].Value = user_id;
            para[1].Value = button_right_menu.FORM_NAME;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 创建用户按钮权限
        /// </summary>
        /// <param name="UserButton">权限实体</param>
        /// <returns>错误信息，成功为空</returns>
        internal string CreateUserFormButtonRight(EapUserButtonRight UserButton)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO T_EAP_USER_BUTTON_RIGHT (USER_BUTTON_RIGHT_ID,USER_ID,BUTTON_ID)");
            sql.Append(" VALUES(SEQ_EAP_BUTTON.NEXTVAL,:USER_ID,:BUTTON_ID)");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":BUTTON_ID", OracleType.VarChar)
            };
            para[0].Value = UserButton.USER_ID;
            para[1].Value = UserButton.BUTTON_ID;
           

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 修改打印张数权限
        /// </summary>
        /// <param name="print_position"></param>
        /// <param name="user_id"></param>
        /// <returns></returns>
        internal string update_print_position(string print_position,string user_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update T_EAP_USER t");
            sql.Append("   set t.print_position = '" + print_position + "'");
            sql.Append(" where t.user_id = '" + user_id + "'");

            return Oracle.GetOracle().ExecSql(sql);
        }

        /// <summary>
        /// 根据用户获取按钮权限
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <returns>按钮权限集合</returns>
        internal List<EapUserButtonRight> GetButtonAuthoritybyUser(string user_id)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("SELECT T.USER_BUTTON_RIGHT_ID,T.USER_ID,T.BUTTON_ID FROM T_EAP_USER_BUTTON_RIGHT T WHERE T.USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
            };
            para[0].Value = user_id;

            return Oracle.GetOracle().QueryToList<EapUserButtonRight>(sql, para);
        }
        //
        internal List<EapDepartment> GetDEPARTMENT_TYPE()
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select distinct department_type from t_eap_department");

            return Oracle.GetOracle().QueryToList<EapDepartment>(sql);
        }
        //获取表中装配线
        internal List<EapDepartment> GetASSEMBLY_LINE()
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select distinct ASSEMBLY_LINE from t_eap_department");

            return Oracle.GetOracle().QueryToList<EapDepartment>(sql);
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
            StringBuilder sql = new StringBuilder(200);
            string DEPARTMENT_TYPE = "";
            if (entity.DEPARTMENT_TYPE != "全部")
            {
                DEPARTMENT_TYPE = entity.DEPARTMENT_TYPE;
            }
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_CODE",entity.DEPARTMENT_CODE),
            new OracleParameter(":DEPARTMENT_NAME",entity.DEPARTMENT_NAME),
            new OracleParameter(":DEPARTMENT_TYPE",DEPARTMENT_TYPE),
            new OracleParameter(":ASSEMBLY_LINE",entity.ASSEMBLY_LINE),
            new OracleParameter(":STATUS",entity.STATUS)
            };
            sql.Append("select DEPARTMENT_ID,DEPARTMENT_CODE,DEPARTMENT_NAME,DEPARTMENT_TYPE,ASSEMBLY_LINE,STATUS,STATUS as STATUS_FALSE ");
            sql.Append(" from t_eap_department ");
            sql.Append(" where DEPARTMENT_CODE like '%'||:DEPARTMENT_CODE||'%' ");
            sql.Append(" and DEPARTMENT_NAME like '%'||:DEPARTMENT_NAME||'%' ");
            sql.Append(" and DEPARTMENT_TYPE like '%'||:DEPARTMENT_TYPE||'%' ");
            sql.Append(" and STATUS=:STATUS ");
            sql.Append(" order by DEPARTMENT_ID ");
            return Oracle.GetOracle().QueryToPage<EapDepartment>(sql, para, pageno, pagesize, out icnt);
        }

        /// <summary>
        /// 获取部门值
        /// </summary>
        /// <param name="DEPARTMENT_ID">部门id</param>
        /// <returns></returns>
        internal EapDepartment GetDEPARTMENTValue(string DEPARTMENT_ID)
        {
            StringBuilder sql = new StringBuilder(200);
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_ID",DEPARTMENT_ID)
            };

            sql.Append("select DEPARTMENT_ID,DEPARTMENT_CODE,DEPARTMENT_NAME,DEPARTMENT_TYPE,STATUS ");
            sql.Append(" from t_eap_department ");
            sql.Append(" where DEPARTMENT_ID=:DEPARTMENT_ID ");

            List<EapDepartment> list = Oracle.GetOracle().QueryToList<EapDepartment>(sql, para);
            if (list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 保存部门
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        internal string UpdateDEPARTMENT(EapDepartment entity)
        {
            StringBuilder sql = new StringBuilder(200);
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_ID",entity.DEPARTMENT_ID),
            new OracleParameter(":DEPARTMENT_CODE",entity.DEPARTMENT_CODE),
            new OracleParameter(":DEPARTMENT_NAME",entity.DEPARTMENT_NAME),
            new OracleParameter(":DEPARTMENT_TYPE",entity.DEPARTMENT_TYPE),
            new OracleParameter(":STATUS",entity.STATUS),
            };

            sql.Append(" update t_eap_department ");
            sql.Append(" set DEPARTMENT_CODE=:DEPARTMENT_CODE,DEPARTMENT_NAME=:DEPARTMENT_NAME,STATUS=:STATUS,DEPARTMENT_TYPE=:DEPARTMENT_TYPE ");
            sql.Append(" where DEPARTMENT_ID=:DEPARTMENT_ID ");

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        internal string AddDEPARTMENT(EapDepartment entity)
        {
            StringBuilder sql = new StringBuilder(200);
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_ID",entity.DEPARTMENT_ID),
            new OracleParameter(":DEPARTMENT_CODE",entity.DEPARTMENT_CODE),
            new OracleParameter(":DEPARTMENT_NAME",entity.DEPARTMENT_NAME),
            new OracleParameter(":DEPARTMENT_TYPE",entity.DEPARTMENT_TYPE),
            new OracleParameter(":STATUS",entity.STATUS),
            };

            sql.Append(" insert into t_eap_department ");
            sql.Append(" (DEPARTMENT_ID,DEPARTMENT_CODE,DEPARTMENT_NAME,DEPARTMENT_TYPE,STATUS) ");
            sql.Append(" values ");
            sql.Append(" (:DEPARTMENT_ID,:DEPARTMENT_CODE,:DEPARTMENT_NAME,:DEPARTMENT_TYPE,:STATUS) ");

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 计算部门id
        /// </summary>
        /// <returns></returns>
        internal decimal GetDEPARTMENT_ID()
        {
            try
            {
                StringBuilder sql = new StringBuilder(200);
                sql.Append("select SEQ_EAP_DEPARTMENT.nextval as DEPARTMENT_ID from dual");

                List<EapDepartment> list = Oracle.GetOracle().QueryToList<EapDepartment>(sql);

                if (list.Count > 0)
                {
                    return list[0].DEPARTMENT_ID;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 判断部门是否重复
        /// </summary>
        /// <param name="entity">数据集</param>
        /// <returns></returns>
        internal bool RepeatDEPARTMENT(string DEPARTMENT_NAME,decimal DEPARTMENT_ID)
        {
            StringBuilder sql = new StringBuilder(200);
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_NAME",DEPARTMENT_NAME),
            new OracleParameter(":DEPARTMENT_ID",DEPARTMENT_ID)
            };
            sql.Append("select 1 from t_eap_department where DEPARTMENT_NAME=:DEPARTMENT_NAME and DEPARTMENT_ID!=:DEPARTMENT_ID");

            if (Oracle.GetOracle().GetSqlCount(sql, para) > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        internal string DeleteDEPARTMENT(string DEPARTMENT_ID)
        {
            StringBuilder sql = new StringBuilder(200);
            OracleParameter[] para = new OracleParameter[]
            {
            new OracleParameter(":DEPARTMENT_ID",DEPARTMENT_ID)
            };

            sql.Append(" DELETE FROM t_eap_department ");
            sql.Append(" where DEPARTMENT_ID=:DEPARTMENT_ID ");

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 根据用户获取生产线权限
        /// </summary>
        /// <param name="user">用户ID</param>
        /// <returns>按钮权限集合</returns>
        internal List<EapUserTrimLine> GetLineAuthoritybyUser(string user_id)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("SELECT T.USER_ID,T.TRIM_LINE FROM T_EAP_USER_TRIM_LINE T WHERE T.USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
            };
            para[0].Value = user_id;

            return Oracle.GetOracle().QueryToList<EapUserTrimLine>(sql, para);
        }

        /// <summary>
        /// 创建用户生产线权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        internal string CreateUserLine(EapUserTrimLine UserLine)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" insert into T_EAP_USER_TRIM_LINE (USER_ID, TRIM_LINE)");
            sql.Append(" values (:USER_ID,:TRIM_LINE)");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar),
                new OracleParameter(":TRIM_LINE", OracleType.Number)
            };
            para[0].Value = UserLine.USER_ID;
            para[1].Value = UserLine.TRIM_LINE;

            return Oracle.GetOracle().ExecSql(sql, para);
        }

        /// <summary>
        /// 删除用户生产线权限
        /// </summary>
        internal string DelUserLine(string UserID)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("delete T_EAP_USER_TRIM_LINE T WHERE T.USER_ID=:USER_ID");

            OracleParameter[] para = {
                new OracleParameter(":USER_ID", OracleType.VarChar)
            };
            para[0].Value = UserID;

            return Oracle.GetOracle().ExecSql(sql, para);
        }
    }
}
