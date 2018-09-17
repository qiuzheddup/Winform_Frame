using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Eap;
using Eap.Enum;
using Eap.Entity;
using Eap.DbUnit;

namespace Eap.AppForm
{
    public partial class frmSystemParameterManage : Form
    {
        public frmSystemParameterManage()
        {
            InitializeComponent();
            Func.FormatForm(this);
            ButtonRight.FormatFormButtonEnabled(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtParaId.Text = string.Empty;
            txtParaName.Text = string.Empty;
        }

        private void frmSystemParameManage_Load(object sender, EventArgs e)
        {
            page.PageNo = 1;
            page.PageSize = 20;

            BindData();
        }

        private void BindData()
        {
            EapParameter entity = new EapParameter();

            entity.PARA_ID = txtParaId.Text.Trim();
            entity.PARA_NAME = txtParaName.Text.Trim();

            int icnt;
            List<EapParameter> list = Bll.GetBll().QuerySystemParameter(entity, page.PageNo, page.PageSize, out icnt);
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
            frmSystemParameterManageEdit frm = new frmSystemParameterManageEdit(EditMode.Add, null);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中系统参数数据");
                return;
            }

            EapParameter entity = new EapParameter();

            int iRowIndex = dgv.CurrentCell.RowIndex;
            entity.PARA_ID = dgv.Rows[iRowIndex].Cells["PARA_ID"].Value.ToString();
            entity.PARA_NAME = dgv.Rows[iRowIndex].Cells["PARA_NAME"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["PARA_NAME"].Value.ToString();
            entity.PARA_VALUE = dgv.Rows[iRowIndex].Cells["PARA_VALUE"].Value == null ? string.Empty : dgv.Rows[iRowIndex].Cells["PARA_VALUE"].Value.ToString();

            frmSystemParameterManageEdit frm = new frmSystemParameterManageEdit(EditMode.Edit, entity);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中删除数据！");
                return;
            }

            if (!Func.ShowQuestion("确认要删除该记录数据？"))
            {
                return;
            }

            string para_id = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["PARA_ID"].Value.ToString();

            string str = Bll.GetBll().DelSystemParameter(para_id);

            if (str != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, "删除系统参数数据失败！原因[" + str + "]");
            }
            else
            {
                //写日志
                Log.Write(MessageType.Information, "删除系统参数数据成功，参数ID[" + para_id + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "系统参数数据删除成功");

                page.PageNo = 1;
                BindData();
            }
        }

        private void frmSystemParameManage_Activated(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
