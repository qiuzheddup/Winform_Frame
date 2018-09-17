namespace Eap.AppForm
{
    partial class frmDepartmentManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbSTATUS = new System.Windows.Forms.CheckBox();
            this.dgv = new Eap.Control.DataGridViewEx();
            this.page = new Eap.Control.PageSelect();
            this.txtDEPARTMENT_CODE = new System.Windows.Forms.TextBox();
            this.txtDEPARTMENT_NAME = new System.Windows.Forms.TextBox();
            this.cmbDEPARTMENT_TYPE = new System.Windows.Forms.ComboBox();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.btnQuery = new Eap.Control.ButtonEx();
            this.btnUpate = new Eap.Control.ButtonEx();
            this.btnDelete = new Eap.Control.ButtonEx();
            this.btnInsert = new Eap.Control.ButtonEx();
            this.DEPARTMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSEMBLY_LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_FALSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "类型：";
            // 
            // chbSTATUS
            // 
            this.chbSTATUS.AutoSize = true;
            this.chbSTATUS.Location = new System.Drawing.Point(895, 112);
            this.chbSTATUS.Name = "chbSTATUS";
            this.chbSTATUS.Size = new System.Drawing.Size(109, 25);
            this.chbSTATUS.TabIndex = 3;
            this.chbSTATUS.Text = "显示已失效";
            this.chbSTATUS.UseVisualStyleBackColor = true;
            this.chbSTATUS.CheckedChanged += new System.EventHandler(this.chbSTATUS_CheckedChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(147)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 28;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEPARTMENT_ID,
            this.NO,
            this.DEPARTMENT_CODE,
            this.DEPARTMENT_NAME,
            this.DEPARTMENT_TYPE,
            this.STATUS,
            this.ASSEMBLY_LINE,
            this.STATUS_FALSE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.dgv.Location = new System.Drawing.Point(7, 142);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(70)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(1000, 492);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 14;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.page.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page.Location = new System.Drawing.Point(352, 645);
            this.page.Margin = new System.Windows.Forms.Padding(5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(655, 50);
            this.page.TabIndex = 15;
            this.page.PageChange += new Eap.Control.PageSelect.PageSelected(this.page_PageChange);
            // 
            // txtDEPARTMENT_CODE
            // 
            this.txtDEPARTMENT_CODE.Location = new System.Drawing.Point(110, 14);
            this.txtDEPARTMENT_CODE.Name = "txtDEPARTMENT_CODE";
            this.txtDEPARTMENT_CODE.Size = new System.Drawing.Size(200, 29);
            this.txtDEPARTMENT_CODE.TabIndex = 0;
            // 
            // txtDEPARTMENT_NAME
            // 
            this.txtDEPARTMENT_NAME.Location = new System.Drawing.Point(444, 14);
            this.txtDEPARTMENT_NAME.Name = "txtDEPARTMENT_NAME";
            this.txtDEPARTMENT_NAME.Size = new System.Drawing.Size(200, 29);
            this.txtDEPARTMENT_NAME.TabIndex = 1;
            // 
            // cmbDEPARTMENT_TYPE
            // 
            this.cmbDEPARTMENT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDEPARTMENT_TYPE.FormattingEnabled = true;
            this.cmbDEPARTMENT_TYPE.Location = new System.Drawing.Point(746, 14);
            this.cmbDEPARTMENT_TYPE.Name = "cmbDEPARTMENT_TYPE";
            this.cmbDEPARTMENT_TYPE.Size = new System.Drawing.Size(150, 29);
            this.cmbDEPARTMENT_TYPE.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(844, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(681, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(29, 53);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 50);
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnUpate
            // 
            this.btnUpate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpate.BackgroundImage")));
            this.btnUpate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpate.FlatAppearance.BorderSize = 0;
            this.btnUpate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpate.ForeColor = System.Drawing.Color.White;
            this.btnUpate.Location = new System.Drawing.Point(355, 53);
            this.btnUpate.Name = "btnUpate";
            this.btnUpate.Size = new System.Drawing.Size(80, 50);
            this.btnUpate.TabIndex = 22;
            this.btnUpate.Text = "修改";
            this.btnUpate.UseVisualStyleBackColor = true;
            this.btnUpate.Click += new System.EventHandler(this.btnUpate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(518, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 50);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(192, 53);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 50);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // DEPARTMENT_ID
            // 
            this.DEPARTMENT_ID.DataPropertyName = "DEPARTMENT_ID";
            this.DEPARTMENT_ID.HeaderText = "部门ID";
            this.DEPARTMENT_ID.Name = "DEPARTMENT_ID";
            this.DEPARTMENT_ID.ReadOnly = true;
            this.DEPARTMENT_ID.Visible = false;
            this.DEPARTMENT_ID.Width = 80;
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "序号";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 80;
            // 
            // DEPARTMENT_CODE
            // 
            this.DEPARTMENT_CODE.DataPropertyName = "DEPARTMENT_CODE";
            this.DEPARTMENT_CODE.HeaderText = "部门编号";
            this.DEPARTMENT_CODE.Name = "DEPARTMENT_CODE";
            this.DEPARTMENT_CODE.ReadOnly = true;
            this.DEPARTMENT_CODE.Width = 220;
            // 
            // DEPARTMENT_NAME
            // 
            this.DEPARTMENT_NAME.DataPropertyName = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.HeaderText = "部门名称";
            this.DEPARTMENT_NAME.Name = "DEPARTMENT_NAME";
            this.DEPARTMENT_NAME.ReadOnly = true;
            this.DEPARTMENT_NAME.Width = 415;
            // 
            // DEPARTMENT_TYPE
            // 
            this.DEPARTMENT_TYPE.DataPropertyName = "DEPARTMENT_TYPE";
            this.DEPARTMENT_TYPE.HeaderText = "类型";
            this.DEPARTMENT_TYPE.Name = "DEPARTMENT_TYPE";
            this.DEPARTMENT_TYPE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "状态";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Visible = false;
            this.STATUS.Width = 115;
            // 
            // ASSEMBLY_LINE
            // 
            this.ASSEMBLY_LINE.DataPropertyName = "ASSEMBLY_LINE";
            this.ASSEMBLY_LINE.HeaderText = "装配线";
            this.ASSEMBLY_LINE.Name = "ASSEMBLY_LINE";
            this.ASSEMBLY_LINE.ReadOnly = true;
            this.ASSEMBLY_LINE.Width = 80;
            // 
            // STATUS_FALSE
            // 
            this.STATUS_FALSE.DataPropertyName = "STATUS_FALSE";
            this.STATUS_FALSE.HeaderText = "状态";
            this.STATUS_FALSE.Name = "STATUS_FALSE";
            this.STATUS_FALSE.ReadOnly = true;
            // 
            // frmDepartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cmbDEPARTMENT_TYPE);
            this.Controls.Add(this.txtDEPARTMENT_NAME);
            this.Controls.Add(this.txtDEPARTMENT_CODE);
            this.Controls.Add(this.page);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.chbSTATUS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDepartmentManage";
            this.Text = "部门维护";
            this.Activated += new System.EventHandler(this.frmDepartmentManage_Activated);
            this.Load += new System.EventHandler(this.frmDepartmentManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbSTATUS;
        private Control.DataGridViewEx dgv;
        private Control.PageSelect page;
        private System.Windows.Forms.TextBox txtDEPARTMENT_CODE;
        private System.Windows.Forms.TextBox txtDEPARTMENT_NAME;
        private System.Windows.Forms.ComboBox cmbDEPARTMENT_TYPE;
        private Control.ButtonEx btnExit;
        private Control.ButtonEx btnClear;
        private Control.ButtonEx btnQuery;
        private Control.ButtonEx btnUpate;
        private Control.ButtonEx btnDelete;
        private Control.ButtonEx btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSEMBLY_LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_FALSE;
    }
}