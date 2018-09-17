using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Eap.Entity;
using Eap;
using Eap.Enum;



//using Mes.Entity;

namespace Eap.AppForm
{
    public partial class frmDepartmentManage : Form
    {
        public frmDepartmentManage()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void frmDepartmentManage_Load(object sender, EventArgs e)
        {
            BindDepartmant();


            page.PageNo = 1;
            page.PageSize = 20;

            cmbDEPARTMENT_TYPE.Focus();
        }

        /// <summary>
        /// 绑定部门类型下拉框
        /// </summary>
        private void BindDepartmant()
        {
            cmbDEPARTMENT_TYPE.Items.Clear();
            cmbDEPARTMENT_TYPE.Items.Add(new EapItem("-1", "全部"));

            foreach (EapDepartment sub in Bll.GetBll().GetDepartmant_TYPE())
            {
                cmbDEPARTMENT_TYPE.Items.Add(new EapItem(sub.DEPARTMENT_TYPE, sub.DEPARTMENT_TYPE));
            }

            cmbDEPARTMENT_TYPE.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindData() 
        {
            EapDepartment entity = new EapDepartment();
            entity.DEPARTMENT_CODE = txtDEPARTMENT_CODE.Text;
            entity.DEPARTMENT_NAME = txtDEPARTMENT_NAME.Text;
            entity.DEPARTMENT_TYPE = cmbDEPARTMENT_TYPE.Text;
            entity.STATUS = chbSTATUS.Checked?0:1;
            int count=0;
            List<EapDepartment> list = Bll.GetBll().GetDEPARTMENTList(entity, page.PageNo, page.PageSize, out count);

            page.RecordCount = count;
            dgv.DataSource = list;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDEPARTMENT_CODE.Text = "";
            txtDEPARTMENT_NAME.Text = "";
            cmbDEPARTMENT_TYPE.SelectedIndex = 0;
            chbSTATUS.Checked = false;
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中一条数据");
                return;
            }

            EapDepartment entity = new EapDepartment();
            entity.DEPARTMENT_ID = Int32.Parse(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_ID"].Value.ToString());
            entity.DEPARTMENT_CODE = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_CODE"].Value.ToString();
            entity.DEPARTMENT_NAME = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_NAME"].Value.ToString();
            entity.DEPARTMENT_TYPE = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_TYPE"].Value.ToString();
            entity.ASSEMBLY_LINE = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["ASSEMBLY_LINE"].Value.ToString();
            entity.STATUS = decimal.Parse(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["STATUS"].Value.ToString());


            frmDepartmentManageEdit frm = new frmDepartmentManageEdit(EditMode.Edit,entity);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中一条数据");
                return;
            }

            if (Func.ShowQuestion("确认要进行删除操作吗？") == true)
            {
                string DEPARTMENT_ID = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_ID"].Value.ToString();

                string ret = Bll.GetBll().DeleteDEPARTMENT(DEPARTMENT_ID);
                if (ret != string.Empty)
                {
                    Func.ShowMessage(MessageType.Warning, "删除失败," + ret);
                }
                //成功写入日志
                Log.Write(MessageType.Information, "部门删除成功,删除ID[" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DEPARTMENT_ID"].Value.ToString() + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "删除成功");
                BindData();
            }

        }

        /// <summary>
        /// 显示已失效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbSTATUS_CheckedChanged(object sender, EventArgs e)
        {

            BindData();
        }

        /// <summary>
        /// 翻页事件
        /// </summary>
        private void page_PageChange()
        {
            BindData();
        }

        private void frmDepartmentManage_Activated(object sender, EventArgs e)
        {
            BindDepartmant();
            BindData();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmDepartmentManageEdit frm = new frmDepartmentManageEdit(EditMode.Add,null);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
