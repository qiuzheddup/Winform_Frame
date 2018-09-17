namespace Eap.AppForm
{
    partial class frmMenuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMenuId = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.lblParentMenuId = new System.Windows.Forms.Label();
            this.txtParentMenuId = new System.Windows.Forms.TextBox();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.btnDel = new Eap.Control.ButtonEx();
            this.btnEdit = new Eap.Control.ButtonEx();
            this.btnAdd = new Eap.Control.ButtonEx();
            this.btnQuery = new Eap.Control.ButtonEx();
            this.dgv = new Eap.Control.DataGridViewEx();
            this.MENU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENU_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARENT_MENU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSEMBLY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new Eap.Control.PageSelect();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuId
            // 
            this.lblMenuId.AutoSize = true;
            this.lblMenuId.Location = new System.Drawing.Point(57, 28);
            this.lblMenuId.Name = "lblMenuId";
            this.lblMenuId.Size = new System.Drawing.Size(90, 21);
            this.lblMenuId.TabIndex = 0;
            this.lblMenuId.Text = "菜单编码：";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(149, 24);
            this.txtMenuId.MaxLength = 20;
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(160, 29);
            this.txtMenuId.TabIndex = 1;
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Location = new System.Drawing.Point(380, 28);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(90, 21);
            this.lblMenuName.TabIndex = 2;
            this.lblMenuName.Text = "菜单名称：";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(472, 24);
            this.txtMenuName.MaxLength = 50;
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(160, 29);
            this.txtMenuName.TabIndex = 3;
            // 
            // lblParentMenuId
            // 
            this.lblParentMenuId.AutoSize = true;
            this.lblParentMenuId.Location = new System.Drawing.Point(676, 28);
            this.lblParentMenuId.Name = "lblParentMenuId";
            this.lblParentMenuId.Size = new System.Drawing.Size(122, 21);
            this.lblParentMenuId.TabIndex = 4;
            this.lblParentMenuId.Text = "上级菜单编码：";
            // 
            // txtParentMenuId
            // 
            this.txtParentMenuId.Location = new System.Drawing.Point(800, 24);
            this.txtParentMenuId.MaxLength = 20;
            this.txtParentMenuId.Name = "txtParentMenuId";
            this.txtParentMenuId.Size = new System.Drawing.Size(160, 29);
            this.txtParentMenuId.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(878, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 11;
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
            this.btnClear.Location = new System.Drawing.Point(715, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 10;
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
            this.btnDel.Location = new System.Drawing.Point(552, 74);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 50);
            this.btnDel.TabIndex = 9;
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
            this.btnEdit.Location = new System.Drawing.Point(389, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 50);
            this.btnEdit.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(226, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 50);
            this.btnAdd.TabIndex = 7;
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
            this.btnQuery.Location = new System.Drawing.Point(63, 74);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 50);
            this.btnQuery.TabIndex = 6;
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
            this.MENU_ID,
            this.MENU_NAME,
            this.PARENT_MENU_ID,
            this.FORM_NAME,
            this.ASSEMBLY_NAME});
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
            this.dgv.Location = new System.Drawing.Point(8, 144);
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
            this.dgv.TabIndex = 12;
            // 
            // MENU_ID
            // 
            this.MENU_ID.DataPropertyName = "MENU_ID";
            this.MENU_ID.HeaderText = "菜单ID";
            this.MENU_ID.Name = "MENU_ID";
            this.MENU_ID.ReadOnly = true;
            this.MENU_ID.Width = 80;
            // 
            // MENU_NAME
            // 
            this.MENU_NAME.DataPropertyName = "MENU_NAME";
            this.MENU_NAME.HeaderText = "菜单名称";
            this.MENU_NAME.Name = "MENU_NAME";
            this.MENU_NAME.ReadOnly = true;
            this.MENU_NAME.Width = 260;
            // 
            // PARENT_MENU_ID
            // 
            this.PARENT_MENU_ID.DataPropertyName = "PARENT_MENU_ID";
            this.PARENT_MENU_ID.HeaderText = "上级菜单ID";
            this.PARENT_MENU_ID.Name = "PARENT_MENU_ID";
            this.PARENT_MENU_ID.ReadOnly = true;
            this.PARENT_MENU_ID.Width = 105;
            // 
            // FORM_NAME
            // 
            this.FORM_NAME.DataPropertyName = "FORM_NAME";
            this.FORM_NAME.HeaderText = "窗体名称";
            this.FORM_NAME.Name = "FORM_NAME";
            this.FORM_NAME.ReadOnly = true;
            this.FORM_NAME.Width = 357;
            // 
            // ASSEMBLY_NAME
            // 
            this.ASSEMBLY_NAME.DataPropertyName = "ASSEMBLY_NAME";
            this.ASSEMBLY_NAME.HeaderText = "程序集名称";
            this.ASSEMBLY_NAME.Name = "ASSEMBLY_NAME";
            this.ASSEMBLY_NAME.ReadOnly = true;
            this.ASSEMBLY_NAME.Width = 195;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.page.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page.Location = new System.Drawing.Point(353, 645);
            this.page.Margin = new System.Windows.Forms.Padding(5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(655, 50);
            this.page.TabIndex = 13;
            this.page.PageChange += new Eap.Control.PageSelect.PageSelected(this.page_PageChange);
            // 
            // frmMenuManage
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
            this.Controls.Add(this.txtParentMenuId);
            this.Controls.Add(this.lblParentMenuId);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.lblMenuId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenuManage";
            this.Text = "菜单维护";
            this.Activated += new System.EventHandler(this.frmMenuManage_Activated);
            this.Load += new System.EventHandler(this.frmMenuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuId;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label lblParentMenuId;
        private System.Windows.Forms.TextBox txtParentMenuId;
        private Eap.Control.ButtonEx btnExit;
        private Eap.Control.ButtonEx btnClear;
        private Eap.Control.ButtonEx btnDel;
        private Eap.Control.ButtonEx btnEdit;
        private Eap.Control.ButtonEx btnAdd;
        private Eap.Control.ButtonEx btnQuery;
        private Eap.Control.DataGridViewEx dgv;
        private Eap.Control.PageSelect page;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENU_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARENT_MENU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSEMBLY_NAME;
    }
}