using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

using Eap.Entity;
using Eap.Control;
using Eap.Enum;
using Eap.Resource;

namespace Eap.AppLoader
{
    public partial class frmMenu : Form
    {
        //总页数
        private int pagecnt = 1;
        //当前页
        private int pageno = 1;
        //页大小
        private int pagesize = 16;
        //按钮数组
        private ButtonEx[] btn = new ButtonEx[16];
        //当前绑定菜单，为空表示主菜单
        private string bindmenuid = string.Empty;
        //当前点击的菜单ID
        private string menuid = string.Empty;
        //上一次绑定菜单，为空表示主菜单
        private string prevbindmenuid = string.Empty;

        /// <summary>
        /// 构造函数
        /// </summary>
        public frmMenu()
        {
            InitializeComponent();
            Func.FormatForm(this);

            //绑定页面按钮
            btn[0] = btn1;
            btn[1] = btn2;
            btn[2] = btn3;
            btn[3] = btn4;
            btn[4] = btn5;
            btn[5] = btn6;
            btn[6] = btn7;
            btn[7] = btn8;
            btn[8] = btn9;
            btn[9] = btn10;
            btn[10] = btn11;
            btn[11] = btn12;
            btn[12] = btn13;
            btn[13] = btn14;
            btn[14] = btn15;
            btn[15] = btn16;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = EapResource.ButtonExitBackground;
            BindMainMenu();
        }

        /// <summary>
        /// 重置所有按钮名称和tag、状态
        /// </summary>
        private void ResetButton()
        {
            foreach (Button sub in btn)
            {
                sub.Text = string.Empty;
                sub.Tag = null;
                sub.Enabled = false;
            }

            //btnPrev.Enabled = false;
            //btnNext.Enabled = false;

            //if (pageno < pagecnt)
            //    btnNext.Enabled = true;

            //if (pageno > 1)
            //    btnPrev.Enabled = true;
        }

        /// <summary>
        /// 绑定主菜单数据
        /// </summary>
        private void BindMainMenu()
        {
            ResetButton();

            //获取用户一级权限菜单
            int icnt;
            List<EapMenu> list = Bll.GetBll().GetUserRight(pageno, pagesize, out icnt);
            if (list == null || list.Count == 0)
            {
                return;
            }

            //更新按钮总页数
            if (icnt % pagesize == 0)
                pagecnt = icnt / pagesize;
            else
                pagecnt = (icnt / pagesize) + 1;

            //设置按钮名称和tag
            for (int i = 0; i < list.Count; i++)
            {
                btn[i].Text = list[i].MENU_NAME;
                btn[i].Tag = list[i].MENU_ID;
                btn[i].Enabled = true;
            }

            //更新翻页按钮状态
            ResetPageButton();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageno >= pagecnt)
                return;

            pageno++;
            if (bindmenuid == string.Empty)
                BindMainMenu();
            else
                BindSubMenu();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageno == 1)
                return;

            pageno--;
            if (bindmenuid == string.Empty)
                BindMainMenu();
            else
                BindSubMenu();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            prevbindmenuid = bindmenuid;
            bindmenuid = string.Empty;
            pageno = 1;

            BindMainMenu();
        }

        /// <summary>
        /// 绑定子菜单数据
        /// </summary>
        private void BindSubMenu()
        {
            //获取用户指定菜单的子菜单权限
            int icnt;
            List<EapMenu> list = Bll.GetBll().GetUserSubMenuRight(bindmenuid, pageno, pagesize, out icnt);
            if (list == null)
            {
                return;
            }

            if (list.Count > 0)
            {
                //更新按钮总页数
                if (icnt % pagesize == 0)
                    pagecnt = icnt / pagesize;
                else
                    pagecnt = (icnt / pagesize) + 1;

                ResetButton();

                //设置按钮名称和tag
                for (int i = 0; i < list.Count; i++)
                {
                    btn[i].Text = list[i].MENU_NAME;
                    btn[i].Tag = list[i].MENU_ID;
                    btn[i].Enabled = true;
                }

                //更新翻页按钮状态
                ResetPageButton();
            }
            else
            {
                bindmenuid = prevbindmenuid;
                Func.ShowMessage(MessageType.Error, "绑定错误，没有找到子菜单数据");
            }
        }

        private void CheckIsForm()
        {
            //如果有窗体类名称则创建窗体
            EapMenu menu = Bll.GetBll().GetMenuById(menuid);
            if (menu.FORM_NAME != null)
            {
                try
                {
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
            else
            {
                prevbindmenuid = bindmenuid;
                bindmenuid = menuid;
                pageno = 1;
                BindSubMenu();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            menuid = btn1.Tag.ToString();
            CheckIsForm();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            menuid = btn2.Tag.ToString();
            CheckIsForm();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            menuid = btn3.Tag.ToString();
            CheckIsForm();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            menuid = btn4.Tag.ToString();
            CheckIsForm();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            menuid = btn5.Tag.ToString();
            CheckIsForm();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            menuid = btn6.Tag.ToString();
            CheckIsForm();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            menuid = btn7.Tag.ToString();
            CheckIsForm();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            menuid = btn8.Tag.ToString();
            CheckIsForm();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            menuid = btn9.Tag.ToString();
            CheckIsForm();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            menuid = btn10.Tag.ToString();
            CheckIsForm();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            menuid = btn11.Tag.ToString();
            CheckIsForm();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            menuid = btn12.Tag.ToString();
            CheckIsForm();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            menuid = btn13.Tag.ToString();
            CheckIsForm();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            menuid = btn14.Tag.ToString();
            CheckIsForm();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            menuid = btn15.Tag.ToString();
            CheckIsForm();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            menuid = btn16.Tag.ToString();
            CheckIsForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseDown(object sender, MouseEventArgs e)
        {
            btnExit.BackgroundImage = EapResource.ButtonExitMouseDown;
        }

        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {
            btnExit.BackgroundImage = EapResource.ButtonExitBackground;
        }

        private void ResetPageButton()
        {
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

            if (pageno < pagecnt)
                btnNext.Enabled = true;

            if (pageno > 1)
                btnPrev.Enabled = true;
        }
    }
}
