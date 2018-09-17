using System.Windows.Forms;
using System.ComponentModel;

using Eap;
using Eap.Enum;

namespace Eap.Control
{
    /// <summary>
    /// 分页控件
    /// </summary>
    public partial class PageSelect : UserControl
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PageSelect()
        {
            InitializeComponent();
            this.BackColor = Func.FormatBackColor();
        }

        /// <summary>
        /// 设计时固定控件大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageSelect_Layout(object sender, LayoutEventArgs e)
        {
            PageSelect ps = (PageSelect)sender;

            ps.Width = 655;
            ps.Height = 50;
        }

        private int _PageSize = 10;
        /// <summary>
        /// 页大小
        /// </summary>
        [Description("页大小")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int PageSize
        {
            get { return _PageSize; }
            set { _PageSize = value; }
        }

        private int _PageCount = 1;
        /// <summary>
        /// 总页数
        /// </summary>
        [Description("总页数")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int PageCount
        {
            get { return _PageCount; }
        }

        private int _RecordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        [Description("总记录数")]
        [DefaultValue(0)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int RecordCount
        {
            get { return _RecordCount; }
            set
            {
                _RecordCount = value;

                ResetPageCount();
                ResetButton();
            }
        }

        private int _PageNo = 1;
        /// <summary>
        /// 当前页
        /// </summary>
        [Description("当前页")]
        [DefaultValue(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int PageNo
        {
            get { return _PageNo; }
            set 
            { 
                _PageNo = value;
                txtPageNo.Text = _PageNo.ToString();
            }
        }

        /// <summary>
        /// 重置总页数
        /// </summary>
        private void ResetPageCount()
        {
            _PageCount = _RecordCount / _PageSize;

            if (_RecordCount % _PageSize != 0)
            {
                _PageCount++;
            }
        }

        /// <summary>
        /// 重新设置按钮状态
        /// </summary>
        private void ResetButton()
        {
            if ((_PageNo > _PageCount) || (_PageNo <= 0))
            {
                _PageNo = 1;
                txtPageNo.Text = _PageNo.ToString();
            }

            if (_PageNo == 1)
            {
                btnPageHome.Enabled = false;
                btnPageUp.Enabled = false;

                if (_PageCount > 1)
                {
                    btnPageDown.Enabled = true;
                    btnPageEnd.Enabled = true;
                }
                else
                {
                    btnPageDown.Enabled = false;
                    btnPageEnd.Enabled = false;
                }
            }
            else if (_PageNo == _PageCount)
            {
                btnPageHome.Enabled = true;
                btnPageUp.Enabled = true;

                btnPageDown.Enabled = false;
                btnPageEnd.Enabled = false;
            }
            else
            {
                btnPageHome.Enabled = true;
                btnPageUp.Enabled = true;

                btnPageDown.Enabled = true;
                btnPageEnd.Enabled = true;
            }

            string str;
            if (_PageCount == 0)
                str = (_PageCount + 1).ToString().PadLeft(6, '0');
            else
                str = _PageCount.ToString().PadLeft(6, '0');

            lblPageCount.Text = "第" + _PageNo.ToString().PadLeft(6, '0') + "页 共" + str + "页";
        }

        /// <summary>
        /// 定位到首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageHome_Click(object sender, System.EventArgs e)
        {
            _PageNo = 1;
            txtPageNo.Text = _PageNo.ToString();

            PageSelectDo();
        }

        /// <summary>
        /// 定位到上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageUp_Click(object sender, System.EventArgs e)
        {
            _PageNo--;
            txtPageNo.Text = _PageNo.ToString();

            PageSelectDo();
        }

        /// <summary>
        /// 定位到下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageDown_Click(object sender, System.EventArgs e)
        {
            _PageNo++;
            txtPageNo.Text = _PageNo.ToString();

            PageSelectDo();
        }

        /// <summary>
        /// 定位到尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPageEnd_Click(object sender, System.EventArgs e)
        {
            _PageNo = _PageCount;
            txtPageNo.Text = _PageNo.ToString();

            PageSelectDo();
        }

        /// <summary>
        /// 跳转到指定页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoPage_Click(object sender, System.EventArgs e)
        {
            if (txtPageNo.Text == string.Empty)
            {
                Func.ShowMessage(MessageType.Information, "请输入页数");
                return;
            }

            _PageNo = int.Parse(txtPageNo.Text);
            PageSelectDo();
        }

        /// <summary>
        /// 页面选择事件处理
        /// </summary>
        private void PageSelectDo()
        {
            if (PageChange != null)
            {
                PageChange();
            }

            ResetButton();
        }

        /// <summary>
        /// 翻页事件
        /// </summary>
        public delegate void PageSelected();

        [Description("翻页事件")]
        public event PageSelected PageChange;

        /// <summary>
        /// 检查当前页的输入是否有效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPageNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = '\0';
            }
        }

        /// <summary>
        /// 检查输入的字符是否数字
        /// </summary>
        /// <param name="c">输入的字符</param>
        /// <returns>true：数字；false：非数字</returns>
        private bool IsNumber(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 检查当前页的输入是否有效
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPageNo_TextChanged(object sender, System.EventArgs e)
        {
            if (txtPageNo.Text != string.Empty)
            {
                int page = int.Parse(txtPageNo.Text);
                if ((page != 1) && (page > _PageCount || page < 1))
                {
                    txtPageNo.Clear();
                    Func.ShowMessage(MessageType.Information, "超出有效页面范围");
                }
            }
        }
    }
}
