using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

using Eap.Control;
using Eap.Entity;
using Eap.Enum;
using Eap.Resource;

namespace Eap.AppLoader
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                List<EapMenu> menus = Bll.GetBll().GetUserMenu(Config.GetConfig().user.USER_ID);
                if (null == menus)
                {
                    this.lblErrMsg.Text = "获取菜单失败！";
                }

                this.tlpLayout.SuspendLayout();
                var ctlMenu = new MenuEx((int)this.tlpLayout.Width, (int)(this.tlpLayout.Height * this.tlpLayout.RowStyles[1].Height / 100),
                    menus, new EventHandler(OpenForm));
                ctlMenu.Dock = DockStyle.Fill;
                ctlMenu.Anchor = AnchorStyles.Bottom;
                this.tlpLayout.Controls.Add(ctlMenu, 0, 1);
                this.tlpLayout.ResumeLayout();
            }
            catch (Exception ex)
            {
                this.lblErrMsg.Text = ex.Message;
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if (null == btn)
                {
                    Func.ShowMessage(MessageType.Error, "打开菜单异常，请联系管理员！");
                    return;
                }

                var menu = (EapMenu)btn.Tag;
                Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\" + menu.ASSEMBLY_NAME);
                Type t = assembly.GetType(menu.FORM_NAME);

                Form frm = (Form)Activator.CreateInstance(t);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                Func.ShowMessage(MessageType.Error, ex.Message);
            }
        }
    }
}
