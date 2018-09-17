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
    public partial class frmLogQuery : Form
    {
        public frmLogQuery()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOperateNote.Text = string.Empty;
            txtOperateUser.Text = string.Empty;
            dtpBeginTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;

            cboLogType.SelectedIndex = -1;
        }

        /// <summary>
        /// 绑定日志类型下拉框
        /// </summary>
        private void BindLogType()
        {
            cboLogType.Items.Clear();

            List<EapValueListDetail> list = Oracle.GetOracle().GetValueListDetail("log_type");
            if (list == null || list.Count == 0)
                return;

            foreach (EapValueListDetail sub in list)
            {
                cboLogType.Items.Add(new EapItem(sub.VLIST_DETAIL_VALUE.ToString(), sub.VLIST_DETAIL_NAME));
            }

            cboLogType.SelectedIndex = -1;
        }

        private void frmLogQuery_Load(object sender, EventArgs e)
        {
            BindLogType();

            dtpBeginTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;

            page.PageNo = 1;
            page.PageSize = 20;

            BindData();
        }

        private void BindData()
        {
            EapLog entity = new EapLog();

            if (cboLogType.SelectedIndex != -1)
            {
                entity.LOG_TYPE = Convert.ToInt32(((EapItem)(cboLogType.SelectedItem)).ID);
            }
            else
            {
                entity.LOG_TYPE = -1;
            }
            entity.OPERATE_NOTE = txtOperateNote.Text.Trim();
            entity.OPERATE_USER = txtOperateUser.Text.Trim();

            entity.BEGIN_TIME = dtpBeginTime.Value;
            entity.END_TIME = dtpEndTime.Value;

            int icnt;
            List<EapLog> list = Bll.GetBll().QueryEapLog(entity, page.PageNo, page.PageSize, out icnt);
            page.RecordCount = icnt;

            dgv.DataSource = list;
        }

        private void page_PageChange()
        {
            BindData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (dtpBeginTime.Value > dtpEndTime.Value)
            {
                Func.ShowMessage(MessageType.Warning, "开始时间不能大于结束时间");
                return;
            }

            page.PageNo = 1;
            BindData();
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor=Color.White;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["LOG_TYPE"].Value.ToString() == "1")
                    row.DefaultCellStyle.BackColor = Color.Yellow;

                if (row.Cells["LOG_TYPE"].Value.ToString() == "2")
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
