namespace Eap.AppForm
{
    partial class frmServerProcessStatusQuery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerProcessStatusQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnRefresh = new Eap.Control.ButtonEx();
            this.timRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblRefreshTimeout = new System.Windows.Forms.Label();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.PROCESS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVER_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVER_FLAG_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCESS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFRESH_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCESS_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCESS_STATUS_IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.PROCESS_SOCKET_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCESS_SOCKET_STATUS_IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(853, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(733, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 50);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timRefresh
            // 
            this.timRefresh.Interval = 5000;
            this.timRefresh.Tick += new System.EventHandler(this.timRefresh_Tick);
            // 
            // lblRefreshTimeout
            // 
            this.lblRefreshTimeout.BackColor = System.Drawing.Color.Lime;
            this.lblRefreshTimeout.Location = new System.Drawing.Point(81, 78);
            this.lblRefreshTimeout.Name = "lblRefreshTimeout";
            this.lblRefreshTimeout.Size = new System.Drawing.Size(314, 21);
            this.lblRefreshTimeout.TabIndex = 26;
            this.lblRefreshTimeout.Text = "进程刷新超时时间：";
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.BackColor = System.Drawing.Color.Lime;
            this.lblSystemTime.Location = new System.Drawing.Point(81, 57);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(314, 21);
            this.lblSystemTime.TabIndex = 27;
            this.lblSystemTime.Text = "当前系统时间：";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 30;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROCESS_ID,
            this.SERVER_FLAG,
            this.SERVER_FLAG_NAME,
            this.PROCESS_NAME,
            this.REFRESH_DATE,
            this.PROCESS_STATUS,
            this.PROCESS_STATUS_IMAGE,
            this.PROCESS_SOCKET_STATUS,
            this.PROCESS_SOCKET_STATUS_IMAGE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.Black;
            this.dgv.Location = new System.Drawing.Point(12, 107);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.ShowCellErrors = false;
            this.dgv.Size = new System.Drawing.Size(992, 585);
            this.dgv.TabIndex = 28;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // PROCESS_ID
            // 
            this.PROCESS_ID.DataPropertyName = "PROCESS_ID";
            this.PROCESS_ID.FillWeight = 183.3509F;
            this.PROCESS_ID.HeaderText = "进程ID";
            this.PROCESS_ID.Name = "PROCESS_ID";
            this.PROCESS_ID.ReadOnly = true;
            this.PROCESS_ID.Width = 300;
            // 
            // SERVER_FLAG
            // 
            this.SERVER_FLAG.DataPropertyName = "SERVER_FLAG";
            this.SERVER_FLAG.FillWeight = 52.92493F;
            this.SERVER_FLAG.HeaderText = "服务标识";
            this.SERVER_FLAG.Name = "SERVER_FLAG";
            this.SERVER_FLAG.ReadOnly = true;
            this.SERVER_FLAG.Visible = false;
            this.SERVER_FLAG.Width = 95;
            // 
            // SERVER_FLAG_NAME
            // 
            this.SERVER_FLAG_NAME.DataPropertyName = "SERVER_FLAG_NAME";
            this.SERVER_FLAG_NAME.HeaderText = "服务标识";
            this.SERVER_FLAG_NAME.Name = "SERVER_FLAG_NAME";
            this.SERVER_FLAG_NAME.ReadOnly = true;
            this.SERVER_FLAG_NAME.Width = 95;
            // 
            // PROCESS_NAME
            // 
            this.PROCESS_NAME.DataPropertyName = "PROCESS_NAME";
            this.PROCESS_NAME.FillWeight = 99.04106F;
            this.PROCESS_NAME.HeaderText = "进程名称";
            this.PROCESS_NAME.Name = "PROCESS_NAME";
            this.PROCESS_NAME.ReadOnly = true;
            this.PROCESS_NAME.Width = 175;
            // 
            // REFRESH_DATE
            // 
            this.REFRESH_DATE.DataPropertyName = "REFRESH_DATE";
            this.REFRESH_DATE.FillWeight = 102.2866F;
            this.REFRESH_DATE.HeaderText = "最后刷新时间";
            this.REFRESH_DATE.Name = "REFRESH_DATE";
            this.REFRESH_DATE.ReadOnly = true;
            this.REFRESH_DATE.Width = 180;
            // 
            // PROCESS_STATUS
            // 
            this.PROCESS_STATUS.DataPropertyName = "PROCESS_STATUS";
            this.PROCESS_STATUS.HeaderText = "进程状态";
            this.PROCESS_STATUS.Name = "PROCESS_STATUS";
            this.PROCESS_STATUS.ReadOnly = true;
            this.PROCESS_STATUS.Visible = false;
            // 
            // PROCESS_STATUS_IMAGE
            // 
            this.PROCESS_STATUS_IMAGE.HeaderText = "进程状态";
            this.PROCESS_STATUS_IMAGE.Name = "PROCESS_STATUS_IMAGE";
            this.PROCESS_STATUS_IMAGE.ReadOnly = true;
            this.PROCESS_STATUS_IMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PROCESS_STATUS_IMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PROCESS_STATUS_IMAGE.Width = 110;
            // 
            // PROCESS_SOCKET_STATUS
            // 
            this.PROCESS_SOCKET_STATUS.DataPropertyName = "PROCESS_SOCKET_STATUS";
            this.PROCESS_SOCKET_STATUS.HeaderText = "通讯状态";
            this.PROCESS_SOCKET_STATUS.Name = "PROCESS_SOCKET_STATUS";
            this.PROCESS_SOCKET_STATUS.ReadOnly = true;
            this.PROCESS_SOCKET_STATUS.Visible = false;
            // 
            // PROCESS_SOCKET_STATUS_IMAGE
            // 
            this.PROCESS_SOCKET_STATUS_IMAGE.HeaderText = "通讯状态";
            this.PROCESS_SOCKET_STATUS_IMAGE.Name = "PROCESS_SOCKET_STATUS_IMAGE";
            this.PROCESS_SOCKET_STATUS_IMAGE.ReadOnly = true;
            this.PROCESS_SOCKET_STATUS_IMAGE.Width = 110;
            // 
            // frmServerProcessStatusQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.lblRefreshTimeout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmServerProcessStatusQuery";
            this.Text = "服务器进程状态查询";
            this.Load += new System.EventHandler(this.frmServerProcessStatusQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ButtonEx btnExit;
        private Control.ButtonEx btnRefresh;
        private System.Windows.Forms.Timer timRefresh;
        private System.Windows.Forms.Label lblRefreshTimeout;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCESS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVER_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVER_FLAG_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCESS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFRESH_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCESS_STATUS;
        private System.Windows.Forms.DataGridViewImageColumn PROCESS_STATUS_IMAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCESS_SOCKET_STATUS;
        private System.Windows.Forms.DataGridViewImageColumn PROCESS_SOCKET_STATUS_IMAGE;
    }
}