namespace Eap.AppForm
{
    partial class frmValueListManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValueListManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVListId = new System.Windows.Forms.Label();
            this.txtVListId = new System.Windows.Forms.TextBox();
            this.lblVListName = new System.Windows.Forms.Label();
            this.txtVListName = new System.Windows.Forms.TextBox();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.btnDelVList = new Eap.Control.ButtonEx();
            this.btnEditVList = new Eap.Control.ButtonEx();
            this.btnAddVList = new Eap.Control.ButtonEx();
            this.btnQuery = new Eap.Control.ButtonEx();
            this.dgvVList = new Eap.Control.DataGridViewEx();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLIST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLIST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new Eap.Control.PageSelect();
            this.dgvVListDetail = new Eap.Control.DataGridViewEx();
            this.VLIST_DETAIL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLIST_DETAIL_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLIST_DETAIL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddVListDetail = new Eap.Control.ButtonEx();
            this.btnDelVListDetail = new Eap.Control.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVListDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVListId
            // 
            this.lblVListId.AutoSize = true;
            this.lblVListId.Location = new System.Drawing.Point(57, 18);
            this.lblVListId.Name = "lblVListId";
            this.lblVListId.Size = new System.Drawing.Size(91, 21);
            this.lblVListId.TabIndex = 0;
            this.lblVListId.Text = "值列表ID：";
            // 
            // txtVListId
            // 
            this.txtVListId.Location = new System.Drawing.Point(149, 14);
            this.txtVListId.MaxLength = 20;
            this.txtVListId.Name = "txtVListId";
            this.txtVListId.Size = new System.Drawing.Size(160, 29);
            this.txtVListId.TabIndex = 1;
            // 
            // lblVListName
            // 
            this.lblVListName.AutoSize = true;
            this.lblVListName.Location = new System.Drawing.Point(388, 18);
            this.lblVListName.Name = "lblVListName";
            this.lblVListName.Size = new System.Drawing.Size(106, 21);
            this.lblVListName.TabIndex = 2;
            this.lblVListName.Text = "值列表名称：";
            // 
            // txtVListName
            // 
            this.txtVListName.Location = new System.Drawing.Point(496, 14);
            this.txtVListName.MaxLength = 50;
            this.txtVListName.Name = "txtVListName";
            this.txtVListName.Size = new System.Drawing.Size(160, 29);
            this.txtVListName.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(913, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 6;
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
            this.btnClear.Location = new System.Drawing.Point(811, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelVList
            // 
            this.btnDelVList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelVList.BackgroundImage")));
            this.btnDelVList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelVList.FlatAppearance.BorderSize = 0;
            this.btnDelVList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelVList.ForeColor = System.Drawing.Color.White;
            this.btnDelVList.Location = new System.Drawing.Point(341, 25);
            this.btnDelVList.Name = "btnDelVList";
            this.btnDelVList.Size = new System.Drawing.Size(80, 50);
            this.btnDelVList.TabIndex = 2;
            this.btnDelVList.Text = "删除";
            this.btnDelVList.UseVisualStyleBackColor = true;
            this.btnDelVList.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEditVList
            // 
            this.btnEditVList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditVList.BackgroundImage")));
            this.btnEditVList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditVList.FlatAppearance.BorderSize = 0;
            this.btnEditVList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVList.ForeColor = System.Drawing.Color.White;
            this.btnEditVList.Location = new System.Drawing.Point(204, 25);
            this.btnEditVList.Name = "btnEditVList";
            this.btnEditVList.Size = new System.Drawing.Size(80, 50);
            this.btnEditVList.TabIndex = 1;
            this.btnEditVList.Text = "修改";
            this.btnEditVList.UseVisualStyleBackColor = true;
            this.btnEditVList.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddVList
            // 
            this.btnAddVList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVList.BackgroundImage")));
            this.btnAddVList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVList.FlatAppearance.BorderSize = 0;
            this.btnAddVList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVList.ForeColor = System.Drawing.Color.White;
            this.btnAddVList.Location = new System.Drawing.Point(67, 25);
            this.btnAddVList.Name = "btnAddVList";
            this.btnAddVList.Size = new System.Drawing.Size(80, 50);
            this.btnAddVList.TabIndex = 0;
            this.btnAddVList.Text = "新增";
            this.btnAddVList.UseVisualStyleBackColor = true;
            this.btnAddVList.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(701, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 50);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvVList
            // 
            this.dgvVList.AllowUserToAddRows = false;
            this.dgvVList.AllowUserToDeleteRows = false;
            this.dgvVList.AllowUserToOrderColumns = true;
            this.dgvVList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(147)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVList.ColumnHeadersHeight = 28;
            this.dgvVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.VLIST_ID,
            this.VLIST_NAME});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVList.EnableHeadersVisualStyles = false;
            this.dgvVList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.dgvVList.Location = new System.Drawing.Point(7, 89);
            this.dgvVList.MultiSelect = false;
            this.dgvVList.Name = "dgvVList";
            this.dgvVList.ReadOnly = true;
            this.dgvVList.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(70)))));
            this.dgvVList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVList.RowTemplate.Height = 23;
            this.dgvVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVList.Size = new System.Drawing.Size(475, 470);
            this.dgvVList.StandardTab = true;
            this.dgvVList.TabIndex = 3;
            this.dgvVList.DataSourceChanged += new System.EventHandler(this.dgvVList_DataSourceChanged);
            this.dgvVList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVList_CellClick);
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "序号";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 60;
            // 
            // VLIST_ID
            // 
            this.VLIST_ID.DataPropertyName = "VLIST_ID";
            this.VLIST_ID.HeaderText = "值列表ID";
            this.VLIST_ID.Name = "VLIST_ID";
            this.VLIST_ID.ReadOnly = true;
            this.VLIST_ID.Width = 150;
            // 
            // VLIST_NAME
            // 
            this.VLIST_NAME.DataPropertyName = "VLIST_NAME";
            this.VLIST_NAME.HeaderText = "值列表名称";
            this.VLIST_NAME.Name = "VLIST_NAME";
            this.VLIST_NAME.ReadOnly = true;
            this.VLIST_NAME.Width = 260;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.page.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page.Location = new System.Drawing.Point(353, 645);
            this.page.Margin = new System.Windows.Forms.Padding(5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(655, 50);
            this.page.TabIndex = 9;
            this.page.PageChange += new Eap.Control.PageSelect.PageSelected(this.page_PageChange);
            // 
            // dgvVListDetail
            // 
            this.dgvVListDetail.AllowUserToAddRows = false;
            this.dgvVListDetail.AllowUserToDeleteRows = false;
            this.dgvVListDetail.AllowUserToOrderColumns = true;
            this.dgvVListDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVListDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVListDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(147)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVListDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVListDetail.ColumnHeadersHeight = 28;
            this.dgvVListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVListDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VLIST_DETAIL_ID,
            this.VLIST_DETAIL_VALUE,
            this.VLIST_DETAIL_NAME});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(166)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVListDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVListDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVListDetail.EnableHeadersVisualStyles = false;
            this.dgvVListDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
            this.dgvVListDetail.Location = new System.Drawing.Point(6, 89);
            this.dgvVListDetail.MultiSelect = false;
            this.dgvVListDetail.Name = "dgvVListDetail";
            this.dgvVListDetail.ReadOnly = true;
            this.dgvVListDetail.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(196)))), ((int)(((byte)(70)))));
            this.dgvVListDetail.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVListDetail.RowTemplate.Height = 23;
            this.dgvVListDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVListDetail.Size = new System.Drawing.Size(486, 470);
            this.dgvVListDetail.StandardTab = true;
            this.dgvVListDetail.TabIndex = 2;
            // 
            // VLIST_DETAIL_ID
            // 
            this.VLIST_DETAIL_ID.DataPropertyName = "VLIST_DETAIL_ID";
            this.VLIST_DETAIL_ID.HeaderText = "值列表明细ID";
            this.VLIST_DETAIL_ID.Name = "VLIST_DETAIL_ID";
            this.VLIST_DETAIL_ID.ReadOnly = true;
            this.VLIST_DETAIL_ID.Visible = false;
            this.VLIST_DETAIL_ID.Width = 150;
            // 
            // VLIST_DETAIL_VALUE
            // 
            this.VLIST_DETAIL_VALUE.DataPropertyName = "VLIST_DETAIL_VALUE";
            this.VLIST_DETAIL_VALUE.HeaderText = "值列表明细值";
            this.VLIST_DETAIL_VALUE.Name = "VLIST_DETAIL_VALUE";
            this.VLIST_DETAIL_VALUE.ReadOnly = true;
            this.VLIST_DETAIL_VALUE.Width = 150;
            // 
            // VLIST_DETAIL_NAME
            // 
            this.VLIST_DETAIL_NAME.DataPropertyName = "VLIST_DETAIL_NAME";
            this.VLIST_DETAIL_NAME.HeaderText = "值列表明细名称";
            this.VLIST_DETAIL_NAME.Name = "VLIST_DETAIL_NAME";
            this.VLIST_DETAIL_NAME.ReadOnly = true;
            this.VLIST_DETAIL_NAME.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVList);
            this.groupBox1.Controls.Add(this.btnAddVList);
            this.groupBox1.Controls.Add(this.btnEditVList);
            this.groupBox1.Controls.Add(this.btnDelVList);
            this.groupBox1.Location = new System.Drawing.Point(4, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 571);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "值列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddVListDetail);
            this.groupBox2.Controls.Add(this.dgvVListDetail);
            this.groupBox2.Controls.Add(this.btnDelVListDetail);
            this.groupBox2.Location = new System.Drawing.Point(509, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 571);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "值列表明细";
            // 
            // btnAddVListDetail
            // 
            this.btnAddVListDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVListDetail.BackgroundImage")));
            this.btnAddVListDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVListDetail.FlatAppearance.BorderSize = 0;
            this.btnAddVListDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVListDetail.ForeColor = System.Drawing.Color.White;
            this.btnAddVListDetail.Location = new System.Drawing.Point(141, 25);
            this.btnAddVListDetail.Name = "btnAddVListDetail";
            this.btnAddVListDetail.Size = new System.Drawing.Size(80, 50);
            this.btnAddVListDetail.TabIndex = 0;
            this.btnAddVListDetail.Text = "新增";
            this.btnAddVListDetail.UseVisualStyleBackColor = true;
            this.btnAddVListDetail.Click += new System.EventHandler(this.btnAddVListDetail_Click);
            // 
            // btnDelVListDetail
            // 
            this.btnDelVListDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelVListDetail.BackgroundImage")));
            this.btnDelVListDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelVListDetail.FlatAppearance.BorderSize = 0;
            this.btnDelVListDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelVListDetail.ForeColor = System.Drawing.Color.White;
            this.btnDelVListDetail.Location = new System.Drawing.Point(281, 25);
            this.btnDelVListDetail.Name = "btnDelVListDetail";
            this.btnDelVListDetail.Size = new System.Drawing.Size(80, 50);
            this.btnDelVListDetail.TabIndex = 1;
            this.btnDelVListDetail.Text = "删除";
            this.btnDelVListDetail.UseVisualStyleBackColor = true;
            this.btnDelVListDetail.Click += new System.EventHandler(this.btnDelVListDetail_Click);
            // 
            // frmValueListManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtVListName);
            this.Controls.Add(this.lblVListName);
            this.Controls.Add(this.txtVListId);
            this.Controls.Add(this.lblVListId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmValueListManage";
            this.Text = "值列表维护";
            this.Activated += new System.EventHandler(this.frmValueListManageManage_Activated);
            this.Load += new System.EventHandler(this.frmValueListManageManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVListDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVListId;
        private System.Windows.Forms.TextBox txtVListId;
        private System.Windows.Forms.Label lblVListName;
        private System.Windows.Forms.TextBox txtVListName;
        private Eap.Control.ButtonEx btnExit;
        private Eap.Control.ButtonEx btnClear;
        private Eap.Control.ButtonEx btnDelVList;
        private Eap.Control.ButtonEx btnEditVList;
        private Eap.Control.ButtonEx btnAddVList;
        private Eap.Control.ButtonEx btnQuery;
        private Eap.Control.DataGridViewEx dgvVList;
        private Eap.Control.PageSelect page;
        private Control.DataGridViewEx dgvVListDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Control.ButtonEx btnAddVListDetail;
        private Control.ButtonEx btnDelVListDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIST_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIST_DETAIL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIST_DETAIL_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLIST_DETAIL_NAME;
    }
}