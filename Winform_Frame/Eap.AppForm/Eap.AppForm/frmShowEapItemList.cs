using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Data.OracleClient;

using Eap.Entity;
using Eap.DbUnit;

namespace Eap.AppForm
{
    public partial class frmShowEapItemList : Form
    {
        /// <summary>
        /// 获取EapItem数据的委托
        /// </summary>
        /// <param name="item"></param>
        public delegate void GetItemDelegate(EapItem item);
        private GetItemDelegate sendEvent;
        private EapCommonQuery EapCommonQuery;
        private bool isNameShow = true;
        private string strWhere;

        /// <summary>
        /// 信息展示窗体构造器
        /// </summary>
        /// <param name="EapCommonQuery">查询实体</param>
        /// <param name="getItemCallBack">获取EapItem的方法</param>
        /// <param name="filter">过滤器：不带where的条件语句</param>
        public frmShowEapItemList(EapCommonQuery EapCommonQuery, GetItemDelegate getItemCallBack, string filter)
        {
            InitializeComponent();
            this.EapCommonQuery = EapCommonQuery;
            this.sendEvent += getItemCallBack;
            this.strWhere = filter;

            Func.FormatForm(this);
        }

        private void frmShowEapItemList_Load(object sender, EventArgs e)
        {
            if (EapCommonQuery != null)
            {
                this.Text = EapCommonQuery.FROM_NAME;
                this.dgv.Columns[1].HeaderText = EapCommonQuery.FIELD_NAME1;
                this.lblNum.Text = EapCommonQuery.FIELD_NAME1 + ":";
                if (!String.IsNullOrEmpty(EapCommonQuery.FIELD2))
                {
                    this.dgv.Columns[2].HeaderText = EapCommonQuery.FIELD_NAME2;
                    this.lblName.Text = EapCommonQuery.FIELD_NAME2 + ":";
                }
                else
                {
                    this.dgv.Columns[2].Visible = false;
                    this.dgv.Columns[1].Width = 895;
                    this.lblName.Visible = false;
                    this.txtName.Visible = false;
                    isNameShow = false;
                }
                page.PageNo = 1;
                page.PageSize = 18;
            }
            Bind(String.Empty, String.Empty);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind(string field1, string field2)
        {
            field1 = field1.ToUpper();
            field2 = field2.ToUpper();
            int record_count = 0;
            StringBuilder sb = new StringBuilder();
            int para_count = 0;
            sb.Append("select  ");
            sb.Append(EapCommonQuery.FIELD1);
            sb.Append(" as FIELD1 ");
            if (isNameShow)
            {
                sb.Append(" , ");
                sb.Append(EapCommonQuery.FIELD2);
                sb.Append("  as FIELD2  ");
            }
            sb.Append(" from  ");
            sb.Append(EapCommonQuery.TABLE_NAME);
            if (!String.IsNullOrEmpty(field1) || !String.IsNullOrEmpty(field2))
            {
                sb.Append(" where ");
                if (!String.IsNullOrEmpty(field1))
                {
                    sb.Append(EapCommonQuery.FIELD1);
                    sb.Append("  like '%'||:field1||'%'");
                    para_count++;
                }
                if (!String.IsNullOrEmpty(field2))
                {
                    if (!String.IsNullOrEmpty(field1))
                    {
                        sb.Append(" and ");
                    }
                    sb.Append(EapCommonQuery.FIELD2);
                    sb.Append("  like '%'||:field2||'%'");
                    para_count++;
                }
            }
            OracleParameter[] paras = new OracleParameter[para_count];
            if (!String.IsNullOrEmpty(field1))
            {
                paras[0] = new OracleParameter(":field1", OracleType.VarChar);
                paras[0].Value = field1;
            }
            if (!String.IsNullOrEmpty(field2))
            {
                int index = para_count - 1;
                paras[index] = new OracleParameter(":field2", OracleType.VarChar);
                paras[index].Value = field2;
            }
            if (!string.IsNullOrEmpty(strWhere))
            {
                if (String.IsNullOrEmpty(field1) && String.IsNullOrEmpty(field2))
                {
                    sb.Append(" where 1=1 ");
                }
                sb.Append(" and ");
                sb.Append(strWhere);
            }
            List<EapCommonQuery> list = Eap.DbUnit.Oracle.GetOracle().QueryToPage<EapCommonQuery>(sb, paras, page.PageNo, page.PageSize, out record_count);
            page.RecordCount = record_count;
            this.dgv.DataSource = list;
            if (record_count < 1)
            {
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }

        private void page_PageChange()
        {
            Bind(this.txtNum.Text, this.txtName.Text);
        }

        /// <summary>
        /// 单元格内鼠标双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getItemAndClose(e.RowIndex);
        }

        /// <summary>
        /// 确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (dgv.Rows[dgv.CurrentRow.Index].Selected) 
            if (dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex].Selected)
            {
                //getItemAndClose(dgv.CurrentRow.Index);
                getItemAndClose(dgv.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("请先选择数据！");
            }
        }

        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            EapItem item = new EapItem(string.Empty, string.Empty);
            if (sendEvent != null)
            {
                sendEvent(item);
            }
            this.Close();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Bind(this.txtNum.Text, this.txtName.Text);
        }

        /// <summary>
        /// 获取Item数据并关闭窗体
        /// </summary>
        /// <param name="rowindex">行号</param>
        private void getItemAndClose(int rowindex)
        {
            if (rowindex > -1)
            {
                EapItem item = null;
                if (isNameShow)
                {
                    item = new EapItem(dgv.Rows[rowindex].Cells[1].Value.ToString(), dgv.Rows[rowindex].Cells[2].Value.ToString());
                }
                else
                {
                    item = new EapItem(dgv.Rows[rowindex].Cells[1].Value.ToString(), "");
                }

                if (sendEvent != null)
                {
                    sendEvent(item);
                }
                this.Close();
            }
        }
    }
}
