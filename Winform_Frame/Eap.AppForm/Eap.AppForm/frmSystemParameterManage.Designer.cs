namespace Eap.AppForm
{
    partial class frmSystemParameterManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemParameterManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblParaId = new System.Windows.Forms.Label();
            this.txtParaId = new System.Windows.Forms.TextBox();
            this.lblParaName = new System.Windows.Forms.Label();
            this.txtParaName = new System.Windows.Forms.TextBox();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.btnDel = new Eap.Control.ButtonEx();
            this.btnEdit = new Eap.Control.ButtonEx();
            this.btnAdd = new Eap.Control.ButtonEx();
            this.btnQuery = new Eap.Control.ButtonEx();
            this.dgv = new Eap.Control.DataGridViewEx();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARA_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new Eap.Control.PageSelect();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParaId
            // 
            this.lblParaId.AutoSize = true;
            this.lblParaId.Location = new System.Drawing.Point(72, 21);
            this.lblParaId.Name = "lblParaId";
            this.lblParaId.Size = new System.Drawing.Size(75, 21);
            this.lblParaId.TabIndex = 0;
            this.lblParaId.Text = "参数ID：";
            // 
            // txtParaId
            // 
            this.txtParaId.Location = new System.Drawing.Point(149, 17);
            this.txtParaId.MaxLength = 20;
            this.txtParaId.Name = "txtParaId";
            this.txtParaId.Size = new System.Drawing.Size(160, 29);
            this.txtParaId.TabIndex = 1;
            // 
            // lblParaName
            // 
            this.lblParaName.AutoSize = true;
            this.lblParaName.Location = new System.Drawing.Point(380, 21);
            this.lblParaName.Name = "lblParaName";
            this.lblParaName.Size = new System.Drawing.Size(90, 21);
            this.lblParaName.TabIndex = 2;
            this.lblParaName.Text = "参数名称：";
            // 
            // txtParaName
            // 
            this.txtParaName.Location = new System.Drawing.Point(472, 17);
            this.txtParaName.MaxLength = 20;
            this.txtParaName.Name = "txtParaName";
            this.txtParaName.Size = new System.Drawing.Size(160, 29);
            this.txtParaName.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(878, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 15;
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
            this.btnClear.Location = new System.Drawing.Point(715, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(552, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 50);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(389, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 50);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(226, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(63, 68);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 50);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(147)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 28;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.PARA_ID,
            this.PARA_NAME,
            this.PARA_VALUE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.dgv.Location = new System.Drawing.Point(8, 136);
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
            this.dgv.TabIndex = 16;
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "序号";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 90;
            // 
            // PARA_ID
            // 
            this.PARA_ID.DataPropertyName = "PARA_ID";
            this.PARA_ID.HeaderText = "参数ID";
            this.PARA_ID.Name = "PARA_ID";
            this.PARA_ID.ReadOnly = true;
            this.PARA_ID.Width = 207;
            // 
            // PARA_NAME
            // 
            this.PARA_NAME.DataPropertyName = "PARA_NAME";
            this.PARA_NAME.HeaderText = "参数名称";
            this.PARA_NAME.Name = "PARA_NAME";
            this.PARA_NAME.ReadOnly = true;
            this.PARA_NAME.Width = 350;
            // 
            // PARA_VALUE
            // 
            this.PARA_VALUE.DataPropertyName = "PARA_VALUE";
            this.PARA_VALUE.HeaderText = "参数值";
            this.PARA_VALUE.Name = "PARA_VALUE";
            this.PARA_VALUE.ReadOnly = true;
            this.PARA_VALUE.Width = 350;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.page.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page.Location = new System.Drawing.Point(353, 640);
            this.page.Margin = new System.Windows.Forms.Padding(5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(655, 50);
            this.page.TabIndex = 17;
            this.page.PageChange += new Eap.Control.PageSelect.PageSelected(this.page_PageChange);
            // 
            // frmSystemParameterManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.page);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtParaName);
            this.Controls.Add(this.lblParaName);
            this.Controls.Add(this.txtParaId);
            this.Controls.Add(this.lblParaId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSystemParameterManage";
            this.Text = "系统参数维护";
            this.Activated += new System.EventHandler(this.frmSystemParameManage_Activated);
            this.Load += new System.EventHandler(this.frmSystemParameManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaId;
        private System.Windows.Forms.TextBox txtParaId;
        private System.Windows.Forms.Label lblParaName;
        private System.Windows.Forms.TextBox txtParaName;
        private Eap.Control.ButtonEx btnExit;
        private Eap.Control.ButtonEx btnClear;
        private Eap.Control.ButtonEx btnDel;
        private Eap.Control.ButtonEx btnEdit;
        private Eap.Control.ButtonEx btnAdd;
        private Eap.Control.ButtonEx btnQuery;
        private Eap.Control.DataGridViewEx dgv;
        private Eap.Control.PageSelect page;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARA_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARA_VALUE;
    }
}