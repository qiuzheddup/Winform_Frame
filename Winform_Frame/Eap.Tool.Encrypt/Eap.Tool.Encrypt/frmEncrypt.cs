using System;
using System.Drawing;
using System.Windows.Forms;

using Eap;

namespace Eap.Tool.Encrypt
{
    public partial class frmEncrypt : Form
    {
        public frmEncrypt()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncryptString.Text = Func.EncryptString(txtDecryptString.Text, txtKey.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptString.Text = Func.DecryptString(txtEncryptString.Text, txtKey.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDecryptString.Text = string.Empty;
            txtEncryptString.Text = string.Empty;
            txtKey.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEncrypt_Load(object sender, EventArgs e)
        {
            txtKey.Text = Config.GetConfig().DB_KEY;
        }
    }
}
