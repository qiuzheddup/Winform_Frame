using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Eap.Resource;

namespace Eap.AppLoader
{
    public partial class frmMain : BaseForm
    {
        public frmMain()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region Win32 API

        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;

        private const int WS_BORDER = 0x00800000;
        private const int WS_EX_CLIENTEDGE = 0x00000200;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control contrl in this.Controls)
            {
                if (contrl.GetType().ToString() == "System.Windows.Forms.MdiClient")
                {
                    var mdiClient = contrl as MdiClient;

                    // 找到了mdi客户区
                    // 取得客户区的边框
                    int style = GetWindowLong(mdiClient.Handle, GWL_STYLE);
                    int exStyle = GetWindowLong(mdiClient.Handle, GWL_EXSTYLE);
                    style &= ~WS_BORDER;
                    exStyle &= ~WS_EX_CLIENTEDGE;

                    // 调用win32设定样式  
                    SetWindowLong(mdiClient.Handle, GWL_STYLE, style);
                    SetWindowLong(mdiClient.Handle, GWL_EXSTYLE, exStyle);

                    //// 更新客户区
                    SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0,
                         SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                         SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                    UpdateStyles();
                    break;
                }
            }

            //应用程序标题
            this.Text = Config.GetConfig().APP_NAME;

            //隐藏子窗体菜单条
            MenuStrip ms = new MenuStrip();
            ms.Visible = false;
            this.MainMenuStrip = ms;

            //显示主菜单窗体
            Form frm = new frmMainMenu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
