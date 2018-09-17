using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eap.Entity;
using Eap.Enum;
using Eap.Resource;

namespace Eap.AppLoader
{
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //应用程序标题
            this.Text = Config.GetConfig().APP_NAME;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            EapUser user = getEapUser();
            if (user == null)
            {
                return;
            }

            if (Bll.GetBll().Login(user))
            {
                frmMain fm = new frmMain();
                fm.UserName = Config.GetConfig().user.USER_NAME;
                fm.Show();

                this.Hide();
            }
            else
            {
                txtUid.Focus();
            }
        }

        private EapUser getEapUser()
        {
            EapUser user = new EapUser();
            user.USER_ID = txtUid.Text.Trim();
            user.PWD = txtPwd.Text;

            if (Func.StringLength(user.USER_ID) > 20)
            {
                Func.ShowMessage(MessageType.Error, "用户名最大长度为20个字符（10个汉字）");
                return null;
            }

            if (Func.StringLength(user.PWD) > 20)
            {
                Func.ShowMessage(MessageType.Error, "密码最大长度为20个字符（10个汉字）");
                return null;
            }

            return user;
        }

        private void txtUid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnOk_Click(null, null);
            }
        }

        private void txtUid_Enter(object sender, EventArgs e)
        {
            vkey.InputControl = txtUid;
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            vkey.InputControl = txtPwd;
        }

    }
}
