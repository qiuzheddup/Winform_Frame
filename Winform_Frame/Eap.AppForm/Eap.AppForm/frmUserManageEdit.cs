using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Eap.Enum;
using Eap.Entity;
using Eap.DbUnit;

namespace Eap.AppForm
{
    public partial class frmUserManageEdit : Form
    {
        private EditMode em;
        private EapUser user;

        public frmUserManageEdit(EditMode para_em, EapUser entity)
        {
            InitializeComponent();

            Func.FormatForm(this);

            em = para_em;
            user = entity;

            if (em == EditMode.Add)
                this.Text += "-新增";
            else if (em == EditMode.Edit)
                this.Text += "-修改";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EapUser user = getEapUser();
            if (user == null)
                return;

            if (em == EditMode.Add)
            {
                if (Bll.GetBll().IsUserExist(user.USER_ID))
                {
                    Func.ShowMessage(MessageType.Error, "用户已经存在！");
                    txtUserID.Focus();
                    return;
                }
                string ret = Bll.GetBll().AddUser(user);
                if (ret == "")
                {
                    //用户生产线权限添加失败即退出
                    if (!IsQueueUserTrimLine(user.USER_ID))
                        return;
                    Func.ShowMessage(MessageType.Information, "添加用户成功！");
                    Log.Write(MessageType.Information, "添加用户成功,用户ID[" + user.USER_ID + "]", Eap.Config.GetConfig().user.USER_ID);
                    this.Close();
                }
                else
                {
                    Func.ShowMessage(MessageType.Error, ret);
                }
            }
            else if (em == EditMode.Edit)
            {
                string ret = Bll.GetBll().UpdateUser(user);
                if (ret == "")
                {
                    //用户生产线权限添加失败即退出
                    if (!IsQueueUserTrimLine(user.USER_ID))
                        return;
                    Func.ShowMessage(MessageType.Information, "修改用户成功！");
                    Log.Write(MessageType.Information, "修改用户成功,用户ID[" + user.USER_ID + "],用户名[" + user.USER_NAME + "],用户状态[" + user.IS_STOP + "]", Eap.Config.GetConfig().user.USER_ID);
                    this.Close();
                }
                else
                {
                    Func.ShowMessage(MessageType.Error, ret);
                }
            }
        }

        private void frmUserManageEdit_Load(object sender, EventArgs e)
        {
            BindIsStop();
            Bind_assembly_line();

            if (em == EditMode.Edit)
            {
                //如果是系统管理员账户admin允许重置用户密码
                if (Eap.Config.GetConfig().user.USER_ID == "admin")
                {
                    btnResetPwd.Visible = true;
                }

                this.txtUserID.ReadOnly = true;
                txtUserID.Text = user.USER_ID;
                txtUserName.Text = user.USER_NAME;

                foreach (Object obj in cboIsStop.Items)
                {
                    EapItem item = (EapItem)obj;
                    if (item.ID == user.IS_STOP.ToString())
                    {
                        cboIsStop.SelectedItem = obj;
                        break;
                    }
                }

                //绑定该用户生产线权限
                BindTrimLine();
            }
        }

        /// <summary>
        /// 判断是否成功添加用户生产线权限
        /// </summary>
        private bool IsQueueUserTrimLine(string user_id)
        {
            List<EapUserTrimLine> list_trim_line = new List<EapUserTrimLine>();
            EapUserTrimLine UserLine;

            int count = chk_Assembly_Line.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (chk_Assembly_Line.GetItemChecked(i))
                {
                    UserLine = new EapUserTrimLine();
                    UserLine.USER_ID = user_id;
                    UserLine.TRIM_LINE = (chk_Assembly_Line.Items[i] as EapValueListDetail).VLIST_DETAIL_VALUE;
                    list_trim_line.Add(UserLine);
                }
            }

            if (list_trim_line == null || list_trim_line.Count == 0)
                return true;

            string ret = Bll.GetBll().SaveUserTrimLine(list_trim_line);

            if (ret != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, ret);
                Log.Write(MessageType.Error, "用户总装生产线授权失败，原因[" + ret + "]", Eap.Config.GetConfig().user.USER_ID);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 绑定该用户生产线权限
        /// </summary>
        private void BindTrimLine()
        {
            List<EapUserTrimLine> list_trim_line = Bll.GetBll().GetLineAuthoritybyUser(user.USER_ID);
            if (list_trim_line == null || list_trim_line.Count == 0)
                return;

            foreach (EapUserTrimLine sub in list_trim_line)
            {
                for (int i = 0; i < chk_Assembly_Line.Items.Count; i++)
                {
                    if (sub.TRIM_LINE.Equals((chk_Assembly_Line.Items[i] as EapValueListDetail).VLIST_DETAIL_VALUE))
                    {
                        chk_Assembly_Line.SetItemChecked(i, true);
                    }
                }
            }

        }

        /// <summary>
        /// 绑定用户是否停用
        /// </summary>
        private void BindIsStop()
        {
            cboIsStop.Items.Clear();

            List<EapValueListDetail> list = Oracle.GetOracle().GetValueListDetail("is_flag");
            if (list == null || list.Count == 0)
                return;

            foreach (EapValueListDetail sub in list)
            {
                cboIsStop.Items.Add(new EapItem(sub.VLIST_DETAIL_VALUE.ToString(), sub.VLIST_DETAIL_NAME));
            }
        }

        /// <summary>
        /// 绑定装配线
        /// </summary>
        private void Bind_assembly_line()
        {
            chk_Assembly_Line.Items.Clear();
            List<EapValueListDetail> list1 = Oracle.GetOracle().GetValueListDetail("production_line");
            //if (list1 != null)
            //{
            //    foreach (EapValueListDetail sub in list1)
            //    {
            //        chk_Assembly_Line.Items.Add(new EapItem(sub.VLIST_DETAIL_VALUE.ToString(), sub.VLIST_DETAIL_NAME));
            //    }
            //}
            chk_Assembly_Line.DataSource = list1;
            chk_Assembly_Line.ValueMember = "VLIST_DETAIL_VALUE";
            chk_Assembly_Line.DisplayMember = "VLIST_DETAIL_NAME";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private EapUser getEapUser()
        {
            if (txtUserID.Text.Trim() == "")
            {
                Func.ShowMessage(MessageType.Error, "用户ID不能为空");
                return null;
            }

            if (txtUserName.Text.Trim() == "")
            {
                Func.ShowMessage(MessageType.Error, "用户姓名不能为空");
                return null;
            }

            EapUser user = new EapUser();
            user.USER_ID = txtUserID.Text.Trim();
            user.USER_NAME = txtUserName.Text.Trim();

            if (cboIsStop.SelectedIndex == -1)
            {
                Func.ShowMessage(MessageType.Error, "请选择停用状态");
                cboIsStop.Focus();
                return null;
            }
            user.IS_STOP = Convert.ToDecimal(((EapItem)cboIsStop.SelectedItem).ID);

            if (Func.StringLength(user.USER_ID) > 20)
            {
                Func.ShowMessage(MessageType.Error, "用户编号最大长度为20个字符（10个汉字）");
                return null;
            }

            if (Func.StringLength(user.USER_NAME) > 20)
            {
                Func.ShowMessage(MessageType.Error, "用户姓名最大长度为20个字符（10个汉字）");
                return null;
            }

            return user;
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            EapUser reset_pwd = new EapUser();
            reset_pwd.USER_ID = txtUserID.Text.Trim();
            reset_pwd.PWD = Func.EncryptString("1", Config.GetConfig().DB_KEY);

            string ret = Bll.GetBll().UpdatePwd(reset_pwd);
            if (ret != string.Empty)
            {
                string msg = "重置密码失败，用户ID[" + reset_pwd.USER_ID + "],原因[" + ret + "]";
                Func.ShowMessage(MessageType.Error, msg);
                Log.Write(MessageType.Error, msg, Eap.Config.GetConfig().user.USER_ID);
                return;
            }

            Func.ShowMessage(MessageType.Information, "重置密码成功，用户ID[" + reset_pwd.USER_ID + "]");
            Log.Write(MessageType.Information, "重置密码成功，用户ID[" + reset_pwd.USER_ID + "]", Eap.Config.GetConfig().user.USER_ID);
        }
    }
}
