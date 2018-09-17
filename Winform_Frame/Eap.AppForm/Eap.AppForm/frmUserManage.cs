using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Eap.Entity;
using Eap.Enum;

namespace Eap.AppForm
{
    public partial class frmUserManage : Form
    {
        public frmUserManage()
        {
            InitializeComponent();
            Func.FormatForm(this);
            ButtonRight.FormatFormButtonEnabled(this);
        }

        private void frmUserManage_Load(object sender, EventArgs e)
        {
            page.PageNo = 1;
            page.PageSize = 20;

            BindData();
        }

        private void BindData()
        {
            int recordcount = 0;

            EapUser user = new EapUser();
            user.USER_NAME = txtUserName.Text.Trim();
            user.USER_ID = txtUserID.Text.Trim();

            List<EapUser> list = Bll.GetBll().GetUserList(user, page.PageNo, page.PageSize, out recordcount);
            
            dgv.DataSource = list;
            page.RecordCount = recordcount;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            page.PageNo = 1;
            BindData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserManageEdit frm = new frmUserManageEdit(EditMode.Add, null);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count <= 0)
            {
                Func.ShowMessage(MessageType.Error, "请选择一行");
                return;
            }

            int iRowIndex = dgv.CurrentCell.RowIndex;

            EapUser user = new EapUser();
            user.USER_ID = dgv.Rows[iRowIndex].Cells["USER_ID"].Value.ToString();
            user.USER_NAME = dgv.Rows[iRowIndex].Cells["USER_NAME"].Value.ToString();
            user.IS_STOP = Convert.ToDecimal(dgv.Rows[iRowIndex].Cells["IS_STOP"].Value.ToString());

            frmUserManageEdit frm = new frmUserManageEdit(EditMode.Edit, user);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmUserManage_Activated(object sender, EventArgs e)
        {
            page.PageNo = 1;
            BindData();
        }

        private void page_PageChange()
        {
            BindData();
        }

        private void btnUserRight_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count <= 0)
            {
                Func.ShowMessage(MessageType.Error, "请选择一行");
                return;
            }

            int iRowIndex = dgv.CurrentCell.RowIndex;

            EapUser user = new EapUser();
            user.USER_ID = dgv.Rows[iRowIndex].Cells["USER_ID"].Value.ToString();
            user.USER_NAME = dgv.Rows[iRowIndex].Cells["USER_NAME"].Value.ToString();
            user.IS_STOP = Convert.ToDecimal(dgv.Rows[iRowIndex].Cells["IS_STOP"].Value.ToString());

            frmUserAuthorityEdit frm = new frmUserAuthorityEdit(EditMode.Edit, user);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }
    }
}
