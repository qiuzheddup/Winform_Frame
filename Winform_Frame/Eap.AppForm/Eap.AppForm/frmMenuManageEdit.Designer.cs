namespace Eap.AppForm
{
    partial class frmMenuManageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuManageEdit));
            this.lblParentMenuId = new System.Windows.Forms.Label();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.txtMenuId = new System.Windows.Forms.TextBox();
            this.lblMenuId = new System.Windows.Forms.Label();
            this.txtParentMenuId = new System.Windows.Forms.TextBox();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.lblAssemblyName = new System.Windows.Forms.Label();
            this.btnSave = new Eap.Control.ButtonEx();
            this.btnCancel = new Eap.Control.ButtonEx();
            this.btnSelectParentMenuID = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // lblParentMenuId
            // 
            this.lblParentMenuId.AutoSize = true;
            this.lblParentMenuId.Location = new System.Drawing.Point(236, 243);
            this.lblParentMenuId.Name = "lblParentMenuId";
            this.lblParentMenuId.Size = new System.Drawing.Size(122, 21);
            this.lblParentMenuId.TabIndex = 8;
            this.lblParentMenuId.Text = "上级菜单编号：";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(360, 161);
            this.txtMenuName.MaxLength = 50;
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(390, 29);
            this.txtMenuName.TabIndex = 5;
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Location = new System.Drawing.Point(268, 165);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(90, 21);
            this.lblMenuName.TabIndex = 4;
            this.lblMenuName.Text = "菜单名称：";
            // 
            // txtMenuId
            // 
            this.txtMenuId.Location = new System.Drawing.Point(360, 83);
            this.txtMenuId.MaxLength = 20;
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.Size = new System.Drawing.Size(390, 29);
            this.txtMenuId.TabIndex = 1;
            // 
            // lblMenuId
            // 
            this.lblMenuId.AutoSize = true;
            this.lblMenuId.Location = new System.Drawing.Point(268, 87);
            this.lblMenuId.Name = "lblMenuId";
            this.lblMenuId.Size = new System.Drawing.Size(90, 21);
            this.lblMenuId.TabIndex = 0;
            this.lblMenuId.Text = "菜单编号：";
            // 
            // txtParentMenuId
            // 
            this.txtParentMenuId.Location = new System.Drawing.Point(360, 239);
            this.txtParentMenuId.MaxLength = 20;
            this.txtParentMenuId.Name = "txtParentMenuId";
            this.txtParentMenuId.ReadOnly = true;
            this.txtParentMenuId.Size = new System.Drawing.Size(341, 29);
            this.txtParentMenuId.TabIndex = 11;
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(360, 317);
            this.txtFormName.MaxLength = 50;
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(390, 29);
            this.txtFormName.TabIndex = 13;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Location = new System.Drawing.Point(268, 321);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(90, 21);
            this.lblFormName.TabIndex = 12;
            this.lblFormName.Text = "窗体名称：";
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Location = new System.Drawing.Point(360, 395);
            this.txtAssemblyName.MaxLength = 50;
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(390, 29);
            this.txtAssemblyName.TabIndex = 17;
            // 
            // lblAssemblyName
            // 
            this.lblAssemblyName.AutoSize = true;
            this.lblAssemblyName.Location = new System.Drawing.Point(252, 399);
            this.lblAssemblyName.Name = "lblAssemblyName";
            this.lblAssemblyName.Size = new System.Drawing.Size(106, 21);
            this.lblAssemblyName.TabIndex = 16;
            this.lblAssemblyName.Text = "程序集名称：";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(349, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 50);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(598, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 50);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectParentMenuID
            // 
            this.btnSelectParentMenuID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectParentMenuID.BackgroundImage")));
            this.btnSelectParentMenuID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectParentMenuID.FlatAppearance.BorderSize = 0;
            this.btnSelectParentMenuID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectParentMenuID.Location = new System.Drawing.Point(707, 239);
            this.btnSelectParentMenuID.Name = "btnSelectParentMenuID";
            this.btnSelectParentMenuID.Size = new System.Drawing.Size(43, 29);
            this.btnSelectParentMenuID.TabIndex = 22;
            this.btnSelectParentMenuID.Text = "......";
            this.btnSelectParentMenuID.UseVisualStyleBackColor = true;
            this.btnSelectParentMenuID.Click += new System.EventHandler(this.btnSelectParentMenuID_Click);
            // 
            // frmMenuManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.btnSelectParentMenuID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.lblAssemblyName);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.txtParentMenuId);
            this.Controls.Add(this.lblParentMenuId);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.lblMenuId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenuManageEdit";
            this.Text = "菜单维护";
            this.Load += new System.EventHandler(this.frmMenuManageEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParentMenuId;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.TextBox txtMenuId;
        private System.Windows.Forms.Label lblMenuId;
        private System.Windows.Forms.TextBox txtParentMenuId;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.Label lblAssemblyName;
        private Eap.Control.ButtonEx btnSave;
        private Eap.Control.ButtonEx btnCancel;
        private Control.ButtonEx btnSelectParentMenuID;
    }
}