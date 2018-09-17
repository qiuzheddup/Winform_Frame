namespace Eap.AppForm
{
    partial class frmValueListManageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValueListManageEdit));
            this.txtVListId = new System.Windows.Forms.TextBox();
            this.lblVListID = new System.Windows.Forms.Label();
            this.txtVListName = new System.Windows.Forms.TextBox();
            this.lblVListName = new System.Windows.Forms.Label();
            this.btnSave = new Eap.Control.ButtonEx();
            this.btnCancel = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // txtVListId
            // 
            this.txtVListId.Location = new System.Drawing.Point(367, 253);
            this.txtVListId.MaxLength = 20;
            this.txtVListId.Name = "txtVListId";
            this.txtVListId.Size = new System.Drawing.Size(390, 29);
            this.txtVListId.TabIndex = 1;
            // 
            // lblVListID
            // 
            this.lblVListID.AutoSize = true;
            this.lblVListID.Location = new System.Drawing.Point(274, 257);
            this.lblVListID.Name = "lblVListID";
            this.lblVListID.Size = new System.Drawing.Size(91, 21);
            this.lblVListID.TabIndex = 0;
            this.lblVListID.Text = "值列表ID：";
            // 
            // txtVListName
            // 
            this.txtVListName.Location = new System.Drawing.Point(367, 331);
            this.txtVListName.MaxLength = 20;
            this.txtVListName.Name = "txtVListName";
            this.txtVListName.Size = new System.Drawing.Size(390, 29);
            this.txtVListName.TabIndex = 3;
            // 
            // lblVListName
            // 
            this.lblVListName.AutoSize = true;
            this.lblVListName.Location = new System.Drawing.Point(259, 335);
            this.lblVListName.Name = "lblVListName";
            this.lblVListName.Size = new System.Drawing.Size(106, 21);
            this.lblVListName.TabIndex = 2;
            this.lblVListName.Text = "值列表名称：";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(367, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 50);
            this.btnSave.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(616, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmValueListManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVListId);
            this.Controls.Add(this.lblVListID);
            this.Controls.Add(this.txtVListName);
            this.Controls.Add(this.lblVListName);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmValueListManageEdit";
            this.Text = "值列表维护";
            this.Load += new System.EventHandler(this.frmValueListManageManageEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVListId;
        private System.Windows.Forms.Label lblVListID;
        private System.Windows.Forms.TextBox txtVListName;
        private System.Windows.Forms.Label lblVListName;
        private Eap.Control.ButtonEx btnSave;
        private Eap.Control.ButtonEx btnCancel;
    }
}