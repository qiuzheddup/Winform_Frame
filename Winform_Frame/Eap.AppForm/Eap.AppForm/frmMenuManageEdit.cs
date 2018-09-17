using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Eap;
using Eap.Enum;
using Eap.DbUnit;
using Eap.Entity;

namespace Eap.AppForm
{
    public partial class frmMenuManageEdit : Form
    {
        private EditMode em;
        private EapMenu entity;

        public frmMenuManageEdit(EditMode para_em, EapMenu para_entity)
        {
            InitializeComponent();
            Func.FormatForm(this);

            em = para_em;
            entity = para_entity;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuManageEdit_Load(object sender, EventArgs e)
        {
            if (em == EditMode.Add)
            {
                this.Text += "-新增";
                txtMenuId.Enabled = true;
            }
            else if (em == EditMode.Edit)
            {
                this.Text += "-修改";
                txtMenuId.Enabled = false;

                txtMenuId.Text = entity.MENU_ID;
                txtMenuName.Text = entity.MENU_NAME;
                txtParentMenuId.Text = entity.PARENT_MENU_ID;
                txtFormName.Text = entity.FORM_NAME;
                txtAssemblyName.Text = entity.ASSEMBLY_NAME;
            }
        }

        private EapMenu GetEditEntity()
        {
            EapMenu ret_entity = new EapMenu();

            ret_entity.MENU_ID = txtMenuId.Text.Trim();
            if (Func.StringLength(ret_entity.MENU_ID) == 0 || Func.StringLength(ret_entity.MENU_ID) > 20)
            {
                Func.ShowMessage(MessageType.Warning, "菜单编码不能为空或长度超长！");
                return null;
            }

            ret_entity.MENU_NAME = txtMenuName.Text.Trim();
            if (Func.StringLength(ret_entity.MENU_NAME) == 0 || Func.StringLength(ret_entity.MENU_NAME) > 50)
            {
                Func.ShowMessage(MessageType.Warning, "菜单名称不能为空或长度超长！！");
                return null;
            }

            ret_entity.PARENT_MENU_ID = txtParentMenuId.Text.Trim();
            if (Func.StringLength(ret_entity.PARENT_MENU_ID) > 20)
            {
                Func.ShowMessage(MessageType.Warning, "上级菜单编码长度超长！");
                return null;
            }

            ret_entity.FORM_NAME = txtFormName.Text.Trim();
            if (Func.StringLength(ret_entity.FORM_NAME) > 50)
            {
                Func.ShowMessage(MessageType.Warning, "窗体名称长度超长！");
                return null;
            }
            ret_entity.ASSEMBLY_NAME = txtAssemblyName.Text.Trim();
            if (Func.StringLength(ret_entity.ASSEMBLY_NAME) > 50)
            {
                Func.ShowMessage(MessageType.Warning, "程序集名称长度超长！");
                return null;
            }

            return ret_entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EapMenu edit_entity = GetEditEntity();
            if (edit_entity == null)
                return;

            if (edit_entity.PARENT_MENU_ID != string.Empty)
            {
                if (!Bll.GetBll().IsExistMenu(edit_entity.PARENT_MENU_ID))
                {
                    Func.ShowMessage(MessageType.Error, "数据保存失败，原因:上级菜单编码[" + edit_entity.PARENT_MENU_ID + "]不存在");
                    return;
                }
            }

            if (em == EditMode.Add)
            {
                string ret_add = Bll.GetBll().AddMenu(edit_entity);
                if (ret_add != string.Empty)
                {
                    if (ret_add.Split(':')[0] == "ORA-00001")
                    {
                        Func.ShowMessage(MessageType.Error, "数据添加失败，原因:菜单编码[" + edit_entity.MENU_ID + "]已经存在");
                        return;                    
                    }

                    Func.ShowMessage(MessageType.Error, "数据添加失败，原因[" + ret_add + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "添加菜单数据成功，菜单编码[" + edit_entity.MENU_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据添加成功！");
                this.Close();
            }
            else if (em == EditMode.Edit)
            {
                string ret_edit = Bll.GetBll().ModifyMenu(edit_entity);
                if (ret_edit != string.Empty)
                {
                    Func.ShowMessage(MessageType.Error, "数据修改失败，原因[" + ret_edit + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "修改菜单数据成功，菜单编码[" + edit_entity.MENU_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据修改成功！");
                this.Close();
            }
        }

        private void btnSelectParentMenuID_Click(object sender, EventArgs e)
        {
           
            Eap.Entity.EapCommonQuery entity = new Eap.Entity.EapCommonQuery();
            entity.TABLE_NAME = "T_EAP_MENU";
            entity.FIELD1 = "MENU_ID";
            entity.FIELD_NAME1 = "菜单ID";
            entity.FIELD2 = "MENU_NAME";
            entity.FIELD_NAME2 = "菜单名称";

            string str_where = "FORM_NAME is null and ASSEMBLY_NAME is null";

            entity.FROM_NAME = "frmMenuManageEdit";
            Eap.AppForm.frmShowEapItemList frm = new Eap.AppForm.frmShowEapItemList(entity, GetItem, str_where);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            
        }

        private void GetItem(EapItem ei) 
        {
            txtParentMenuId.Text = ei.ID;
        }
    }
}
