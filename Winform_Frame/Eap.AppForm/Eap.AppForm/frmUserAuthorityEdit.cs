using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;

using Eap.Enum;
using Eap.Entity;

namespace Eap.AppForm
{
    public partial class frmUserAuthorityEdit : Form
    {
        private EditMode em;
        private EapUser user;
        public bool kg = false;
        List<EapMenu> list_menu;
        List<EapUserMenuRight> list_menu_right = new List<EapUserMenuRight>();
        List<EapButton> list_button;
      
        public frmUserAuthorityEdit(EditMode para_em, EapUser entity)
        {
            InitializeComponent();
            Func.FormatForm(this);

            em = para_em;
            user = entity;
        }

        private void frmUserAuthorityEdit_Load(object sender, EventArgs e)
        {
            if (em == EditMode.Edit)
            {
                this.txtUserID.ReadOnly = true;
                txtUserID.Text = user.USER_ID;
                txtUserName.Text = user.USER_NAME;
                txtIsStop.Text = user.IS_STOP == 1 ? "停用" : "启用";
            }
            GetMenuAuthority();
            SetUserRight(user.USER_ID);
        }

        /// <summary>
        /// 生成权限菜单
        /// </summary>
        private void GetMenuAuthority()
        {
            list_menu = Bll.GetBll().GetUserAuthority();
            this.tvRightMenu.Nodes.Clear();//清空所有节点
            BindTransportTree(this.tvRightMenu.Nodes, "");//创建树
        }

        private void BindTransportTree(TreeNodeCollection nds, string parentId)//递归读取树形
        {
            try 
            {
                TreeNode tn = null;

                List<EapMenu> list1 = list_menu.FindAll(a => a.PARENT_MENU_ID == (parentId == "" ? null : parentId));

                foreach (EapMenu m in list1)
                {
                    tn = new TreeNode(m.MENU_NAME.ToString());
                    tn.Tag = m;
                    nds.Add(tn);
                    BindTransportTree(tn.Nodes, m.MENU_ID);
                   
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvRightMenu.Nodes)
            {
                tn.Checked = true;
                foreach (TreeNode bn in tn.Nodes)
                {
                    bn.Checked = true;
                }
            }
        }

        private void btNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvRightMenu.Nodes)
            {
                tn.Checked = false;
                foreach (TreeNode bn in tn.Nodes)
                {
                    bn.Checked = false;
                }
            }
        }

        //设置权限
        private void SetUserRight(string UserID)
        {
            ClearTreeViewChecked(tvRightMenu.Nodes);
            kg = false;
            List<EapUserMenuRight> list = Bll.GetBll().GetAuthoritybyUser(UserID);
            if (list.Count > 0)
            {
                foreach (EapUserMenuRight m in list)//设置当前角色的选择项
                {
                   
                    SearchNode(this.tvRightMenu.Nodes, m.MENU_ID);//递归查找并选中   
                }
            }
            kg = true;//处理完成，可以选择节点复选框
        }

        private void ClearTreeViewChecked(TreeNodeCollection tnds)
        {
            foreach (TreeNode tn in tnds)
            {
                tn.Checked = false;
                foreach (TreeNode bn in tn.Nodes)
                {
                    ClearTreeViewChecked(bn.Nodes);
                }
            }
        }

        //递归查找并选中
        private void SearchNode(TreeNodeCollection tnds, string menuId)
        {
            try
            {
                foreach (TreeNode tnd in tnds)
                {
                    var menu = (EapMenu)tnd.Tag;
                    if (menu.MENU_ID == menuId)
                    {
                        tnd.Checked = true;// mg.Text = mg.Text + ";" + text;
                        break;
                    }
                    if (tnd.Nodes.Count != 0)
                    {
                        SearchNode(tnd.Nodes, menuId);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region treeView子节点与父节点之间的互动关系
        private bool m_SetClick = true;
        private void SetSubNodeCheck(TreeNode p_TreeNode, bool p_SelectCheck)
        {
            try
            {
                m_SetClick = false;
                foreach (TreeNode _SubNode in p_TreeNode.Nodes)
                {
                    _SubNode.Checked = p_SelectCheck;
                    SetSubNodeCheck(_SubNode, p_SelectCheck);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }

        }

        private void SetParentCheck(TreeNode p_TreeNode)
        {
            try
            {
                if (p_TreeNode.Checked && p_TreeNode.Parent != null)
                {
                    p_TreeNode.Parent.Checked = true;
                    SetParentCheck(p_TreeNode.Parent);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }

        }

        private void SetParentNotCheck(TreeNode p_TreeNode)
        {
            try
            {
                if (!p_TreeNode.Checked && p_TreeNode.Parent != null)
                {
                    foreach (TreeNode _Node in p_TreeNode.Parent.Nodes)
                    {
                        if (_Node.Checked) return;
                    }
                    p_TreeNode.Parent.Checked = false;
                    SetParentNotCheck(p_TreeNode.Parent);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }

        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            list_menu_right.Clear();
            GetUsetMenuRight(tvRightMenu.Nodes);

            string ret = Bll.GetBll().SaveUserMenuRight(user.USER_ID,list_menu_right);
            if (ret != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, ret);
                Log.Write(MessageType.Error, "用户菜单授权失败，原因[" + ret + "]", Eap.Config.GetConfig().user.USER_ID);
                return;
            }

            Func.ShowMessage(MessageType.Information, "用户菜单授权成功！");
            Log.Write(MessageType.Information, "用户菜单授权成功！", Eap.Config.GetConfig().user.USER_ID);
        }

        private void tvRight_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (kg == true)
                {
                    if (m_SetClick)
                    {
                        SetSubNodeCheck(e.Node, e.Node.Checked);
                        SetParentCheck(e.Node);
                        SetParentNotCheck(e.Node);
                        m_SetClick = true;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }
        }

        private void GetUsetMenuRight(TreeNodeCollection treeNodes )
        {
            foreach (TreeNode tn in treeNodes)
            {
                if (tn.Checked)
                {
                    EapUserMenuRight UserMenu = new EapUserMenuRight();
                    UserMenu.USER_ID = user.USER_ID;
                    UserMenu.MENU_ID = ((EapMenu)tn.Tag).MENU_ID;
                    list_menu_right.Add(UserMenu);
                }
                GetUsetMenuRight(tn.Nodes);
            }
        }

        //====================================================================================

        private void tvRightMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EapMenu entity_select_menu = e.Node.Tag as EapMenu;
            if (entity_select_menu.FORM_NAME != null)
            {
                try
                {
                    //1.获取当前选择窗体的所有权限控制按钮
                    GetButtonAuthority(entity_select_menu);
                    if (list_button == null || list_button.Count == 0)
                    {
                        return;
                    }
                    SetUserButtonRight(user.USER_ID);
                }
                catch (Exception ex)
                {
                    Func.ShowMessage(MessageType.Error, ex.Message);
                }
            }
            else
            {
                tvRightButton.Nodes.Clear();
            }
        }

        /// <summary>
        /// 生成指定窗体权限按钮
        /// </summary>
        private void GetButtonAuthority(EapMenu form_menu)
        {
            list_button = Bll.GetBll().GetFormUserAuthorityButton(form_menu);
            this.tvRightButton.Nodes.Clear();//清空所有节点
            CreateButtonTree(this.tvRightButton.Nodes, form_menu);//创建树
        }

        private void CreateButtonTree(TreeNodeCollection tns, EapMenu form_menu)
        {
            //树跟（窗体）
                TreeNode tn_root = new TreeNode(form_menu.MENU_NAME);
                tn_root.Tag = form_menu;
                tns.Add(tn_root);

            //如果窗体有权限控制按钮，在树根下生成子节点
            if (list_button != null)
            {
                foreach (EapButton sub in list_button)
                {
                    TreeNode tn = new TreeNode(sub.BUTTON_TEXT);
                    tn.Tag = sub;
                    tn_root.Nodes.Add(tn);
                }
            }
            
           
        }

        private void GetUsetButtonRight(TreeNodeCollection treeNodes, ref List<EapUserButtonRight> list_button_right, ref EapMenu button_right_menu)
        {
            foreach (TreeNode tn in treeNodes)
            {
                if (tn.Tag is EapMenu)
                {
                    button_right_menu = tn.Tag as EapMenu;
                }

                if (tn.Tag is EapButton)
                {
                    if (tn.Checked)
                    {
                        EapUserButtonRight user_button = new EapUserButtonRight();
                        user_button.USER_ID = user.USER_ID;
                        user_button.BUTTON_ID = ((EapButton)tn.Tag).BUTTON_ID;
                        list_button_right.Add(user_button);
                    }
                }
                GetUsetButtonRight(tn.Nodes, ref list_button_right, ref button_right_menu);
            }
        }

        //设置权限
        private void SetUserButtonRight(string UserID)
        {
            ClearTreeViewChecked(tvRightButton.Nodes);
            kg = false;
            List<EapUserButtonRight> list = Bll.GetBll().GetButtonAuthoritybyUser(UserID);
            if (list.Count > 0)
            {
                foreach (EapUserButtonRight m in list)//设置当前角色的选择项
                {

                    SearchNodeAndCheck(this.tvRightButton.Nodes, m.BUTTON_ID);//递归查找并选中   
                }
            }
            kg = true;//处理完成，可以选择节点复选框
        }

        private void SearchNodeAndCheck(TreeNodeCollection tns, decimal button_id)
        {
            try
            {
                foreach (TreeNode tnd in tns)
                {
                    if (tnd.Tag is EapButton)
                    {
                        if (((EapButton)tnd.Tag).BUTTON_ID == button_id)
                        {
                            tnd.Checked = true;// mg.Text = mg.Text + ";" + text;

                            if (!tnd.Parent.Checked)
                            {
                                tnd.Parent.Checked = true;
                            }
                            break;
                        }
                    }
                    if (tnd.Nodes.Count != 0)
                    {
                        SearchNodeAndCheck(tnd.Nodes, button_id);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }
        }

        private void btnAllButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvRightButton.Nodes)
            {
                tn.Checked = true;
                foreach (TreeNode bn in tn.Nodes)
                {
                    bn.Checked = true;
                }
            }
        }

        private void btNoneButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvRightButton.Nodes)
            {
                tn.Checked = false;
                foreach (TreeNode bn in tn.Nodes)
                {
                    bn.Checked = false;
                }
            }
        }

        private void btnSaveButton_Click(object sender, EventArgs e)
        {
            List<EapUserButtonRight> list_button_right = new List<EapUserButtonRight>();
            EapMenu button_right_menu = null;

            GetUsetButtonRight(tvRightButton.Nodes, ref list_button_right, ref button_right_menu);

            if (button_right_menu != null)
            {
                string ret = Bll.GetBll().SaveUserButtonRight(user.USER_ID, list_button_right, button_right_menu);
                if (ret != string.Empty)
                {
                    Func.ShowMessage(MessageType.Error, ret);
                    Log.Write(MessageType.Error, "用户按钮授权失败，原因[" + ret + "]", Eap.Config.GetConfig().user.USER_ID);
                    return;
                }
            }

            Func.ShowMessage(MessageType.Information, "用户按钮授权成功！");
            Log.Write(MessageType.Information, "用户按钮授权成功！", Eap.Config.GetConfig().user.USER_ID);
        }

        private void tvRightButton_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (kg == true)
                {
                    if (m_SetClick)
                    {
                        SetSubNodeCheck(e.Node, e.Node.Checked);
                        SetParentCheck(e.Node);
                        SetParentNotCheck(e.Node);
                        m_SetClick = true;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "提示");
            }
        }
    }
}
