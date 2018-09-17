using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

using Eap.Enum;
using Eap.Entity;
using System.Drawing.Imaging;

namespace Eap.AppForm
{
    public partial class frmServerProcessStatusQuery : Form
    {
        public frmServerProcessStatusQuery()
        {
            InitializeComponent();
            Func.FormatForm(this);
            InitBitmap();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmServerProcessStatusQuery_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            InitProcessRefreshTimeout();
            BindData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void timRefresh_Tick(object sender, EventArgs e)
        {
            if (isRefreshFlag)
                return;
            BindData();

        }

        Bitmap bmp_starting;
        Bitmap bmp_stoped;
        Bitmap bmp_null;
        bool isRefreshFlag = false;
        int process_refresh_timeout = 5 * 60 * 1000;

        private void InitBitmap()
        {
            CreateBitmap(Color.Green, "starting");
            CreateBitmap(Color.Yellow, "stoped");
            CreateBitmap(Color.Yellow, "bmp_null");
        }

        private void CreateBitmap(Color color, string status)
        {
            int temp = 30;

            Brush bush = new SolidBrush(color);
            Graphics gra;
            switch (status)
            {
                case "starting":
                    bmp_starting = new Bitmap(temp, temp, PixelFormat.Format32bppArgb);
                    gra = Graphics.FromImage(bmp_starting);
                    Point[] point_starting = {
                            new Point(0,0),
                            new Point(0, temp),
                            new Point(temp, temp/2)
                        };
                    gra.Clear(this.BackColor);
                    gra.FillPolygon(bush, point_starting);
                    break;
                case "stoped":
                    bmp_stoped = new Bitmap(temp, temp, PixelFormat.Format32bppArgb);
                    gra = Graphics.FromImage(bmp_stoped);
                    gra.Clear(this.BackColor);
                    gra.FillEllipse(bush, 0, 0, temp, temp);
                    break;
                case "bmp_null":
                    bmp_null = new Bitmap(temp, temp, PixelFormat.Format32bppArgb);
                    gra = Graphics.FromImage(bmp_null);
                    gra.Clear(this.BackColor);
                    //gra.FillEllipse(bush, 0, 0, temp, temp);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 初始化进程刷新超时时间
        /// </summary>
        private void InitProcessRefreshTimeout()
        {
            EapParameter process_refresh_timeout_para = Bll.GetBll().GetProcessRefreshTime();
            if (process_refresh_timeout_para != null)
            {
                try
                {
                    process_refresh_timeout = Convert.ToInt32(process_refresh_timeout_para.PARA_VALUE) * 60 * 1000;
                    lblRefreshTimeout.Text = "进程刷新超时时间：" + process_refresh_timeout_para.PARA_VALUE + "分钟";
                }
                catch
                {
                    process_refresh_timeout = 5 * 60 * 1000;
                    lblRefreshTimeout.Text = "进程刷新超时时间：5 分钟";
                }
            }
        }

        private void BindData()
        {
            isRefreshFlag = true;

            //获取进程表数据
            List<EapProcess> list = Bll.GetBll().GetProcessStatus();

            if (list == null || list.Count == 0)
                return;

            //系统时间（数据库DB时间）
            lblSystemTime.Text = list[0].DBTIME.ToString();

            dgv.DataSource = list;
            
            isRefreshFlag = false;
        }

        private void SetImage()
        {
            try
            {
                if (dgv.Rows.Count == 0)
                    return;
                foreach (DataGridViewRow sub in dgv.Rows)
                {
                    object PROCESS_SOCKET_STATUS = sub.Cells["PROCESS_SOCKET_STATUS"].Value;
                    object PROCESS_STATUS = sub.Cells["PROCESS_STATUS"].Value;

                    //通讯状态
                    if (PROCESS_SOCKET_STATUS != null)
                    {
                        if (PROCESS_SOCKET_STATUS.ToString() == "1")
                        {
                            sub.Cells["PROCESS_SOCKET_STATUS_IMAGE"].Value = bmp_starting;
                        }
                        else if (PROCESS_SOCKET_STATUS.ToString() == "0")
                        {
                            sub.Cells["PROCESS_SOCKET_STATUS_IMAGE"].Value = bmp_stoped;
                        }
                    }
                    else
                    {
                        sub.Cells["PROCESS_SOCKET_STATUS_IMAGE"].Value = bmp_null;
                    }

                    //进程状态
                    if (PROCESS_STATUS != null)
                    {
                        if (PROCESS_STATUS.ToString() == "1")
                        {
                            sub.Cells["PROCESS_STATUS_IMAGE"].Value = bmp_starting;
                        }
                        else if (PROCESS_STATUS.ToString() == "0")
                        {
                            sub.Cells["PROCESS_STATUS_IMAGE"].Value = bmp_stoped;
                        }
                    }
                    else
                    {
                        sub.Cells["PROCESS_SOCKET_STATUS_IMAGE"].Value = bmp_null;
                    }
                }
            }
            catch (Exception ex)
            {
                Func.ShowMessage(MessageType.Warning, ex.Message);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetImage();
        }
    }


}
