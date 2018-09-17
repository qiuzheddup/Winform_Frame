using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Eap.Resource;

namespace Eap.AppLoader
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            InitWindowPaintParams();
        }

        #region 绘制窗体

        #region property

        #region 窗体消息代码

        protected const int WM_ERASEBKGND = 0x0014;
        protected const int WM_NCPAINT = 0x85;
        protected const int WM_NCACTIVATE = 0x86;
        protected const int WM_NCLBUTTONDOWN = 0xA1;
        protected const int WM_NCLBUTTONDBLCLK = 0xA3;
        protected const int WM_PAINT = 0x000F;
        protected const int WM_NCHITTEST = 0x84;
        protected const int HTCLIENT = 0x1;
        protected const int HTCAPTION = 0x2;
        protected const int WM_NCCALCSIZE = 0x0083;
        protected const int WM_MDIDESTROY = 0x0221;
        protected const int WM_ACTIVATE = 0x0006;
        protected const int WM_SHOWWINDOW = 0x0018;
        protected const int WM_NOTIFY = 0x004E;
        protected const int WM_MOVE = 0x0003;

        protected const uint SWP_NOSIZE = 0x0001;
        protected const uint SWP_NOMOVE = 0x0002;
        protected const uint SWP_NOZORDER = 0x0004;
        protected const uint SWP_NOACTIVATE = 0x0010;
        protected const uint SWP_FRAMECHANGED = 0x0020;
        protected const uint SWP_NOOWNERZORDER = 0x0200;

        // Windows Style
        protected const int WS_CLIPSIBLINGS = 0x4000000;  
        protected const int WS_CLIPCHILDREN = 0x2000000;

        #endregion

        protected int TitleMargin { get; set; }
        protected int BtnHeight { get; set; }
        protected int CaptionHeight { get; set; }
        protected Brush TitleBrush { get; set; }
        protected Brush BtnBackBrush { get; set; }
        protected Brush BtnForeBrush { get; set; }
        protected Image CloseButtonImage { get; set; }
        protected Image MinimumButtonImage { get; set; }
        protected Image UserNameImage { get; set; }
        protected Font TitleFont { get; set; }
        protected Font BtnFont { get; set; }
        protected Size BorderSize { get; set; }
        public string UserName { get; set; }

        #region private structs

        protected struct _RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        protected struct NonClientSizeInfo
        {
            public Size BorderSize;
            public int CaptionHeight;
            public Rectangle CaptionRect;
            public Rectangle Rect;
            public Rectangle ClientRect;
            public int Width;
            public int Height;
            public Rectangle CloseBtnRect;
            public Rectangle MinimumBtnRect;
            public Rectangle UserNameImageRect;
        };

        protected struct NCCALCSIZE_PARAMS
        {
            public _RECT rcNewWindow;
            public _RECT rcOldWindow;
            public _RECT rcClient;
            IntPtr lppos;
        }

        #endregion

        #endregion

        #region windows api

        [DllImport("User32.dll ")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("User32.dll ")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("User32.dll ")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref _RECT rect);

        [DllImport("User32.dll ")]
        private extern static int GetClientRect(IntPtr hWnd, ref Rectangle rc);

        [DllImport("User32.dll ")]
        private static extern bool ClientToScreen(IntPtr hWnd, ref Point pt);

        [DllImport("user32", EntryPoint = "OffsetRect")]
        public static extern int OffsetRect(ref Rectangle lpRect, int x, int y);

        [DllImport("User32.dll ")]
        public static extern int ExcludeClipRect(IntPtr hdc, int left, int top, int right, int bottom);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int FillRect(IntPtr hDC, ref Rectangle rect, IntPtr hBrush);

        [DllImport("gdi32")]
        public static extern IntPtr CreateSolidBrush(uint crColor);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);

        [DllImport("Kernel32.dll ")]
        public static extern int GetLastError();

        #endregion

        /// <summary>
        /// 初始化窗体绘制参数
        /// </summary>
        private void InitWindowPaintParams()
        {
            TitleMargin = 20;
            BtnHeight = 25;
            CaptionHeight = SystemInformation.CaptionHeight;

            TitleBrush = new SolidBrush(Color.FromArgb(131, 115, 53));
            BtnBackBrush = new SolidBrush(Color.FromArgb(131, 115, 53));
            BtnForeBrush = new SolidBrush(Color.FromArgb(255, 255, 255));

            CloseButtonImage = EapResource.CloseButton;
            MinimumButtonImage = EapResource.MinimizeButton;
            UserNameImage = EapResource.LoginHead;

            TitleFont = new Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            BtnFont = new Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular);

            BorderSize = SystemInformation.FixedFrameBorderSize;
        }

        /// <summary>
        /// 处理Windows消息
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            NonClientSizeInfo sizeInfo;
            Point mousePoint;
            switch (m.Msg)
            {
                case WM_NCACTIVATE:
                    PaintNC(ref m);
                    m.Result = new IntPtr(1);
                    break;

                case WM_ERASEBKGND:
                    m.Result = IntPtr.Zero;
                    break;

                case WM_NCPAINT:
                    PaintNC(ref m);
                    break;

                case WM_NCLBUTTONDOWN:
                    sizeInfo = GetNonClientInfo(m.HWnd);
                    mousePoint = new Point((int)m.LParam);
                    mousePoint.Offset(-this.Left, -this.Top);
                    if (sizeInfo.CloseBtnRect.Contains(mousePoint))
                    {
                        this.Close();
                    }
                    else if (sizeInfo.MinimumBtnRect.Contains(mousePoint))
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                    base.WndProc(ref m);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        /// <summary>
        /// 非客户区绘制
        /// </summary>
        /// <param name="m"></param>
        private void PaintNC(ref Message m)
        {
            IntPtr hdc = GetWindowDC(m.HWnd);
            var g = Graphics.FromHdc(hdc);
            var sizeInfo = GetNonClientInfo(m.HWnd);

            g.SetClip(sizeInfo.Rect);
            var excludeClip = new Rectangle(sizeInfo.ClientRect.X + 5, sizeInfo.ClientRect.Y + 5,
                sizeInfo.ClientRect.Width - 10, sizeInfo.ClientRect.Height - 10);
            g.ExcludeClip(excludeClip);
            g.DrawImage(EapResource.Backgroud, sizeInfo.Rect);

            DrawCaptionTitle(g, sizeInfo);
            DrawControlBox(g, sizeInfo);

            g.Dispose();
            ReleaseDC(m.HWnd, hdc);
        }

        /// <summary>
        /// 绘制标题文字
        /// </summary>
        /// <param name="g"></param>
        /// <param name="sizeInfo"></param>
        private void DrawCaptionTitle(Graphics g, NonClientSizeInfo sizeInfo)
        {
            g.DrawString(this.Text, TitleFont, TitleBrush, new PointF(TitleMargin, sizeInfo.CaptionRect.Y));
        }

        /// <summary>
        /// 绘制标题区按钮
        /// </summary>
        /// <param name="g"></param>
        /// <param name="sizeInfo"></param>
        private void DrawControlBox(Graphics g, NonClientSizeInfo sizeInfo)
        {
            g.DrawImage(CloseButtonImage, sizeInfo.CloseBtnRect);
            g.DrawImage(MinimumButtonImage, sizeInfo.MinimumBtnRect);

            // 当前用户名不为空时，才显示用户名与用户图标
            if (!string.IsNullOrEmpty(UserName))
            {
                SizeF nameSize = g.MeasureString(UserName, BtnFont);
                Rectangle nameRect = new Rectangle((int)(sizeInfo.UserNameImageRect.X - nameSize.Width),
                    sizeInfo.UserNameImageRect.Y, (int)Math.Ceiling(sizeInfo.UserNameImageRect.Width + nameSize.Width) + 2,
                    sizeInfo.UserNameImageRect.Height);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Near;
                format.LineAlignment = StringAlignment.Center;
                g.FillRectangle(BtnBackBrush, nameRect);
                g.DrawString(UserName, BtnFont, BtnForeBrush, nameRect, format);
                g.DrawImage(UserNameImage, sizeInfo.UserNameImageRect);
            }
        }

        /// <summary>
        /// 获取非客户区窗体信息
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        private NonClientSizeInfo GetNonClientInfo(IntPtr hwnd)
        {
            NonClientSizeInfo info = new NonClientSizeInfo();
            info.BorderSize = BorderSize;
            info.CaptionHeight = CaptionHeight;

            _RECT areatRect = new _RECT();
            GetWindowRect(hwnd, ref areatRect);

            int width = areatRect.right - areatRect.left;
            int height = areatRect.bottom - areatRect.top;

            info.Width = width;
            info.Height = height;

            Point xy = new Point(areatRect.left, areatRect.top);
            xy.Offset(-areatRect.left, -areatRect.top);

            info.CaptionRect = new Rectangle(xy.X, xy.Y
                , width, info.CaptionHeight);
            info.Rect = new Rectangle(xy.X, xy.Y, width, height);
            info.ClientRect = new Rectangle(xy.X + info.BorderSize.Width,
                xy.Y + info.CaptionHeight + info.BorderSize.Height,
                width - info.BorderSize.Width * 2,
                height - info.CaptionHeight - info.BorderSize.Height * 2);

            info.CloseBtnRect = new Rectangle(new Point(xy.X + width - 2 * BtnHeight, info.BorderSize.Height),
                new Size(BtnHeight, BtnHeight));
            info.MinimumBtnRect = new Rectangle(info.CloseBtnRect.X - BtnHeight, info.CloseBtnRect.Y, BtnHeight, BtnHeight);
            info.UserNameImageRect = new Rectangle(info.MinimumBtnRect.X - 2 * BtnHeight, info.CloseBtnRect.Y, BtnHeight, BtnHeight);

            return info;
        }

        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= (WS_CLIPCHILDREN | WS_CLIPSIBLINGS);
                return createParams;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
