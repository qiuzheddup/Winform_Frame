using System.Windows.Forms;
using System.Drawing;

namespace Eap.Control
{
    public  class DataGridViewEx : DataGridView
    {
        public DataGridViewEx()
        {
            //单元格不接受tab键
            this.StandardTab = true;

            //整行选择
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //不显示行标题
            this.RowHeadersVisible = false;

            //禁止多行选择
            this.MultiSelect = false;

            //禁止编辑
            this.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToAddRows = false;

            //禁止修改行高
            this.AllowUserToResizeRows = false;

            //列标题高度
            this.ColumnHeadersHeight = 28;

            //禁止自动添加列
            this.AutoGenerateColumns = false;

            //奇数行背景色
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 236, 231);

            //行被选中的背景色
            this.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 196, 70);
            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 196, 70);

            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //网格线颜色
            this.GridColor = Color.FromArgb(100, 83, 89);

            //表头样式
            this.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(162, 147, 88);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(185, 166, 86);
            headerStyle.SelectionForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);

            //取消默认选中行，程序中处理时，如果是mdi子窗体，form_load处理会失效
            this.ClearSelection();
        }  
    }
}
