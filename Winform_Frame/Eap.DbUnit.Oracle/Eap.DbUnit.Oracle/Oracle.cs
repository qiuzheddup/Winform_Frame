//不显示函数过期警告
#pragma warning disable 0618

using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Data.OracleClient;

using Eap.Enum;
using Eap.Entity;

//using System.IO;
//using System.Runtime.Serialization.Formatters.Soap;
using Eap;

namespace Eap.DbUnit
{
    public class Oracle
    {
        //默认对象
        private static Oracle oracle;
        //数据库连接字符串
        private string constr;
        //数据库连接对象
        private OracleConnection con;
        //数据库事务对象
        private OracleTransaction tran;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip">服务器IP地址</param>
        /// <param name="dbname">数据源</param>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        public Oracle(string ip, string dbname, string uid, string pwd)
        {
            constr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={1})));User ID={2};Password={3};";
            constr = string.Format(constr, ip, Func.DecryptString(dbname, Config.GetConfig().DB_KEY), Func.DecryptString(uid, Config.GetConfig().DB_KEY), Func.DecryptString(pwd, Config.GetConfig().DB_KEY));

            con = new OracleConnection(constr);
        }

        /// <summary>
        /// 返回默认对象
        /// </summary>
        /// <returns></returns>
        public static Oracle GetOracle()
        {
            if (oracle == null)
                oracle = new Oracle(Config.GetConfig().DB_IP, Config.GetConfig().DB_NAME, Config.GetConfig().DB_UID, Config.GetConfig().DB_PWD);

            return oracle;
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <returns>错误原因，为空表示成功</returns>
        private string Open()
        {
            try
            {
                con.Open();
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private void Close()
        {
            con.Close();
        }

        /// <summary>
        /// 开始事务
        /// </summary>
        /// <returns>错误原因，为空表示成功</returns>
        public string BeginTran()
        {
            string ret = Open();
            if (ret != string.Empty)
            {
                return ret;
            }

            try
            {
                tran = con.BeginTransaction();
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (tran != null)
            {
                tran.Commit();
            }

            tran = null;
            Close();
        }

        /// <summary>
        /// 回滚事务
        /// </summary>
        public void Rollback()
        {
            if (tran != null)
            {
                tran.Rollback();
            }

            tran = null;
            Close();
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql">要执行的Sql语句</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string ExecSql(StringBuilder sql)
        {
            return ExecSql(sql, null);
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql">要执行的Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string ExecSql(StringBuilder sql, OracleParameter[] para)
        {
            try
            {
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return ret;
                    }
                }

                OracleCommand cmd = new OracleCommand(sql.ToString(), con);

                if (tran != null)
                {
                    cmd.Transaction = tran;
                }

                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        cmd.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }

                cmd.ExecuteNonQuery();
                return string.Empty;
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran = null;
                }

                return ex.Message;
            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql">要执行的Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <returns>影响行数</returns>
        public int ExecSqlCount(StringBuilder sql, OracleParameter[] para)
        {
            try
            {
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return -1;
                    }
                }

                OracleCommand cmd = new OracleCommand(sql.ToString(), con);

                if (tran != null)
                {
                    cmd.Transaction = tran;
                }

                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        cmd.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }
                return cmd.ExecuteNonQuery();
            }
            catch (System.Exception e1)
            {
                Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>NEW" + "/ConStatus:" + con.State  );
                if (tran != null)
                {
                    tran.Rollback();
                    tran = null;
                }

                return -1;
            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// 执行Sql语句，返回用户指定页的数据
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <param name="pno">当前页</param>
        /// <param name="psize">页大小</param>
        /// <param name="icnt">符合条件的总记录数</param>
        /// <returns>获取的实体类集</returns>
        public List<T> QueryToPage<T>(StringBuilder sql, OracleParameter[] para, int pno, int psize, out int icnt)
        {
            icnt = -1;

            if (pno < 1)
            {
                return null;
            }

            //获取本次查询影响的记录行数
            icnt = GetSqlCount(sql, para);
            if (icnt == -1)
            {
                return null;
            }

            //查询指定页的数据
            StringBuilder newsql = new StringBuilder();
            newsql.AppendFormat("select * from (select ROWNUM as NO,tt.* from ({0}) tt", sql);
            newsql.AppendFormat(" where ROWNUM<={0})", pno * psize);
            newsql.AppendFormat(" where NO>={0}", (pno - 1) * psize + 1);

            return QueryToList<T>(newsql, para);
        }

        /// <summary>
        /// 获取指定Sql查询语句影响的行数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>-1：失败；其他：影响的行数</returns>
        public int GetSqlCount(StringBuilder sql, OracleParameter[] para)
        {
            StringBuilder newsql = new StringBuilder();
            newsql.AppendFormat("select count(1) as CNT from ({0}) tt", sql);

            List<EapSqlCount> list = QueryToList<EapSqlCount>(newsql, para);
            if (list == null || list.Count != 1)
            {
                return -1;
            }

            return Convert.ToInt32(list[0].CNT);
        }

        /// <summary>
        /// 执行Sql语句，返回用户指定的List实体类型集合
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <returns>获取的实体类集</returns>
        public List<T> QueryToList<T>(StringBuilder sql)
        {
            return QueryToList<T>(sql, null);
        }

        public DataTable GetDataTable(StringBuilder sql, OracleParameter[] para)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(sql.ToString(), con);
                DataSet ds = new DataSet();

                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return null;
                    }
                }
                else
                {
                    cmd.Transaction = tran;
                }

                OracleDataAdapter ada = new OracleDataAdapter(cmd);

                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        ada.SelectCommand.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }

                ada.Fill(ds);
                if (ds != null)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch(System.Exception e1)
            {
                Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>NEW" + "/ConStatus:" + con.State  );
                return null;
            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// 执行Sql语句，返回用户指定的List实体类型集合
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <returns>获取的实体类集</returns>
        public List<T> QueryToList<T>(StringBuilder sql, OracleParameter[] para)
        {
            List<T> list = new List<T>();
            DataSet ds = new DataSet();

            try
            {
                OracleCommand cmd = new OracleCommand(sql.ToString(), con);
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return null;
                    }
                }
                else
                {
                    cmd.Transaction = tran;
                }

                OracleDataAdapter ada = new OracleDataAdapter(cmd);

                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        ada.SelectCommand.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }

                ada.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    T t = Activator.CreateInstance<T>();

                    //通过反射取得对象所有的属性并赋值
                    foreach (PropertyInfo pro in typeof(T).GetProperties())
                    {
                        //如果列存在就赋值
                        if (ds.Tables[0].Columns.Contains(pro.Name))
                        {
                            if (dr[pro.Name] != DBNull.Value)
                            {
                                switch (pro.PropertyType.FullName)
                                {
                                    case "System.String":
                                        pro.SetValue(t, dr[pro.Name].ToString(), null);
                                        break;
                                    default:
                                        pro.SetValue(t, dr[pro.Name], null);
                                        break;
                                }
                            }
                        }
                    }

                    list.Add(t);
                }

                return list;
            }
            catch(System.Exception e1)
            {
                if (con != null)
                    Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>OLD" + "/ConStatus:" + con.State  );
                else
                    Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>OLD" + "/ConStatus: con 为空"  );
                return null;

            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="pname">存储过程名</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string ExecProc(string pname)
        {
            return ExecProc(pname, null, null);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="pname">存储过程名</param>
        /// <param name="para">输入参数列表</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string ExecProc(string pname, OracleParameter[] para)
        {
            return ExecProc(pname, para, null);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="pname">存储过程名</param>
        /// <param name="in_para">输入参数列表</param>
        /// <param name="out_para">输出参数列表</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string ExecProc(string pname, OracleParameter[] in_para, OracleParameter[] out_para)
        {
            try
            {
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return ret;
                    }
                }

                OracleCommand cmd = new OracleCommand(pname, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (in_para != null)
                {
                    foreach (OracleParameter spa in in_para)
                    {
                        spa.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(spa);
                    }
                }

                if (out_para != null)
                {
                    foreach (OracleParameter spb in out_para)
                    {
                        spb.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(spb);
                    }
                }

                if (tran != null)
                {
                    cmd.Transaction = tran;
                }

                cmd.ExecuteNonQuery();
                if (out_para != null)
                {
                    for (int i = 0; i < out_para.Length; i++)
                    {
                        if (in_para != null)
                            out_para[i].Value = cmd.Parameters[i + in_para.Length].Value;
                        else
                            out_para[i].Value = cmd.Parameters[i].Value;
                    }
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran = null;
                }

                return ex.Message;
            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// 获取指定参数的值
        /// </summary>
        /// <param name="para_id">参数ID</param>
        /// <returns>参数实体</returns>
        public EapParameter GetParameter(string para_id)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.PARA_ID,t.PARA_NAME,t.PARA_VALUE from T_EAP_PARAMETER t where t.PARA_ID=:PARA_ID");

            OracleParameter[] para = {
                new OracleParameter(":PARA_ID", OracleType.VarChar)
            };
            para[0].Value = para_id;

            List<EapParameter> list = QueryToList<EapParameter>(sql, para);
            
            if (list == null)
                return null;

            if (list.Count == 0)
                return null;

            return list[0];
        }

        /// <summary>
        /// 设置指定参数的值
        /// </summary>
        /// <param name="para_id">参数ID</param>
        /// <param name="para_value">参数的值</param>
        /// <returns>错误原因，为空表示成功</returns>
        public string SetParameter(string para_id, string para_value)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("update T_EAP_PARAMETER t set t.PARA_VALUE=:PARA_VALUE where t.PARA_ID=:PARA_ID");

            OracleParameter[] para = {
                new OracleParameter(":PARA_VALUE", OracleType.VarChar),
                new OracleParameter(":PARA_ID", OracleType.VarChar),
            };
            para[0].Value = para_value;
            para[1].Value = para_id;

            return ExecSql(sql, para);
        }

        /// <summary>
        /// 获取指定值列表的明细
        /// </summary>
        /// <param name="vlist_id">值列表ID</param>
        /// <returns>值列表明细</returns>
        public List<EapValueListDetail> GetValueListDetail(string vlist_id)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("select t.VLIST_DETAIL_ID,t.VLIST_ID,t.VLIST_DETAIL_VALUE,t.VLIST_DETAIL_NAME");
            sql.Append(" from T_EAP_VALUE_LIST_DETAIL t where t.VLIST_ID=:VLIST_ID");
            sql.Append(" order by t.VLIST_DETAIL_VALUE");

            OracleParameter[] para = {
                new OracleParameter(":VLIST_ID", OracleType.VarChar)
            };
            para[0].Value = vlist_id;

            return QueryToList<EapValueListDetail>(sql, para);
        }

        /// <summary>
        /// 更新进程状态
        /// <param name="process_id">进程ID</param>
        /// <param name="field">字段</param>
        /// <param name="fieldvalue">字段值</param>
        /// <returns>错误原因，为空表示成功</returns>
        public int UpdateProcessStatus(string process_id, string field, string fieldvalue)
        {
            StringBuilder sql = new StringBuilder(200);
            sql.Append("update t_eap_process_status t set t." + field + "=" + fieldvalue + " where t.process_id='" + process_id+"'");
            return ExecSqlCount(sql, null);
        }

        /// <summary>
        /// 获取进程实体
        /// </summary>
        /// <param name="process_id">进程ID</param>
        /// <returns>进程实体</returns>
        public EapProcess GetProcess(string process_id)
        {
            StringBuilder sql = new StringBuilder(100);
            sql.Append("select t.process_id,t.process_name,t.refresh_date,t.process_status,t.process_socket_status,t.process_url,t.server_flag from t_eap_process_status t where t.PROCESS_ID=:PROCESS_ID");

            OracleParameter[] para = {
                new OracleParameter(":PROCESS_ID", OracleType.VarChar)
            };
            para[0].Value = process_id;

            List<EapProcess> list = QueryToList<EapProcess>(sql, para);

            if (list == null)
                return null;

            if (list.Count == 0)
                return null;

            return list[0];
        }

        /// <summary>
        /// 获取数据库服务器时间
        /// </summary>
        /// <returns>成功：数据库时间；失败：最小时间值</returns>
        public DateTime GetServerDateTime()
        {
            DataSet ds = new DataSet();
            StringBuilder sql = new StringBuilder("select sysdate from dual");

            try
            {
                OracleCommand cmd = new OracleCommand(sql.ToString(), con);
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return DateTime.MinValue;
                    }
                }
                else
                {
                    cmd.Transaction = tran;
                }

                OracleDataAdapter ada = new OracleDataAdapter(cmd);

                ada.Fill(ds);

                return Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
            }
            catch
            {
                return DateTime.MinValue;
            }
            finally
            {
                if (tran == null)
                {
                    Close();
                }
            }
        }



        /// <summary>
        /// 获取指定Sql查询语句影响的行数 采用新链接
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="para">参数</param>
        /// <param name="isNewConn">是否是新链接；true 新链接，为新建方法</param>
        /// <returns>-1：失败；其他：影响的行数</returns>
        public int GetSqlCount(StringBuilder sql, OracleParameter[] para,bool isNewConn)
        {
            StringBuilder newsql = new StringBuilder();
            newsql.AppendFormat("select count(1) as CNT from ({0}) tt", sql);

            List<EapSqlCount> list = QueryToList<EapSqlCount>(newsql, para,true);
            if (list == null || list.Count != 1)
            {
                return -1;
            }

            return Convert.ToInt32(list[0].CNT);
        }




        /// <summary>
        /// 执行Sql语句，返回用户指定的List实体类型集合
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <param name="isNewConn">是否建立新链接。true: 是，调用新方法。false,否：调用原有方法</param>
        /// <returns>获取的实体类集</returns>
        public List<T> QueryToList<T>(StringBuilder sql, OracleParameter[] para, bool isNewConn = true ) 
        {
            if (!isNewConn)
            {
                return QueryToList<T>(sql, para);
            }


            List<T> list = new List<T>();
            DataSet ds = new DataSet();

            string testMsg = "Init";

            using(OracleConnection conn_new =  new OracleConnection(constr))
            try
            {   
                testMsg = "new OracleConnection(constr)";
                OracleCommand cmd = new OracleCommand(sql.ToString(), conn_new);
                testMsg = "new OracleCommand(sql.ToString(), conn_new)"; 
          
                    conn_new.Open(); 
               

                OracleDataAdapter ada = new OracleDataAdapter(cmd); 

                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        ada.SelectCommand.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }

                ada.Fill(ds);
                testMsg = "ada.Fill(ds)";

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    T t = Activator.CreateInstance<T>();

                    testMsg = "Activator.CreateInstance<T>()";

                    //通过反射取得对象所有的属性并赋值
                    foreach (PropertyInfo pro in typeof(T).GetProperties())
                    {
                        //如果列存在就赋值
                        if (ds.Tables[0].Columns.Contains(pro.Name))
                        {
                            if (dr[pro.Name] != DBNull.Value)
                            {
                                switch (pro.PropertyType.FullName)
                                {
                                    case "System.String":
                                        pro.SetValue(t, dr[pro.Name].ToString(), null);
                                        break;
                                    default:
                                        pro.SetValue(t, dr[pro.Name], null);
                                        break;
                                }
                            }
                        }
                    }

                    list.Add(t);
                }

                return list;
            }
            catch (System.Exception e1)
            {
                if (con != null)
                    Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>NEW" + "/ConStatus:" + con.State + "/str:" + testMsg);
                else
                    Log.WriteFile(MessageType.Error, "ErrorMessage:" + e1.Message + "/QueryToList<T>NEW" + "/ConStatus: con 为空" + "/str:" + testMsg);


                #region 将Excepetion的object输出到ＸＭＬ
                //DateTime now = DateTime.Now;
                //string path = AppDomain.CurrentDomain.BaseDirectory;
                //string str2 = path + @"\bin\" + Func.FormatDate(now, true) + "MES2ErrorData.xml"; 

                //Stream stream = File.Open(str2, FileMode.OpenOrCreate);
                //System.Runtime.Serialization.Formatters.Soap.SoapFormatter formatter = new SoapFormatter();
                //formatter.Serialize(stream, e1);
                //stream.Close();

                //Log.WriteFile(MessageType.Error, "错误日志已经输出到 bin:MES2ErrorData.xml");
                #endregion


                return null;

            }
            finally
            { 
                conn_new.Close();
                conn_new.Dispose(); 
            }
        }




        /// <summary>
        /// 执行Sql语句，返回用户指定的List实体类型集合
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <param name="isNewConn">是否建立新链接。都是调用新方法</param>
        /// <returns>获取的实体类集</returns>
        public List<T> QueryToList<T>(StringBuilder sql ,bool isNewConn = true )
        {
            return QueryToList<T>(sql, null,true);
        }

        /// <summary>
        /// 执行sql语句，返回单行结果
        /// </summary>
        /// <typeparam name="T">要返回的实体类型</typeparam>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">参数列表</param>
        /// <returns></returns>
        public List<string> QueryOneLine(StringBuilder sql)
        {
            return QueryOneLine(sql, null);
        }
        public List<string> QueryOneLine(StringBuilder sql, OracleParameter[] para)
        {
            List<string> list = new List<string>();

            try
            {
                OracleCommand cmd = new OracleCommand(sql.ToString(), con);
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return null;
                    }
                }
                else
                {
                    cmd.Transaction = tran;
                }
                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        cmd.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        list.Add(reader[i].ToString());
                    }
                }
                reader.Close();
                con.Close();
                return list;
            }
            catch (Exception ex)
            {
                list.Clear();
                list.Add(ex.Message);
                return list;
            }
        }


        public string getOneResult(StringBuilder sql)
        {
            return getOneResult(sql, null);
        }
        public string getOneResult(StringBuilder sql, OracleParameter[] para)
        {
            string result = string.Empty;
            try
            {
                if (tran == null)
                {
                    string ret = Open();
                    if (ret != string.Empty)
                    {
                        return ret;
                    }
                }
                OracleCommand comm = new OracleCommand(sql.ToString(), this.con);
                if (para != null)
                {
                    foreach (OracleParameter spara in para)
                    {
                        comm.Parameters.Add((OracleParameter)((ICloneable)spara).Clone());
                    }
                }
                OracleDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    result = reader[0].ToString();
                }
                reader.Close();
                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
        }

    }
}
