using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using Mes.Entity;
using Eap.Entity;
using Eap.Enum;



namespace Eap.AppForm
{
    public partial class frmDepartmentManageEdit : Form
    {
        private EapDepartment entity;
        private EditMode em;//性质
        string log = "";//用于LOG记录存值
        private List<EapValueListDetail> list_user_trim_right;

        public frmDepartmentManageEdit(EditMode em_value, EapDepartment entity_value)
        {
            InitializeComponent();
            Func.FormatForm(this);
            //绑定值
            entity = entity_value;
            em = em_value;

        }

        private void frmDepartmentEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定部门类型下拉框
                foreach (EapDepartment sub in Bll.GetBll().GetDepartmant_TYPE())
                {
                    cmbDEPARTMENT_TYPE.Items.Add(new EapItem(sub.DEPARTMENT_TYPE, sub.DEPARTMENT_TYPE));
                }

                //绑定生产线下拉框
                foreach (EapDepartment sub in Bll.GetBll().GetASSEMBLY_LINE())
                {
                    cmbASSEMBLY_LINE.Items.Add(new EapItem(sub.ASSEMBLY_LINE, sub.ASSEMBLY_LINE));
                }
                
                //绑定状态
                cmbStatus.Items.Add(new EapItem("1", "有效"));
                cmbStatus.Items.Add(new EapItem("0", "无效"));
   
                if (em == EditMode.Edit)
                {
                    txtDEPARTMENT_NAME.Text = entity.DEPARTMENT_NAME;
                    txtDEPARTMENT_CODE.Text = entity.DEPARTMENT_CODE;
                    cmbDEPARTMENT_TYPE.Text = entity.DEPARTMENT_TYPE;
                    cmbASSEMBLY_LINE.Text = entity.ASSEMBLY_LINE;
                    foreach (Object obj in cmbStatus.Items)
                    {
                        EapItem item = (EapItem)obj;
                        if (item.ID == entity.STATUS.ToString())
                        {
                            cmbStatus.SelectedItem = obj;
                            break;
                        }
                    }

                    log += "  旧数据：部门编号[" + txtDEPARTMENT_CODE.Text + "],部门名称[" + txtDEPARTMENT_NAME.Text + "],类型[" + cmbDEPARTMENT_TYPE.Text + "],装配线[" + cmbASSEMBLY_LINE.Text + "],状态[" + cmbStatus.Text + "]  ";
                }
                else 
                {
                    if (cmbDEPARTMENT_TYPE.Items.Count > 0) 
                    {
                        cmbDEPARTMENT_TYPE.SelectedIndex = 0;
                    }

                    if (cmbStatus.Items.Count > 0)
                    {
                        cmbStatus.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Func.ShowMessage(MessageType.Warning, "发生错误，错误原因：" + ex.Message);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private EapDepartment GetAddEntity()
        {
            EapDepartment ret_entity = new EapDepartment();

            ret_entity.DEPARTMENT_ID = Bll.GetBll().GetDEPARTMENT_ID();
            ret_entity.DEPARTMENT_CODE = txtDEPARTMENT_CODE.Text;
            ret_entity.DEPARTMENT_NAME = txtDEPARTMENT_NAME.Text;
            ret_entity.DEPARTMENT_TYPE = cmbDEPARTMENT_TYPE.Text;
            ret_entity.ASSEMBLY_LINE = cmbASSEMBLY_LINE.Text;
            ret_entity.STATUS = decimal.Parse(((EapItem)cmbStatus.SelectedItem).ID);

            return ret_entity;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtDEPARTMENT_CODE.Text.Trim() == string.Empty)
            {
                Func.ShowMessage(MessageType.Warning, "部门编号不能为空");
                txtDEPARTMENT_CODE.Focus();
                return;
            }

            if (txtDEPARTMENT_NAME.Text.Trim() == string.Empty)
            {
                Func.ShowMessage(MessageType.Warning, "部门名称不能为空");
                txtDEPARTMENT_NAME.Focus();
                return;
            }
            if (cmbASSEMBLY_LINE.Text.Trim() == string.Empty)
            {
                Func.ShowMessage(MessageType.Warning, "装配线不能为空");
                cmbASSEMBLY_LINE.Focus();
                return;
            }
         
            
            string ret;
            if (em == EditMode.Edit)
            {
                if (Bll.GetBll().RepeatDEPARTMENT(txtDEPARTMENT_NAME.Text.Trim(), entity.DEPARTMENT_ID))
                {
                    Func.ShowMessage(MessageType.Warning, "部门名称重复，请重新输入");
                    txtDEPARTMENT_NAME.Focus();
                    return;
                }
                entity.DEPARTMENT_CODE = txtDEPARTMENT_CODE.Text;
                entity.DEPARTMENT_NAME = txtDEPARTMENT_NAME.Text;
                entity.DEPARTMENT_TYPE = cmbDEPARTMENT_TYPE.Text;
                entity.ASSEMBLY_LINE = cmbASSEMBLY_LINE.Text;
                entity.STATUS = decimal.Parse(((EapItem)cmbStatus.SelectedItem).ID);
                ret = Bll.GetBll().UpdateDEPARTMENT(entity);

                if (ret != string.Empty)
                {
                    Func.ShowMessage(MessageType.Information, "新增失败" + ret);
                    return;
                }

                Func.ShowMessage(MessageType.Information, "保存成功");
                //成功写入日志
                Log.Write(MessageType.Information, "修改部门成功,问题id[" + entity.DEPARTMENT_ID + "],  " + log + "   新数据：部门编号[" + txtDEPARTMENT_CODE.Text + "],部门名称[" + txtDEPARTMENT_NAME.Text + "],类型[" + cmbDEPARTMENT_TYPE.Text + "],装配线[" + cmbASSEMBLY_LINE.Text +"],状态[" + cmbStatus.Text + "] ", Config.GetConfig().user.USER_ID);
                this.Close();
            }
            else
            {
                if (Bll.GetBll().RepeatDEPARTMENT(txtDEPARTMENT_NAME.Text.Trim(), 0))
                {
                    Func.ShowMessage(MessageType.Warning, "部门名称重复，请重新输入");
                    txtDEPARTMENT_NAME.Focus();
                    return;
                }
                entity = GetAddEntity();
                ret = Bll.GetBll().AddDEPARTMENT(entity);

                if (ret != string.Empty)
                {
                    Func.ShowMessage(MessageType.Information, "新增失败" + ret);
                    return;
                }
                //成功写入日志
                Log.Write(MessageType.Information, "新增部门成功,id=[" + entity.DEPARTMENT_ID + "],部门编号[" + entity.DEPARTMENT_CODE + "],部门名称[" + entity.DEPARTMENT_NAME + "],部门类型[" +entity.DEPARTMENT_TYPE+ "],部门状态[" +entity.STATUS+ "]", Config.GetConfig().user.USER_ID);
                Func.ShowMessage(MessageType.Information, "新增成功");
                this.Close();

            }
  
        }
    }
}
