namespace Eap.AppForm
{
    partial class frmUserManageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManageEdit));
            this.btnSave = new Eap.Control.ButtonEx();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancle = new Eap.Control.ButtonEx();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboIsStop = new System.Windows.Forms.ComboBox();
            this.btnResetPwd = new Eap.Control.ButtonEx();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Assembly_Line = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(305, 495);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserID.Location = new System.Drawing.Point(346, 173);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(100, 21);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "用户编号  ：";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(448, 169);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserID.MaxLength = 20;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(190, 29);
            this.txtUserID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名 ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "停用 ：";
            // 
            // btnCancle
            // 
            this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(623, 495);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 50);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(448, 264);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(190, 29);
            this.txtUserName.TabIndex = 3;
            // 
            // cboIsStop
            // 
            this.cboIsStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIsStop.FormattingEnabled = true;
            this.cboIsStop.Location = new System.Drawing.Point(448, 359);
            this.cboIsStop.Margin = new System.Windows.Forms.Padding(5);
            this.cboIsStop.Name = "cboIsStop";
            this.cboIsStop.Size = new System.Drawing.Size(190, 29);
            this.cboIsStop.TabIndex = 5;
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPwd.BackgroundImage")));
            this.btnResetPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetPwd.FlatAppearance.BorderSize = 0;
            this.btnResetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPwd.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.Location = new System.Drawing.Point(464, 495);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(80, 50);
            this.btnResetPwd.TabIndex = 7;
            this.btnResetPwd.Tag = "admin";
            this.btnResetPwd.Text = "重置密码";
            this.btnResetPwd.UseVisualStyleBackColor = true;
            this.btnResetPwd.Visible = false;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 437);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "总装生产线权限 ：";
            // 
            // chk_Assembly_Line
            // 
            this.chk_Assembly_Line.FormattingEnabled = true;
            this.chk_Assembly_Line.Location = new System.Drawing.Point(448, 434);
            this.chk_Assembly_Line.MultiColumn = true;
            this.chk_Assembly_Line.Name = "chk_Assembly_Line";
            this.chk_Assembly_Line.Size = new System.Drawing.Size(368, 28);
            this.chk_Assembly_Line.TabIndex = 10;
            // 
            // frmUserManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.chk_Assembly_Line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetPwd);
            this.Controls.Add(this.cboIsStop);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUserManageEdit";
            this.Text = "用户维护";
            this.Load += new System.EventHandler(this.frmUserManageEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ButtonEx btnSave;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Control.ButtonEx btnCancle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cboIsStop;
        private Control.ButtonEx btnResetPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chk_Assembly_Line;
    }
}