using System;
using System.Drawing;
using System.Windows.Forms;

using Eap.Enum;
using Eap.Entity;

namespace Eap.AppForm
{
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != txtNewAgain.Text)
            {
                Func.ShowMessage(MessageType.Error, "两次密码不一致！");
                return;
            }

            EapUser user =new EapUser();
            user.USER_ID=Config.GetConfig().user.USER_ID;
            user.PWD = Func.EncryptString(txtOld.Text.Trim(), Config.GetConfig().DB_KEY);

            if (!Bll.GetBll().IsUserExist(user))
            {
                Func.ShowMessage(MessageType.Error, "当前密码错误！");
                this.txtOld.Focus();
                return;
            }

            user.PWD = Func.EncryptString(txtNew.Text, Config.GetConfig().DB_KEY);

            string ret = Bll.GetBll().UpdatePwd(user);
            if (ret == string.Empty)
            {
                Func.ShowMessage(MessageType.Information, "密码修改成功！");
                this.Close();
            }
            else
            {
                Func.ShowMessage(MessageType.Error, ret);
            }
        }
    }
}
