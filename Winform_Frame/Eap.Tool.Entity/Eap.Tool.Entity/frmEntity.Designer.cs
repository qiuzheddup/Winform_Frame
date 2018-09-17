namespace Eap.Tool.Entity
{
    partial class frmEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntity));
            this.lblDbType = new System.Windows.Forms.Label();
            this.radOracle = new System.Windows.Forms.RadioButton();
            this.radSqlserver = new System.Windows.Forms.RadioButton();
            this.radAccess = new System.Windows.Forms.RadioButton();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.btnCreateEntity = new Eap.Control.ButtonEx();
            this.btnExit = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // lblDbType
            // 
            this.lblDbType.AutoSize = true;
            this.lblDbType.Location = new System.Drawing.Point(228, 90);
            this.lblDbType.Name = "lblDbType";
            this.lblDbType.Size = new System.Drawing.Size(106, 21);
            this.lblDbType.TabIndex = 0;
            this.lblDbType.Text = "数据库类型：";
            // 
            // radOracle
            // 
            this.radOracle.AutoSize = true;
            this.radOracle.Location = new System.Drawing.Point(336, 88);
            this.radOracle.Name = "radOracle";
            this.radOracle.Size = new System.Drawing.Size(77, 25);
            this.radOracle.TabIndex = 1;
            this.radOracle.TabStop = true;
            this.radOracle.Text = "Oracle";
            this.radOracle.UseVisualStyleBackColor = true;
            // 
            // radSqlserver
            // 
            this.radSqlserver.AutoSize = true;
            this.radSqlserver.Enabled = false;
            this.radSqlserver.Location = new System.Drawing.Point(441, 88);
            this.radSqlserver.Name = "radSqlserver";
            this.radSqlserver.Size = new System.Drawing.Size(96, 25);
            this.radSqlserver.TabIndex = 2;
            this.radSqlserver.TabStop = true;
            this.radSqlserver.Text = "Sqlserver";
            this.radSqlserver.UseVisualStyleBackColor = true;
            // 
            // radAccess
            // 
            this.radAccess.AutoSize = true;
            this.radAccess.Enabled = false;
            this.radAccess.Location = new System.Drawing.Point(565, 88);
            this.radAccess.Name = "radAccess";
            this.radAccess.Size = new System.Drawing.Size(78, 25);
            this.radAccess.TabIndex = 3;
            this.radAccess.TabStop = true;
            this.radAccess.Text = "Access";
            this.radAccess.UseVisualStyleBackColor = true;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(260, 146);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(74, 21);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "服务器：";
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(336, 142);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(200, 29);
            this.txtServer.TabIndex = 5;
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Location = new System.Drawing.Point(244, 202);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(90, 21);
            this.lblDbName.TabIndex = 6;
            this.lblDbName.Text = "数据库名：";
            // 
            // txtDbName
            // 
            this.txtDbName.Enabled = false;
            this.txtDbName.Location = new System.Drawing.Point(336, 198);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(200, 29);
            this.txtDbName.TabIndex = 7;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(260, 258);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(74, 21);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "用户名：";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(336, 254);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 29);
            this.txtUserId.TabIndex = 9;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(276, 314);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(58, 21);
            this.lblPwd.TabIndex = 10;
            this.lblPwd.Text = "密码：";
            // 
            // txtPwd
            // 
            this.txtPwd.Enabled = false;
            this.txtPwd.Location = new System.Drawing.Point(336, 310);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(200, 29);
            this.txtPwd.TabIndex = 11;
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(244, 370);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(90, 21);
            this.lblNameSpace.TabIndex = 12;
            this.lblNameSpace.Text = "命名空间：";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Enabled = false;
            this.txtNameSpace.Location = new System.Drawing.Point(336, 366);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(200, 29);
            this.txtNameSpace.TabIndex = 13;
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateEntity.BackgroundImage")));
            this.btnCreateEntity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateEntity.FlatAppearance.BorderSize = 0;
            this.btnCreateEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEntity.Location = new System.Drawing.Point(248, 468);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(80, 50);
            this.btnCreateEntity.TabIndex = 14;
            this.btnCreateEntity.Text = "创建实体类";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(457, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateEntity);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.lblNameSpace);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.lblDbName);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.radAccess);
            this.Controls.Add(this.radSqlserver);
            this.Controls.Add(this.radOracle);
            this.Controls.Add(this.lblDbType);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成工具";
            this.Load += new System.EventHandler(this.frmEntity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDbType;
        private System.Windows.Forms.RadioButton radOracle;
        private System.Windows.Forms.RadioButton radSqlserver;
        private System.Windows.Forms.RadioButton radAccess;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblNameSpace;
        private System.Windows.Forms.TextBox txtNameSpace;
        private Control.ButtonEx btnCreateEntity;
        private Control.ButtonEx btnExit;
    }
}