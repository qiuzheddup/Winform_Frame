using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Eap;
using Eap.Enum;
using Eap.Entity;
using Eap.DbUnit;
using System.Runtime.InteropServices;

namespace Eap.AppForm
{
    public partial class frmMenuManage : Form
    {
        public frmMenuManage()
        {
            InitializeComponent();
            Func.FormatForm(this);
            ButtonRight.FormatFormButtonEnabled(this);
        }

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMenuId.Text = string.Empty;
            txtMenuName.Text = string.Empty;
            txtParentMenuId.Text = string.Empty;
        }

        private void frmMenuManage_Load(object sender, EventArgs e)
        {
            page.PageNo = 1;
            page.PageSize = 20;

            BindData();
        }

        private void BindData()
        {
            EapMenu entity = new EapMenu();

            entity.MENU_ID = txtMenuId.Text.Trim().ToUpper();
            entity.MENU_NAME = txtMenuName.Text.Trim();
            entity.PARENT_MENU_ID = txtParentMenuId.Text.Trim().ToUpper();

            int icnt;
            List<EapMenu> list = Bll.GetBll().QueryMenu(entity, page.PageNo, page.PageSize, out icnt);
            page.RecordCount = icnt;

            dgv.DataSource = list;
        }

        private void page_PageChange()
        {
            BindData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            page.PageNo = 1;
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMenuManageEdit frm = new frmMenuManageEdit(EditMode.Add, null);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中菜单");
                return;
            }

            EapMenu entity = new EapMenu();

            int iRowIndex = dgv.CurrentCell.RowIndex;
            entity.MENU_ID = dgv.Rows[iRowIndex].Cells["MENU_ID"].Value.ToString();
            entity.MENU_NAME = dgv.Rows[iRowIndex].Cells["MENU_NAME"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["MENU_NAME"].Value.ToString();
            entity.PARENT_MENU_ID = dgv.Rows[iRowIndex].Cells["PARENT_MENU_ID"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["PARENT_MENU_ID"].Value.ToString();
            entity.FORM_NAME = dgv.Rows[iRowIndex].Cells["FORM_NAME"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["FORM_NAME"].Value.ToString();
            entity.ASSEMBLY_NAME = dgv.Rows[iRowIndex].Cells["ASSEMBLY_NAME"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["ASSEMBLY_NAME"].Value.ToString();

            frmMenuManageEdit frm = new frmMenuManageEdit(EditMode.Edit, entity);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中菜单");
                return;
            }

            if (!Func.ShowQuestion("确认要删除该记录数据？"))
            {
                return;
            }

            //判断当前用户是否为admin（系统管理员）
            if (Config.GetConfig().user.USER_ID != "admin")
            {
                Func.ShowMessage(MessageType.Warning, "当前用户不是系统管理员admin，不能删除菜单");
                return;
            }

            string menu_id = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["MENU_ID"].Value.ToString();

            string str = Bll.GetBll().DelMenuByMenuId(menu_id);

            if (str != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, "删除功能菜单数据失败！原因[" + str + "]");
            }
            else
            {
                //写日志
                Log.Write(MessageType.Information, "删除功能菜单数据成功，菜单编码[" + menu_id + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "功能菜单数据删除成功");

                page.PageNo = 1;
                BindData();
            }
        }

        private void frmMenuManage_Activated(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
