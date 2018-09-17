using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Eap.Control
{
    public partial class VirtualKeyboard : UserControl
    {
        private bool flag_upper = false;

        public VirtualKeyboard()
        {
            InitializeComponent();
            this.BackColor = Func.FormatBackColor();
        }

        private System.Windows.Forms.Control _InputControl = null;
        /// <summary>
        /// 输入控件
        /// </summary>
        [Description("输入控件")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public System.Windows.Forms.Control InputControl
        {
            set { _InputControl = value; }
        }

        /// <summary>
        /// 设计时固定控件大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VirtualKeyboard_Layout(object sender, LayoutEventArgs e)
        {
            VirtualKeyboard vk = (VirtualKeyboard)sender;

            vk.Width = 500;
            vk.Height = 250;
        }

        private void btnUpperLower_Click(object sender, System.EventArgs e)
        {
            if (_InputControl == null)
                return;

            _InputControl.Focus();

            if (flag_upper)
            {
                flag_upper = false;
                btnUpperLower.Text = "大写";
            }
            else
            {
                flag_upper = true;
                btnUpperLower.Text = "小写";
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            if (_InputControl == null)
                return;

            _InputControl.Focus();
            _InputControl.Text = string.Empty;
        }

        /// <summary>
        /// 发送虚拟按键
        /// </summary>
        /// <param name="key">虚拟按键值</param>
        private void VirtualKeyPress(string vkey)
        {
            if (_InputControl == null)
                return;

            _InputControl.Focus();
            SendKeys.Send(vkey);
        }

        private void btnBackspace_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("{BACKSPACE}");
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("{DELETE}");
        }

        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("{ENTER}");
        }

        private void btnLeft_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("{LEFT}");
        }

        private void btnRight_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("{RIGHT}");
        }

        private void btnKey0_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("0");
        }

        private void btnKey1_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("1");
        }

        private void btnKey2_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("2");
        }

        private void btnKey3_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("3");
        }

        private void btnKey4_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("4");
        }

        private void btnKey5_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("5");
        }

        private void btnKey6_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("6");
        }

        private void btnKey7_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("7");
        }

        private void btnKey8_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("8");
        }

        private void btnKey9_Click(object sender, System.EventArgs e)
        {
            VirtualKeyPress("9");
        }

        private void btnKeyA_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("A");
            else
                VirtualKeyPress("a");
        }

        private void btnKeyB_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("B");
            else
                VirtualKeyPress("b");
        }

        private void btnKeyC_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("C");
            else
                VirtualKeyPress("c");
        }

        private void btnKeyD_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("D");
            else
                VirtualKeyPress("d");
        }

        private void btnKeyE_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("E");
            else
                VirtualKeyPress("e");
        }

        private void btnKeyF_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("F");
            else
                VirtualKeyPress("f");
        }

        private void btnKeyG_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("G");
            else
                VirtualKeyPress("g");
        }

        private void btnKeyH_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("H");
            else
                VirtualKeyPress("h");
        }

        private void btnKeyI_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("I");
            else
                VirtualKeyPress("i");
        }

        private void btnKeyJ_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("J");
            else
                VirtualKeyPress("j");
        }

        private void btnKeyK_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("K");
            else
                VirtualKeyPress("k");
        }

        private void btnKeyL_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("L");
            else
                VirtualKeyPress("l");
        }

        private void btnKeyM_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("M");
            else
                VirtualKeyPress("m");
        }

        private void btnKeyN_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("N");
            else
                VirtualKeyPress("n");
        }

        private void btnKeyO_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("O");
            else
                VirtualKeyPress("o");
        }

        private void btnKeyP_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("P");
            else
                VirtualKeyPress("p");
        }

        private void btnKeyQ_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("Q");
            else
                VirtualKeyPress("q");
        }

        private void btnKeyR_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("R");
            else
                VirtualKeyPress("r");
        }

        private void btnKeyS_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("S");
            else
                VirtualKeyPress("s");
        }

        private void btnKeyT_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("T");
            else
                VirtualKeyPress("t");
        }

        private void btnKeyU_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("U");
            else
                VirtualKeyPress("u");
        }

        private void btnKeyV_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("V");
            else
                VirtualKeyPress("v");
        }

        private void btnKeyW_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("W");
            else
                VirtualKeyPress("w");
        }

        private void btnKeyX_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("X");
            else
                VirtualKeyPress("x");
        }

        private void btnKeyY_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("Y");
            else
                VirtualKeyPress("y");
        }

        private void btnKeyZ_Click(object sender, System.EventArgs e)
        {
            if (flag_upper)
                VirtualKeyPress("Z");
            else
                VirtualKeyPress("z");
        }
    }
}
