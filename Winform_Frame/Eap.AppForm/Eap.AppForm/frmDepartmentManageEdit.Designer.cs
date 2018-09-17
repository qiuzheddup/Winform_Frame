namespace Eap.AppForm
{
    partial class frmDepartmentManageEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentManageEdit));
            this.txtDEPARTMENT_NAME = new System.Windows.Forms.TextBox();
            this.txtDEPARTMENT_CODE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDEPARTMENT_TYPE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnEnter = new Eap.Control.ButtonEx();
            this.btnExit = new Eap.Control.ButtonEx();
            this.cmbASSEMBLY_LINE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDEPARTMENT_NAME
            // 
            this.txtDEPARTMENT_NAME.Location = new System.Drawing.Point(454, 169);
            this.txtDEPARTMENT_NAME.Name = "txtDEPARTMENT_NAME";
            this.txtDEPARTMENT_NAME.Size = new System.Drawing.Size(200, 29);
            this.txtDEPARTMENT_NAME.TabIndex = 1;
            // 
            // txtDEPARTMENT_CODE
            // 
            this.txtDEPARTMENT_CODE.Location = new System.Drawing.Point(454, 121);
            this.txtDEPARTMENT_CODE.Name = "txtDEPARTMENT_CODE";
            this.txtDEPARTMENT_CODE.Size = new System.Drawing.Size(200, 29);
            this.txtDEPARTMENT_CODE.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "部门名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "部门编号：";
            // 
            // cmbDEPARTMENT_TYPE
            // 
            this.cmbDEPARTMENT_TYPE.FormattingEnabled = true;
            this.cmbDEPARTMENT_TYPE.Location = new System.Drawing.Point(454, 217);
            this.cmbDEPARTMENT_TYPE.Name = "cmbDEPARTMENT_TYPE";
            this.cmbDEPARTMENT_TYPE.Size = new System.Drawing.Size(150, 29);
            this.cmbDEPARTMENT_TYPE.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "状态：";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(454, 264);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 29);
            this.cmbStatus.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(345, 364);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(80, 50);
            this.btnEnter.TabIndex = 26;
            this.btnEnter.Text = "保存";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(592, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbASSEMBLY_LINE
            // 
            this.cmbASSEMBLY_LINE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbASSEMBLY_LINE.FormattingEnabled = true;
            this.cmbASSEMBLY_LINE.Location = new System.Drawing.Point(454, 311);
            this.cmbASSEMBLY_LINE.Name = "cmbASSEMBLY_LINE";
            this.cmbASSEMBLY_LINE.Size = new System.Drawing.Size(150, 29);
            this.cmbASSEMBLY_LINE.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "装配线：";
            // 
            // frmDepartmentManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbASSEMBLY_LINE);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDEPARTMENT_TYPE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDEPARTMENT_NAME);
            this.Controls.Add(this.txtDEPARTMENT_CODE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDepartmentManageEdit";
            this.Text = "部门维护-设置";
            this.Load += new System.EventHandler(this.frmDepartmentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDEPARTMENT_NAME;
        private System.Windows.Forms.TextBox txtDEPARTMENT_CODE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDEPARTMENT_TYPE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private Control.ButtonEx btnEnter;
        private Control.ButtonEx btnExit;
        private System.Windows.Forms.ComboBox cmbASSEMBLY_LINE;
        private System.Windows.Forms.Label label5;
    }
}