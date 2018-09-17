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
    public partial class frmValueListManageEdit : Form
    {
        private EditMode em;
        private EapValueList entity;

        public frmValueListManageEdit(EditMode para_em, EapValueList para_entity)
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

        private void frmValueListManageManageEdit_Load(object sender, EventArgs e)
        {
            if (em == EditMode.Add)
            {
                this.Text += "-新增";
                txtVListId.Enabled = true;
            }
            else if (em == EditMode.Edit)
            {
                this.Text += "-修改";
                txtVListId.Enabled = false;

                txtVListId.Text = entity.VLIST_ID;
                txtVListName.Text = entity.VLIST_NAME;
            }
        }

        private EapValueList GetEditEntity()
        {
            EapValueList ret_entity = new EapValueList();

            ret_entity.VLIST_ID = txtVListId.Text.Trim();
            if (Func.StringLength(ret_entity.VLIST_ID) == 0 || Func.StringLength(ret_entity.VLIST_ID) > 20)
            {
                Func.ShowMessage(MessageType.Warning, "值列表ID不能为空或长度超长！");
                return null;
            }

            ret_entity.VLIST_NAME = txtVListName.Text.Trim();
            if (Func.StringLength(ret_entity.VLIST_NAME) == 0 || Func.StringLength(ret_entity.VLIST_NAME) > 50)
            {
                Func.ShowMessage(MessageType.Warning, "值列表名称不能为空或长度超长！");
                return null;
            }

            return ret_entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EapValueList edit_entity = GetEditEntity();
            if (edit_entity == null)
                return;

            if (em == EditMode.Add)
            {
                string ret_add = Bll.GetBll().AddValueList(edit_entity);
                if (ret_add != string.Empty)
                {
                    if (ret_add.Split(':')[0] == "ORA-00001")
                    {
                        Func.ShowMessage(MessageType.Error, "数据添加失败，原因:值列表ID[" + edit_entity.VLIST_ID + "]已经存在");
                        return;                    
                    }

                    Func.ShowMessage(MessageType.Error, "数据添加失败，原因[" + ret_add + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "添加值列表数据成功，值列表ID[" + edit_entity.VLIST_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据添加成功！");
                this.Close();
            }
            else if (em == EditMode.Edit)
            {
                string ret_edit = Bll.GetBll().ModifyValueList(edit_entity);
                if (ret_edit != string.Empty)
                {
                    Func.ShowMessage(MessageType.Error, "数据修改失败，原因[" + ret_edit + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "修改值列表数据成功，值列表ID[" + edit_entity.VLIST_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据修改成功！");
                this.Close();
            }
        }
    }
}
