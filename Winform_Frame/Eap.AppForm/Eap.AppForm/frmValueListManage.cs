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
    public partial class frmValueListManage : Form
    {
        public frmValueListManage()
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
            txtVListId.Text = string.Empty;
            txtVListName.Text = string.Empty;
        }

        private void frmValueListManageManage_Load(object sender, EventArgs e)
        {
            page.PageNo = 1;
            page.PageSize = 19;

            BindData();
        }

        private void BindData()
        {
            EapValueList entity = new EapValueList();
            entity.VLIST_ID = txtVListId.Text.Trim();
            entity.VLIST_NAME = txtVListName.Text.Trim();

            int icnt;
            List<EapValueList> list = Bll.GetBll().QueryValueList(entity, page.PageNo, page.PageSize, out icnt);
            page.RecordCount = icnt;

            dgvVList.DataSource = list;
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
            frmValueListManageEdit frm = new frmValueListManageEdit(EditMode.Add, null);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVList.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中值列表数据");
                return;
            }

            EapValueList entity = new EapValueList();

            int iRowIndex = dgvVList.CurrentCell.RowIndex;
            entity.VLIST_ID = dgvVList.Rows[iRowIndex].Cells["VLIST_ID"].Value.ToString();
            entity.VLIST_NAME = dgvVList.Rows[iRowIndex].Cells["VLIST_NAME"].Value.ToString();

            frmValueListManageEdit frm = new frmValueListManageEdit(EditMode.Edit, entity);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvVList.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中删除数据！");
                return;
            }

            if (!Func.ShowQuestion("确认要删除该记录数据？"))
            {
                return;
            }

            EapValueList del_entity = new EapValueList();
            int iRowIdex =dgvVList.CurrentCell.RowIndex;
            del_entity.VLIST_ID = dgvVList.Rows[iRowIdex].Cells["VLIST_ID"].Value.ToString();
            del_entity.VLIST_NAME = dgvVList.Rows[iRowIdex].Cells["VLIST_NAME"].Value.ToString();

            string str = Bll.GetBll().DelValueList(del_entity.VLIST_ID);

            if (str != string.Empty)
            {
                if (str.Split(':')[0] == "ORA-02292")
                {
                    Func.ShowMessage(MessageType.Error, "删除值列表数据失败！原因:值列表ID[" + del_entity.VLIST_ID + "]存在明细列表数据，无法删除");
                    return;
                }

                Func.ShowMessage(MessageType.Error, "删除值列表数据失败！原因[" + str + "]");
            }
            else
            {
                //写日志
                Log.Write(MessageType.Information, "删除值列表数据成功，值列表ID[" + del_entity.VLIST_ID + "]，值列表名称[" + del_entity.VLIST_NAME + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "值列表数据删除成功");

                page.PageNo = 1;
                BindData();
            }
        }

        private void frmValueListManageManage_Activated(object sender, EventArgs e)
        {
            BindData();
            dgvVListDetail.DataSource = null;
        }

        private void btnAddVListDetail_Click(object sender, EventArgs e)
        {
            if (dgvVList.SelectedCells.Count == 0)
            {
                return;
            }

            //值列表选中行--新增值列表明细时，传值列表ID
            string vlist_id= dgvVList.Rows[dgvVList.CurrentCell.RowIndex].Cells["VLIST_ID"].Value.ToString();

            frmValueListDetailManageEdit frm = new frmValueListDetailManageEdit(vlist_id);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        
        private void btnDelVListDetail_Click(object sender, EventArgs e)
        {
            if (dgvVListDetail.SelectedCells.Count == 0)
            {
                Func.ShowMessage(MessageType.Warning, "没有选中删除数据！");
                return;
            }

            if (!Func.ShowQuestion("确认要删除该记录数据？"))
            {
                return;
            }

            EapValueListDetail del_entity = new EapValueListDetail();

            del_entity.VLIST_ID = dgvVList.Rows[dgvVList.CurrentCell.RowIndex].Cells["VLIST_ID"].Value.ToString();
            int iRowIndex = dgvVListDetail.CurrentCell.RowIndex;
            del_entity.VLIST_DETAIL_ID = decimal.Parse(dgvVListDetail.Rows[iRowIndex].Cells["VLIST_DETAIL_ID"].Value.ToString());
            del_entity.VLIST_DETAIL_VALUE = decimal.Parse(dgvVListDetail.Rows[iRowIndex].Cells["VLIST_DETAIL_VALUE"].Value.ToString());
            del_entity.VLIST_DETAIL_NAME = dgvVListDetail.Rows[iRowIndex].Cells["VLIST_DETAIL_NAME"].Value.ToString();

            string str = Bll.GetBll().DelValueListDetail(del_entity);

            if (str != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, "删除值列表明细数据失败！原因[" + str + "]");
            }
            else
            {
                //写日志
                string msg = "删除值列表明细数据成功，值列表ID[" + del_entity.VLIST_ID + "]，值列表明细ID[" + del_entity.VLIST_DETAIL_ID + "],值列表明细值["+del_entity.VLIST_DETAIL_VALUE+"],值列表明细名称["+del_entity.VLIST_DETAIL_NAME+"]";
                Log.Write(MessageType.Information, msg, Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "值列表明细数据删除成功");

                BindValueListDetail(del_entity.VLIST_ID);
            }
        }

        private void BindValueListDetail(string vlist_id)
        {
            List<EapValueListDetail> list = Oracle.GetOracle().GetValueListDetail(vlist_id);

            dgvVListDetail.DataSource = list;
        }

        private void dgvVList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVList.SelectedCells.Count == 0)
            {
                return;
            }

            string vlist_id = dgvVList.Rows[dgvVList.CurrentCell.RowIndex].Cells["VLIST_ID"].Value.ToString();
            BindValueListDetail(vlist_id);
        }

        private void dgvVList_DataSourceChanged(object sender, EventArgs e)
        {
            dgvVListDetail.DataSource = null;
        }
    }
}
