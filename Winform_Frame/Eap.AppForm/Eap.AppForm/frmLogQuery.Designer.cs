namespace Eap.AppForm
{
    partial class frmLogQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLogType = new System.Windows.Forms.Label();
            this.lblOperateNote = new System.Windows.Forms.Label();
            this.txtOperateNote = new System.Windows.Forms.TextBox();
            this.lblOperateUser = new System.Windows.Forms.Label();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.btnQuery = new Eap.Control.ButtonEx();
            this.dgv = new Eap.Control.DataGridViewEx();
            this.LOG_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOG_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOG_TYPE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATE_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATE_NOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page = new Eap.Control.PageSelect();
            this.txtOperateUser = new System.Windows.Forms.TextBox();
            this.cboLogType = new System.Windows.Forms.ComboBox();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogType
            // 
            this.lblLogType.AutoSize = true;
            this.lblLogType.Location = new System.Drawing.Point(42, 17);
            this.lblLogType.Name = "lblLogType";
            this.lblLogType.Size = new System.Drawing.Size(90, 21);
            this.lblLogType.TabIndex = 0;
            this.lblLogType.Text = "日志类型：";
            // 
            // lblOperateNote
            // 
            this.lblOperateNote.AutoSize = true;
            this.lblOperateNote.Location = new System.Drawing.Point(707, 16);
            this.lblOperateNote.Name = "lblOperateNote";
            this.lblOperateNote.Size = new System.Drawing.Size(90, 21);
            this.lblOperateNote.TabIndex = 4;
            this.lblOperateNote.Text = "操作内容：";
            // 
            // txtOperateNote
            // 
            this.txtOperateNote.Location = new System.Drawing.Point(799, 12);
            this.txtOperateNote.Name = "txtOperateNote";
            this.txtOperateNote.Size = new System.Drawing.Size(160, 29);
            this.txtOperateNote.TabIndex = 5;
            // 
            // lblOperateUser
            // 
            this.lblOperateUser.AutoSize = true;
            this.lblOperateUser.Location = new System.Drawing.Point(394, 16);
            this.lblOperateUser.Name = "lblOperateUser";
            this.lblOperateUser.Size = new System.Drawing.Size(74, 21);
            this.lblOperateUser.TabIndex = 2;
            this.lblOperateUser.Text = "操作人：";
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(42, 55);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(90, 21);
            this.lblBeginTime.TabIndex = 6;
            this.lblBeginTime.Text = "开始时间：";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(879, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 12;
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
            this.btnClear.Location = new System.Drawing.Point(470, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 11;
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
            this.btnQuery.Location = new System.Drawing.Point(61, 90);
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
            this.LOG_ID,
            this.LOG_TYPE,
            this.LOG_TYPE_NAME,
            this.OPERATE_USER,
            this.OPERATE_NOTE,
            this.OPERATE_TIME});
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
            this.dgv.Location = new System.Drawing.Point(8, 148);
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
            this.dgv.TabIndex = 13;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // LOG_ID
            // 
            this.LOG_ID.DataPropertyName = "LOG_ID";
            this.LOG_ID.HeaderText = "日志ID";
            this.LOG_ID.Name = "LOG_ID";
            this.LOG_ID.ReadOnly = true;
            this.LOG_ID.Width = 80;
            // 
            // LOG_TYPE
            // 
            this.LOG_TYPE.DataPropertyName = "LOG_TYPE";
            this.LOG_TYPE.HeaderText = "日志类型编号";
            this.LOG_TYPE.Name = "LOG_TYPE";
            this.LOG_TYPE.ReadOnly = true;
            this.LOG_TYPE.Visible = false;
            this.LOG_TYPE.Width = 80;
            // 
            // LOG_TYPE_NAME
            // 
            this.LOG_TYPE_NAME.DataPropertyName = "LOG_TYPE_NAME";
            this.LOG_TYPE_NAME.HeaderText = "日志类型";
            this.LOG_TYPE_NAME.Name = "LOG_TYPE_NAME";
            this.LOG_TYPE_NAME.ReadOnly = true;
            // 
            // OPERATE_USER
            // 
            this.OPERATE_USER.DataPropertyName = "OPERATE_USER";
            this.OPERATE_USER.HeaderText = "操作人";
            this.OPERATE_USER.Name = "OPERATE_USER";
            this.OPERATE_USER.ReadOnly = true;
            // 
            // OPERATE_NOTE
            // 
            this.OPERATE_NOTE.DataPropertyName = "OPERATE_NOTE";
            this.OPERATE_NOTE.HeaderText = "操作内容";
            this.OPERATE_NOTE.Name = "OPERATE_NOTE";
            this.OPERATE_NOTE.ReadOnly = true;
            this.OPERATE_NOTE.Width = 520;
            // 
            // OPERATE_TIME
            // 
            this.OPERATE_TIME.DataPropertyName = "OPERATE_TIME";
            this.OPERATE_TIME.HeaderText = "操作时间";
            this.OPERATE_TIME.Name = "OPERATE_TIME";
            this.OPERATE_TIME.ReadOnly = true;
            this.OPERATE_TIME.Width = 195;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
            this.page.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page.Location = new System.Drawing.Point(353, 647);
            this.page.Margin = new System.Windows.Forms.Padding(5);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(655, 50);
            this.page.TabIndex = 14;
            this.page.PageChange += new Eap.Control.PageSelect.PageSelected(this.page_PageChange);
            // 
            // txtOperateUser
            // 
            this.txtOperateUser.Location = new System.Drawing.Point(470, 12);
            this.txtOperateUser.MaxLength = 20;
            this.txtOperateUser.Name = "txtOperateUser";
            this.txtOperateUser.Size = new System.Drawing.Size(160, 29);
            this.txtOperateUser.TabIndex = 3;
            // 
            // cboLogType
            // 
            this.cboLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogType.FormattingEnabled = true;
            this.cboLogType.Location = new System.Drawing.Point(134, 13);
            this.cboLogType.Name = "cboLogType";
            this.cboLogType.Size = new System.Drawing.Size(160, 29);
            this.cboLogType.TabIndex = 1;
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Location = new System.Drawing.Point(134, 51);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(160, 29);
            this.dtpBeginTime.TabIndex = 7;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(378, 55);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(90, 21);
            this.lblEndTime.TabIndex = 8;
            this.lblEndTime.Text = "结束时间：";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(470, 51);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(160, 29);
            this.dtpEndTime.TabIndex = 9;
            // 
            // frmLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.cboLogType);
            this.Controls.Add(this.txtOperateUser);
            this.Controls.Add(this.page);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblBeginTime);
            this.Controls.Add(this.lblOperateUser);
            this.Controls.Add(this.txtOperateNote);
            this.Controls.Add(this.lblOperateNote);
            this.Controls.Add(this.lblLogType);
            this.Controls.Add(this.dtpBeginTime);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogQuery";
            this.Text = "日志查询";
            this.Load += new System.EventHandler(this.frmLogQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogType;
        private System.Windows.Forms.Label lblOperateNote;
        private System.Windows.Forms.TextBox txtOperateNote;
        private System.Windows.Forms.Label lblOperateUser;
        private System.Windows.Forms.Label lblBeginTime;
        private Eap.Control.ButtonEx btnExit;
        private Eap.Control.ButtonEx btnClear;
        private Eap.Control.ButtonEx btnQuery;
        private Eap.Control.DataGridViewEx dgv;
        private Eap.Control.PageSelect page;
        private System.Windows.Forms.TextBox txtOperateUser;
        private System.Windows.Forms.ComboBox cboLogType;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOG_TYPE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATE_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATE_NOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATE_TIME;
    }
}