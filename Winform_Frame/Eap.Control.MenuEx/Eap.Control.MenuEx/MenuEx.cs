using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

using Eap.Entity;
using Eap.Resource;

namespace Eap.Control
{
    public partial class MenuEx : UserControl
    {
        private Font _mainBtnFont = new System.Drawing.Font("微软雅黑", 12F, FontStyle.Bold);
        private Font _subBtnFont = new System.Drawing.Font("微软雅黑", 11F, FontStyle.Bold);
        private int _mainColNum = 9;
        private int _mainRowNum = 7;
        private int _mainPageSize = 16;
        private int _subColNum = 10;
        private int _subRowNum = 9;
        private int _subPageSize = 12;
        private readonly IList<EapMenu> _userMenus = null; // 当前用户的所有菜单，平铺排开不分层级。
        private IList<EapMenu> _hierarchyMenus = null; // 用户所有菜单，按parentMenu分层级。
        private EapMenu _parentMenu = null; // 当父菜单为null，为主菜单页面。
        private IList<EapMenu> _subMenus = null; // 当前子菜单。
        private Page<EapMenu> _page;
        private EventHandler _openFormHandler;
        private ResourceManager _rm = null; // 菜单资源管理者

        public MenuEx(int width, int height, IList<EapMenu> userMenus, EventHandler openFormHandler)
        {
            InitializeComponent();

            if (null == userMenus)
            {
                this.lblErrMsg.Text = "获取菜单失败！";
            }

            _openFormHandler = openFormHandler;
            _userMenus = userMenus;
            _rm = new ResourceManager(typeof(EapResource));
            InitControl(width, height);
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        /// <param name="width"></param>
        /// <param name="hight"></param>
        private void InitControl(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.tlpMainMenu.SuspendLayout();
            this.tlpSubMenu.SuspendLayout();

            #region 初始化主菜单按钮

            for (int row = 0; row < _mainRowNum; row += 2)
            {
                for (int col = 1; col < _mainColNum; col += 2)
                {
                    Button btnMainMenu = new Button();
                    btnMainMenu.Anchor = AnchorStyles.None;
                    btnMainMenu.AutoEllipsis = true;
                    btnMainMenu.Dock = DockStyle.Fill;
                    btnMainMenu.Font = _mainBtnFont;
                    btnMainMenu.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btnMainMenu.FlatAppearance.BorderSize = 0;
                    btnMainMenu.FlatStyle = FlatStyle.Flat;
                    btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
                    btnMainMenu.Margin = new Padding(0);
                    btnMainMenu.Click += new EventHandler(ClickMainMenuItem);

                    this.tlpMainMenu.Controls.Add(btnMainMenu, col, row);
                }
            }

            #endregion

            #region 初始化子菜单按钮

            var btnParentMenu = new Button();
            btnParentMenu.Anchor = AnchorStyles.None;
            btnParentMenu.AutoEllipsis = true;
            btnParentMenu.Dock = DockStyle.Fill;
            btnParentMenu.Font = _mainBtnFont;
            btnParentMenu.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnParentMenu.FlatAppearance.BorderSize = 0;
            btnParentMenu.FlatStyle = FlatStyle.Flat;
            btnParentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            btnParentMenu.Margin = new Padding(0);
            this.tlpSubMenu.SetRowSpan(btnParentMenu, 2);
            this.tlpSubMenu.Controls.Add(btnParentMenu, 0, 0);

            var btnReturnParentMenu = new Button();
            btnReturnParentMenu.Size = new Size(0, 40);
            btnReturnParentMenu.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right);
            btnReturnParentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            btnReturnParentMenu.Dock = DockStyle.Bottom;
            btnReturnParentMenu.Font = _mainBtnFont;
            btnReturnParentMenu.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnReturnParentMenu.FlatAppearance.BorderSize = 0;
            btnReturnParentMenu.FlatStyle = FlatStyle.Flat;
            btnReturnParentMenu.Padding = new Padding(5);
            btnReturnParentMenu.Text = "返回上级菜单";
            btnReturnParentMenu.Image = EapResource.Return;
            btnReturnParentMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturnParentMenu.Margin = new Padding(0);
            btnReturnParentMenu.Click += new EventHandler(ReturnToParentMenu);
            this.tlpSubMenu.SetRowSpan(btnReturnParentMenu, 2);
            this.tlpSubMenu.Controls.Add(btnReturnParentMenu, 0, 2);

            for (int row = 0; row < _subRowNum; row += 2)
            {
                for (int col = 3; col < _subColNum - 2; col += 2)
                {
                    Button btnSubMenu = new Button();
                    btnSubMenu.Anchor = AnchorStyles.None;
                    btnSubMenu.AutoEllipsis = true;
                    btnSubMenu.Dock = DockStyle.Fill;
                    btnSubMenu.Font = _subBtnFont;
                    btnSubMenu.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    btnSubMenu.FlatAppearance.BorderSize = 0;
                    btnSubMenu.FlatStyle = FlatStyle.Flat;
                    btnSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
                    btnSubMenu.Margin = new Padding(0);
                    btnSubMenu.Click += new EventHandler(ClickSubMenuItem);

                    this.tlpSubMenu.Controls.Add(btnSubMenu, col, row);
                }
            }

            #endregion

            this.tlpMainMenu.ResumeLayout();
            this.tlpSubMenu.ResumeLayout();
        }

        /// <summary>
        /// 创建有层级关系的菜单树
        /// </summary>
        /// <param name="menu"></param>
        private void ConstructHierarchyMenus(EapMenu menu)
        {
            menu.SUB_MENU = _userMenus.Where((item) => { return menu.MENU_ID == item.PARENT_MENU_ID; }).ToList();
            if (null == menu.SUB_MENU || 0 == menu.SUB_MENU.Count)
            {
                return;
            }
            else
            {
                foreach (var subMenu in menu.SUB_MENU)
                {
                    ConstructHierarchyMenus(subMenu);
                }
            }
        }

        private void MenuEx_Load(object sender, EventArgs e)
        {
            var menuHierarchy = new EapMenu();
            ConstructHierarchyMenus(menuHierarchy);
            _hierarchyMenus = menuHierarchy.SUB_MENU;
            _parentMenu = null;
            _subMenus = new List<EapMenu>(_hierarchyMenus);
            _page = new Page<EapMenu>();
            _page.PageIndex = 1;
            _page.PageSize = _mainPageSize;
            _page.DataSource = _subMenus;
            ShowMenu();
        }

        /// <summary>
        /// 显示菜单内容
        /// </summary>
        private void ShowMenu()
        {
            this.tlpMainMenu.SuspendLayout();
            this.tlpSubMenu.SuspendLayout();

            if (null == _parentMenu)
            {
                #region 显示一级菜单

                this.pnlMainMenu.Visible = true;
                this.pnlSubMenu.Visible = false;
                _page.PageSize = _mainPageSize;

                var menus = _page.GetPageData();
                for (int row = 0, index = 0; row < _mainRowNum; row += 2)
                {
                    for (int col = 1; col < _mainColNum; col += 2)
                    {
                        Button btn = this.tlpMainMenu.GetControlFromPosition(col, row) as Button;
                        if (null != btn)
                        {
                            if (index < menus.Count)
                            {
                                btn.Tag = menus[index];
                                btn.Text = menus[index].MENU_NAME;
                                SetMenuButtonImageStyle(btn, menus[index].ICON, 20, 15);
                                btn.Visible = true;
                                index++;
                            }
                            else
                            {
                                btn.Visible = false;
                            }
                        }
                    }
                }

                this.btnMainNextPage.Visible = _page.HasNextPage();
                this.btnMainPrevPage.Visible = _page.HasPrevPage();

                #endregion
            }
            else
            {
                #region 显示二级菜单

                this.pnlMainMenu.Visible = false;
                this.pnlSubMenu.Visible = true;
                _page.PageSize = _subPageSize;

                var btnParentMenu = this.tlpSubMenu.GetControlFromPosition(0, 0) as Button;
                btnParentMenu.Tag = _parentMenu;
                btnParentMenu.Text = _parentMenu.MENU_NAME;
                SetMenuButtonImageStyle(btnParentMenu, _parentMenu.ICON, 15, 15);

                var menus = _page.GetPageData();
                for (int row = 0, index = 0; row < _subRowNum; row += 2)
                {
                    for (int col = 3; col < _subColNum - 2; col += 2)
                    {
                        Button btn = this.tlpSubMenu.GetControlFromPosition(col, row) as Button;
                        if (null != btn)
                        {
                            if (index < menus.Count)
                            {
                                btn.Tag = menus[index];
                                btn.Text = menus[index].MENU_NAME;
                                SetMenuButtonImageStyle(btn, menus[index].ICON, 15, 10);
                                btn.Visible = true;
                                index++;
                            }
                            else
                            {
                                btn.Visible = false;
                            }
                        }
                    }
                }

                this.btnSubNextPage.Visible = _page.HasNextPage();
                this.btnSubPrevPage.Visible = _page.HasPrevPage();

                #endregion
            }

            this.tlpMainMenu.ResumeLayout();
            this.tlpSubMenu.ResumeLayout();
        }

        /// <summary>
        /// 设置菜单按钮图片文字显示样式。
        /// </summary>
        /// <param name="btn">按钮</param>
        /// <param name="icon">图片在Eap.Resource中的资源名称</param>
        /// <param name="paddingTop">图片与按钮顶部的距离</param>
        /// <param name="paddingImage">文字与图片的距离</param>
        private void SetMenuButtonImageStyle(Button btn, string icon, int paddingTop, int paddingImage)
        {
            if (null != icon)
            {
                var image = (Bitmap)_rm.GetObject(icon);
                if (null != image) // 如果能正确获得图片资源，则显示图片
                {
                    btn.Image = image;
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.TextImageRelation = TextImageRelation.ImageAboveText;
                    return;
                }
            }

            btn.Image = null;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Padding = new Padding(0);
        }

        /// <summary>
        /// 点击主菜单按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMainMenuItem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (null != btn)
            {
                var btnTag = btn.Tag as EapMenu;
                if (null != btnTag)
                {
                    _parentMenu = btnTag;
                    _subMenus = _parentMenu.SUB_MENU;
                    _page.DataSource = _subMenus;
                    _page.PageIndex = 1;
                    ShowMenu();
                }
            }
        }

        /// <summary>
        /// 点击子菜单按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSubMenuItem(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (null != btn)
            {
                var menu = btn.Tag as EapMenu;
                if (null == menu.SUB_MENU || 0 == menu.SUB_MENU.Count)
                {
                    _openFormHandler.Invoke(sender, e);
                }
                else
                {
                    _parentMenu = menu;
                    _subMenus = menu.SUB_MENU;
                    _page.DataSource = _subMenus;
                    _page.PageIndex = 1;
                    ShowMenu();
                }
            }
        }

        /// <summary>
        /// 返回上级菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToParentMenu(object sender, EventArgs e)
        {
            // 当其是一级菜单时，其父菜单为null，_userMenus中找不到menu_id为null的项，
            // 则获取其默认值null，正好作为默认的主菜单的父菜单。
            // 当其是二级、三级等子菜单时，可顺利获取到父菜单。
            _parentMenu = _userMenus.Where((item) => { return _parentMenu.PARENT_MENU_ID == item.MENU_ID; }).FirstOrDefault();
            _subMenus = (null == _parentMenu) ? new List<EapMenu>(_hierarchyMenus) : _parentMenu.SUB_MENU;
            _page.DataSource = _subMenus;
            _page.PageIndex = 1;
            ShowMenu();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            _page.PrevPage();
            ShowMenu();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _page.NextPage();
            ShowMenu();
        }
    }
}
