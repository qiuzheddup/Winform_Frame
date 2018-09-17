namespace Eap.AppForm
{
    partial class frmUserAuthorityEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAuthorityEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIsStop = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btNoneMenu = new Eap.Control.ButtonEx();
            this.btAllMune = new Eap.Control.ButtonEx();
            this.btnSaveMeun = new Eap.Control.ButtonEx();
            this.tvRightMenu = new System.Windows.Forms.TreeView();
            this.btnExit = new Eap.Control.ButtonEx();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btNoneButton = new Eap.Control.ButtonEx();
            this.buttonEx1 = new Eap.Control.ButtonEx();
            this.btnAllButton = new Eap.Control.ButtonEx();
            this.buttonEx2 = new Eap.Control.ButtonEx();
            this.btnSaveButton = new Eap.Control.ButtonEx();
            this.buttonEx3 = new Eap.Control.ButtonEx();
            this.buttonEx4 = new Eap.Control.ButtonEx();
            this.tvRightButton = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIsStop);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox1.Location = new System.Drawing.Point(9, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(863, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // txtIsStop
            // 
            this.txtIsStop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtIsStop.Location = new System.Drawing.Point(706, 21);
            this.txtIsStop.Margin = new System.Windows.Forms.Padding(5);
            this.txtIsStop.Name = "txtIsStop";
            this.txtIsStop.ReadOnly = true;
            this.txtIsStop.Size = new System.Drawing.Size(139, 29);
            this.txtIsStop.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtUserName.Location = new System.Drawing.Point(400, 21);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(229, 29);
            this.txtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(640, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "停用 ：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(318, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名 ：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtUserID.Location = new System.Drawing.Point(134, 21);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtUserID.MaxLength = 20;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(168, 29);
            this.txtUserID.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserID.Location = new System.Drawing.Point(32, 25);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(100, 21);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "用户编号  ：";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btNoneMenu);
            this.groupBox2.Controls.Add(this.btAllMune);
            this.groupBox2.Controls.Add(this.btnSaveMeun);
            this.groupBox2.Controls.Add(this.tvRightMenu);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(569, 601);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜单权限信息";
            // 
            // btNoneMenu
            // 
            this.btNoneMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNoneMenu.BackgroundImage")));
            this.btNoneMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNoneMenu.FlatAppearance.BorderSize = 0;
            this.btNoneMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNoneMenu.Location = new System.Drawing.Point(469, 247);
            this.btNoneMenu.Margin = new System.Windows.Forms.Padding(5);
            this.btNoneMenu.Name = "btNoneMenu";
            this.btNoneMenu.Size = new System.Drawing.Size(80, 50);
            this.btNoneMenu.TabIndex = 2;
            this.btNoneMenu.Text = "全清空";
            this.btNoneMenu.UseVisualStyleBackColor = true;
            this.btNoneMenu.Click += new System.EventHandler(this.btNone_Click);
            // 
            // btAllMune
            // 
            this.btAllMune.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAllMune.BackgroundImage")));
            this.btAllMune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAllMune.FlatAppearance.BorderSize = 0;
            this.btAllMune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAllMune.Location = new System.Drawing.Point(469, 177);
            this.btAllMune.Margin = new System.Windows.Forms.Padding(5);
            this.btAllMune.Name = "btAllMune";
            this.btAllMune.Size = new System.Drawing.Size(80, 50);
            this.btAllMune.TabIndex = 1;
            this.btAllMune.Text = "全选择";
            this.btAllMune.UseVisualStyleBackColor = true;
            this.btAllMune.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btnSaveMeun
            // 
            this.btnSaveMeun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveMeun.BackgroundImage")));
            this.btnSaveMeun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveMeun.FlatAppearance.BorderSize = 0;
            this.btnSaveMeun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMeun.Location = new System.Drawing.Point(469, 317);
            this.btnSaveMeun.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveMeun.Name = "btnSaveMeun";
            this.btnSaveMeun.Size = new System.Drawing.Size(80, 50);
            this.btnSaveMeun.TabIndex = 3;
            this.btnSaveMeun.Text = "保存";
            this.btnSaveMeun.UseVisualStyleBackColor = true;
            this.btnSaveMeun.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvRightMenu
            // 
            this.tvRightMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvRightMenu.CheckBoxes = true;
            this.tvRightMenu.Location = new System.Drawing.Point(10, 38);
            this.tvRightMenu.Margin = new System.Windows.Forms.Padding(5);
            this.tvRightMenu.Name = "tvRightMenu";
            this.tvRightMenu.Size = new System.Drawing.Size(449, 553);
            this.tvRightMenu.TabIndex = 0;
            this.tvRightMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRight_AfterCheck);
            this.tvRightMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRightMenu_AfterSelect);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(903, 35);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btNoneButton);
            this.groupBox3.Controls.Add(this.buttonEx1);
            this.groupBox3.Controls.Add(this.btnAllButton);
            this.groupBox3.Controls.Add(this.buttonEx2);
            this.groupBox3.Controls.Add(this.btnSaveButton);
            this.groupBox3.Controls.Add(this.buttonEx3);
            this.groupBox3.Controls.Add(this.buttonEx4);
            this.groupBox3.Controls.Add(this.tvRightButton);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox3.Location = new System.Drawing.Point(588, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(414, 601);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按钮权限信息";
            // 
            // btNoneButton
            // 
            this.btNoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNoneButton.BackgroundImage")));
            this.btNoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNoneButton.FlatAppearance.BorderSize = 0;
            this.btNoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNoneButton.Location = new System.Drawing.Point(303, 247);
            this.btNoneButton.Margin = new System.Windows.Forms.Padding(5);
            this.btNoneButton.Name = "btNoneButton";
            this.btNoneButton.Size = new System.Drawing.Size(80, 50);
            this.btNoneButton.TabIndex = 2;
            this.btNoneButton.Text = "全清空";
            this.btNoneButton.UseVisualStyleBackColor = true;
            this.btNoneButton.Click += new System.EventHandler(this.btNoneButton_Click);
            // 
            // buttonEx1
            // 
            this.buttonEx1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEx1.BackgroundImage")));
            this.buttonEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEx1.FlatAppearance.BorderSize = 0;
            this.buttonEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx1.Location = new System.Drawing.Point(469, 258);
            this.buttonEx1.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(80, 50);
            this.buttonEx1.TabIndex = 2;
            this.buttonEx1.Text = "全清空";
            this.buttonEx1.UseVisualStyleBackColor = true;
            // 
            // btnAllButton
            // 
            this.btnAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllButton.BackgroundImage")));
            this.btnAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllButton.FlatAppearance.BorderSize = 0;
            this.btnAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllButton.Location = new System.Drawing.Point(303, 177);
            this.btnAllButton.Margin = new System.Windows.Forms.Padding(5);
            this.btnAllButton.Name = "btnAllButton";
            this.btnAllButton.Size = new System.Drawing.Size(80, 50);
            this.btnAllButton.TabIndex = 1;
            this.btnAllButton.Text = "全选择";
            this.btnAllButton.UseVisualStyleBackColor = true;
            this.btnAllButton.Click += new System.EventHandler(this.btnAllButton_Click);
            // 
            // buttonEx2
            // 
            this.buttonEx2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEx2.BackgroundImage")));
            this.buttonEx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEx2.FlatAppearance.BorderSize = 0;
            this.buttonEx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx2.Location = new System.Drawing.Point(469, 177);
            this.buttonEx2.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(80, 50);
            this.buttonEx2.TabIndex = 1;
            this.buttonEx2.Text = "全选择";
            this.buttonEx2.UseVisualStyleBackColor = true;
            // 
            // btnSaveButton
            // 
            this.btnSaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveButton.BackgroundImage")));
            this.btnSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveButton.FlatAppearance.BorderSize = 0;
            this.btnSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveButton.Location = new System.Drawing.Point(303, 317);
            this.btnSaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveButton.Name = "btnSaveButton";
            this.btnSaveButton.Size = new System.Drawing.Size(80, 50);
            this.btnSaveButton.TabIndex = 3;
            this.btnSaveButton.Text = "保存";
            this.btnSaveButton.UseVisualStyleBackColor = true;
            this.btnSaveButton.Click += new System.EventHandler(this.btnSaveButton_Click);
            // 
            // buttonEx3
            // 
            this.buttonEx3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEx3.BackgroundImage")));
            this.buttonEx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEx3.FlatAppearance.BorderSize = 0;
            this.buttonEx3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx3.Location = new System.Drawing.Point(469, 503);
            this.buttonEx3.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEx3.Name = "buttonEx3";
            this.buttonEx3.Size = new System.Drawing.Size(80, 50);
            this.buttonEx3.TabIndex = 4;
            this.buttonEx3.Text = "取消";
            this.buttonEx3.UseVisualStyleBackColor = true;
            // 
            // buttonEx4
            // 
            this.buttonEx4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEx4.BackgroundImage")));
            this.buttonEx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEx4.FlatAppearance.BorderSize = 0;
            this.buttonEx4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx4.Location = new System.Drawing.Point(469, 422);
            this.buttonEx4.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEx4.Name = "buttonEx4";
            this.buttonEx4.Size = new System.Drawing.Size(80, 50);
            this.buttonEx4.TabIndex = 3;
            this.buttonEx4.Text = "保存";
            this.buttonEx4.UseVisualStyleBackColor = true;
            // 
            // tvRightButton
            // 
            this.tvRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvRightButton.CheckBoxes = true;
            this.tvRightButton.Location = new System.Drawing.Point(10, 38);
            this.tvRightButton.Margin = new System.Windows.Forms.Padding(5);
            this.tvRightButton.Name = "tvRightButton";
            this.tvRightButton.Size = new System.Drawing.Size(283, 553);
            this.tvRightButton.TabIndex = 0;
            this.tvRightButton.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvRightButton_AfterCheck);
            // 
            // frmUserAuthorityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserAuthorityEdit";
            this.Text = "用户权限维护";
            this.Load += new System.EventHandler(this.frmUserAuthorityEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvRightMenu;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtIsStop;
        private Control.ButtonEx btNoneMenu;
        private Control.ButtonEx btAllMune;
        private Control.ButtonEx btnExit;
        private Control.ButtonEx btnSaveMeun;
        private System.Windows.Forms.GroupBox groupBox3;
        private Control.ButtonEx btNoneButton;
        private Control.ButtonEx buttonEx1;
        private Control.ButtonEx btnAllButton;
        private Control.ButtonEx buttonEx2;
        private Control.ButtonEx btnSaveButton;
        private Control.ButtonEx buttonEx3;
        private Control.ButtonEx buttonEx4;
        private System.Windows.Forms.TreeView tvRightButton;
    }
}