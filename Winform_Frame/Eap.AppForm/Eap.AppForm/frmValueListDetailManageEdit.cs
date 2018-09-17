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
    public partial class frmValueListDetailManageEdit : Form
    {
        private string vlist_id;

        public frmValueListDetailManageEdit(string para_vlist_id)
        {
            InitializeComponent();
            Func.FormatForm(this);

            vlist_id = para_vlist_id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmValueListManageManageEdit_Load(object sender, EventArgs e)
        {
            txtVListId.Text = vlist_id;
            txtVListId.Enabled = false;
        }

        private EapValueListDetail GetEditEntity()
        {
            EapValueListDetail ret_entity = new EapValueListDetail();

            ret_entity.VLIST_ID = txtVListId.Text.Trim();

            try
            {
                ret_entity.VLIST_DETAIL_VALUE = decimal.Parse(txtVListDetailValue.Text.Trim());
            }
            catch
            {
                Func.ShowMessage(MessageType.Warning, "值列表明细值无效，只能由数字组成，并且不能为空！");
                return null;
            }

            ret_entity.VLIST_DETAIL_NAME = txtVListDetailName.Text.Trim();
            if (Func.StringLength(ret_entity.VLIST_DETAIL_NAME) == 0 || Func.StringLength(ret_entity.VLIST_DETAIL_NAME) > 50)
            {
                Func.ShowMessage(MessageType.Warning, "值列表明细名称不能为空或长度超长！");
                return null;
            }

            return ret_entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EapValueListDetail edit_entity = GetEditEntity();
            if (edit_entity == null)
                return;

            string ret_add = Bll.GetBll().AddValueListDetail(edit_entity);
            if (ret_add != string.Empty)
            {
                Func.ShowMessage(MessageType.Error, "数据添加失败，原因[" + ret_add + "]");
                return;
            }
            //写日志
            Log.Write(MessageType.Information, "添加值列表明细数据成功，值列表ID[" + edit_entity.VLIST_ID + "],值列表明细值[" + edit_entity.VLIST_DETAIL_VALUE + "]", Config.GetConfig().user.USER_ID);
            Func.ShowMessage(MessageType.Information, "数据添加成功！");
            this.Close();
        }
    }
}
