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
    public partial class frmSystemParameterManageEdit : Form
    {
        private EditMode em;
        private EapParameter entity;

        public frmSystemParameterManageEdit(EditMode para_em, EapParameter para_entity)
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

        private void frmSystemParameManageEdit_Load(object sender, EventArgs e)
        {
            if (em == EditMode.Add)
            {
                this.Text += "-新增";
                txtParaId.Enabled = true;
            }
            else if (em == EditMode.Edit)
            {
                this.Text += "-修改";
                txtParaId.Enabled = false;

                txtParaId.Text = entity.PARA_ID;
                txtParaName.Text = entity.PARA_NAME;
                txtParaValue.Text = entity.PARA_VALUE;
            }
        }

        private EapParameter GetEditEntity()
        {
            EapParameter ret_entity = new EapParameter();

            ret_entity.PARA_ID = txtParaId.Text.Trim();
            if (Func.StringLength(ret_entity.PARA_ID) == 0 || Func.StringLength(ret_entity.PARA_ID) > 30)
            {
                Func.ShowMessage(MessageType.Warning, "参数ID不能为空或或长度超长！");
                return null;
            }

            ret_entity.PARA_NAME = txtParaName.Text.Trim();
            if (Func.StringLength(ret_entity.PARA_NAME) > 30)
            {
                Func.ShowMessage(MessageType.Warning, "参数名称长度超长！");
                return null;
            }

            ret_entity.PARA_VALUE = txtParaValue.Text.Trim();
            if (Func.StringLength(ret_entity.PARA_VALUE) > 20)
            {
                Func.ShowMessage(MessageType.Warning, "参数值长度超长！");
                return null;
            }

            return ret_entity;
        }

        /// <summary>
        /// 校验日完工时间格式
        /// </summary>
        /// <returns></returns>
        private bool CheckDayCompletionTime()
        { 
            string[] str = this.txtParaValue.Text.Split(':');

            if (str != null && str.Length > 1)
            {
                int completionTime1 = 0;
                int completionTime2 = 0;
                try
                {
                    completionTime1 = Convert.ToInt32(str[0]);
                    completionTime2 = Convert.ToInt32(str[1]);
                }
                catch
                {
                    return false;
                }

                if (completionTime1 >= 0 && completionTime1 <= 23
                 && completionTime2 >= 0 && completionTime2 <= 59)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EapParameter edit_entity = GetEditEntity();
            if (edit_entity == null)
                return;

            if (this.txtParaId.Text.Equals("DayCompletionTime"))
            {
                if (!CheckDayCompletionTime())
                {
                    this.txtParaValue.Text = "8:00";
                    return;
                }
            }
            
            if (em == EditMode.Add)
            {
                string ret_add = Bll.GetBll().AddSystemParameter(edit_entity);
                if (ret_add != string.Empty)
                {
                    if (ret_add.Split(':')[0] == "ORA-00001")
                    {
                        Func.ShowMessage(MessageType.Error, "数据添加失败，原因:参数ID[" + edit_entity.PARA_ID + "]已经存在");
                        return;
                    }

                    Func.ShowMessage(MessageType.Error, "数据添加失败，原因[" + ret_add + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "添加系统参数数据成功，参数ID[" + edit_entity.PARA_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据添加成功！");
                this.Close();
            }
            else if (em == EditMode.Edit)
            {
                string ret_edit = Bll.GetBll().ModifySystemParameter(edit_entity);
                if (ret_edit != string.Empty)
                {
                    Func.ShowMessage(MessageType.Error, "数据修改失败，原因[" + ret_edit + "]");
                    return;
                }
                //写日志
                Log.Write(MessageType.Information, "修改系统参数数据成功，参数ID[" + edit_entity.PARA_ID + "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "数据修改成功！");
                this.Close();
            }
        }
    }
}
