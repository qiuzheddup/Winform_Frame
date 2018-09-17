using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

using Eap.Entity;
using Eap.DbUnit;

namespace Eap
{
    public static class ButtonRight
    {
        private static string form_fullname = string.Empty;

        public static void FormatFormButtonEnabled(System.Windows.Forms.Form form)
        {
            try
            {
                 form_fullname = form.GetType().FullName;
                List<EapButton> form_buttons_right = GetUserButtonRight(form_fullname, Eap.Config.GetConfig().user.USER_ID);
                if (form_buttons_right == null)
                    throw new Exception("获取用户按钮权限失败");
                GetFormButtons(form, form_buttons_right);
            }
            catch (Exception ex)
            {
                Func.ShowMessage(Enum.MessageType.Error, ex.Message);
                form.Close();
            }
        }

        private static void GetFormButtons(System.Windows.Forms.Control InitC, List<EapButton> user_button_right)
        {
            foreach (System.Windows.Forms.Control initC in InitC.Controls)
            {
                //如果是tabControl空间，遍历tabControl中所有的按钮
                if (initC is System.Windows.Forms.TabControl)
                {
                    GetTabControlButtons(initC as System.Windows.Forms.TabControl, user_button_right);
                    continue;
                }


                //过滤控件按钮
                if (initC is Eap.Control.ButtonEx)
                {
                    if (initC.Name == "btnQuery" || initC.Name == "btnExit" || initC.Name == "btnClear" || initC.Name == "btnCancle"//查询按钮、退出按钮、清除按钮、取消按钮
                        || initC.Name == "btnRefresh" || initC.Name == "btnLeft" || initC.Name == "btnRight" || initC.Name == "btnPageHome"//刷新按钮、左页按钮、右页按钮、首页按钮
                        || initC.Name == "btnPageUp" || initC.Name == "btnPageDown" || initC.Name == "btnPageEnd" || initC.Name == "btnGoPage")//上页按钮、下页按钮、尾页按钮、页面跳转按钮
                        continue;

                    EapButton temp = user_button_right.Where(p => p.BUTTON_NAME == initC.Name).FirstOrDefault<EapButton>();

                    //按钮没有添加到按钮表：1、该用户不具备按钮权限；2、添加按钮到数据库
                    if (temp == null)
                    {
                        temp = new EapButton();
                        temp.BUTTON_NAME = initC.Name;
                        temp.BUTTON_TEXT = initC.Text == string.Empty ? initC.Name : initC.Text;

                        AddFormButtonData(temp, form_fullname);

                        initC.Enabled = false;
                        continue;
                    }

                    //该用户不具备按钮权限
                    if (temp.USER_ID == null || temp.USER_ID == string.Empty)
                    {
                        initC.Enabled = false;
                        continue;
                    }

                    //具有按钮权限
                    initC.Enabled = true;
                    continue;
                }

                if (initC.Controls.Count != 0)
                {
                    GetFormButtons(initC, user_button_right);
                }
            }
        }

        private static List<EapButton> GetUserButtonRight(string form_fullname, string user_id)
        {
            StringBuilder sql = new StringBuilder(250);
            sql.Append("SELECT T.BUTTON_ID,T.BUTTON_NAME,T.BUTTON_TEXT,T.MENU_ID,A.USER_ID ");
            sql.Append("FROM T_EAP_BUTTON T ");
            sql.Append("LEFT OUTER JOIN T_EAP_USER_BUTTON_RIGHT A ON T.BUTTON_ID=A.BUTTON_ID AND A.USER_ID=:USER_ID ");
            sql.Append("WHERE T.MENU_ID IN (SELECT A.MENU_ID FROM T_EAP_MENU A WHERE A.FORM_NAME=:FORM_NAME)");

            OracleParameter[] para = { 
                                         new OracleParameter(":USER_ID",OracleType.VarChar),
                                         new OracleParameter(":FORM_NAME",OracleType.VarChar),
                                     };
            para[0].Value = user_id;
            para[1].Value = form_fullname;

            return Oracle.GetOracle().QueryToList<EapButton>(sql, para);
        }

        /// <summary>
        /// 添加按钮数据
        /// </summary>
        /// <param name="entity_add">添加实体</param>
        /// <returns>错误信息，成功为空</returns>
        internal static string AddFormButtonData(EapButton entity_add,string form_fullname)
        {
            //开启事务
            string ret_msg = Oracle.GetOracle().BeginTran();
            if (ret_msg != string.Empty)
            {
                return "打开事务失败，原因[" + ret_msg + "]";
            }

            StringBuilder sql = new StringBuilder(200);
            sql.Append("INSERT INTO T_EAP_BUTTON(BUTTON_ID,BUTTON_NAME,BUTTON_TEXT,MENU_ID)");
            sql.Append(" SELECT SEQ_EAP_BUTTON.NEXTVAL,:BUTTON_NAME,:BUTTON_TEXT,A.MENU_ID");
            sql.Append("  FROM  T_EAP_MENU A WHERE A.FORM_NAME=:FORM_NAME");

            OracleParameter[] para = { 
                                         new OracleParameter(":BUTTON_NAME",OracleType.VarChar),
                                         new OracleParameter(":BUTTON_TEXT",OracleType.VarChar),
                                         new OracleParameter(":FORM_NAME",OracleType.VarChar)
                                     };
            para[0].Value = entity_add.BUTTON_NAME;
            para[1].Value = entity_add.BUTTON_TEXT;
            para[2].Value = form_fullname;

            ret_msg = Oracle.GetOracle().ExecSql(sql, para);
            if (ret_msg != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return "新增按钮数据失败，原因[" + ret_msg + "]";
            }

            //给admin(超级管理员）
            sql.Clear();
            para = null;
            sql.Append(" insert into T_EAP_USER_BUTTON_RIGHT  (user_button_right_id,USER_ID,BUTTON_ID)");
            sql.Append(" select SEQ_EAP_USER_BUTTON_RIGHT.nextval,:user_id,BUTTON_ID from t_eap_button");
            sql.Append(" where button_id not in (select BUTTON_ID from T_EAP_USER_BUTTON_RIGHT t where t.user_id=:user_id)");

            OracleParameter[] para_right = { 
                                               new OracleParameter(":user_id",OracleType.VarChar)
                                           };
            //para_right[0].Value = Eap.Config.GetConfig().user.USER_ID;
            para_right[0].Value = "admin";

            ret_msg = Oracle.GetOracle().ExecSql(sql, para_right);
            if (ret_msg != string.Empty)
            {
                Oracle.GetOracle().Rollback();
                return "给超级管理员Admin授权按钮失败，原因[" + ret_msg + "]";
            }

            //处理成功
            Oracle.GetOracle().Commit();
            return string.Empty;
        }

        /// <summary>
        /// 获取TabControl中的所有按钮
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="user_button_right"></param>
        /// <returns></returns>
        internal static string GetTabControlButtons(System.Windows.Forms.TabControl tab, List<EapButton> user_button_right)
        {

            foreach (System.Windows.Forms.TabPage page in tab.TabPages)
            {
                foreach (System.Windows.Forms.Control initC in page.Controls)
                {
                    //过滤控件按钮
                    if (initC is Eap.Control.ButtonEx)
                    {
                        if (initC.Name == "btnQuery" || initC.Name == "btnExit" || initC.Name == "btnClear" || initC.Name == "btnCancle"//查询按钮、退出按钮、清除按钮、取消按钮
                            || initC.Name == "btnRefresh" || initC.Name == "btnLeft" || initC.Name == "btnRight" || initC.Name == "btnPageHome"//刷新按钮、左页按钮、右页按钮、首页按钮
                            || initC.Name == "btnPageUp" || initC.Name == "btnPageDown" || initC.Name == "btnPageEnd" || initC.Name == "btnGoPage")//上页按钮、下页按钮、尾页按钮、页面跳转按钮
                            continue;

                        EapButton temp = user_button_right.Where(p => p.BUTTON_NAME == initC.Name).FirstOrDefault<EapButton>();

                        //按钮没有添加到按钮表：1、该用户不具备按钮权限；2、添加按钮到数据库
                        if (temp == null)
                        {
                            temp = new EapButton();
                            temp.BUTTON_NAME = initC.Name;
                            temp.BUTTON_TEXT = initC.Text == string.Empty ? initC.Name : initC.Text;

                            AddFormButtonData(temp, form_fullname);

                            initC.Enabled = false;
                            continue;
                        }

                        //该用户不具备按钮权限
                        if (temp.USER_ID == null || temp.USER_ID == string.Empty)
                        {
                            initC.Enabled = false;
                            continue;
                        }

                        //具有按钮权限
                        initC.Enabled = true;
                        continue;
                    }
                }
            }


            return null;
        }
    }
}
