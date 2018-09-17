namespace Eap.AppForm
{
    partial class frmValueListDetailManageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValueListDetailManageEdit));
            this.lblVListDetailValue = new System.Windows.Forms.Label();
            this.txtVListId = new System.Windows.Forms.TextBox();
            this.lblVListId = new System.Windows.Forms.Label();
            this.txtVListDetailValue = new System.Windows.Forms.TextBox();
            this.txtVListDetailName = new System.Windows.Forms.TextBox();
            this.lblVListDetailName = new System.Windows.Forms.Label();
            this.btnSave = new Eap.Control.ButtonEx();
            this.btnCancel = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // lblVListDetailValue
            // 
            this.lblVListDetailValue.AutoSize = true;
            this.lblVListDetailValue.Location = new System.Drawing.Point(259, 297);
            this.lblVListDetailValue.Name = "lblVListDetailValue";
            this.lblVListDetailValue.Size = new System.Drawing.Size(122, 21);
            this.lblVListDetailValue.TabIndex = 2;
            this.lblVListDetailValue.Text = "值列表明细值：";
            // 
            // txtVListId
            // 
            this.txtVListId.Location = new System.Drawing.Point(383, 215);
            this.txtVListId.MaxLength = 20;
            this.txtVListId.Name = "txtVListId";
            this.txtVListId.Size = new System.Drawing.Size(390, 29);
            this.txtVListId.TabIndex = 1;
            // 
            // lblVListId
            // 
            this.lblVListId.AutoSize = true;
            this.lblVListId.Location = new System.Drawing.Point(290, 219);
            this.lblVListId.Name = "lblVListId";
            this.lblVListId.Size = new System.Drawing.Size(91, 21);
            this.lblVListId.TabIndex = 0;
            this.lblVListId.Text = "值列表ID：";
            // 
            // txtVListDetailValue
            // 
            this.txtVListDetailValue.Location = new System.Drawing.Point(383, 293);
            this.txtVListDetailValue.MaxLength = 10;
            this.txtVListDetailValue.Name = "txtVListDetailValue";
            this.txtVListDetailValue.Size = new System.Drawing.Size(390, 29);
            this.txtVListDetailValue.TabIndex = 3;
            // 
            // txtVListDetailName
            // 
            this.txtVListDetailName.Location = new System.Drawing.Point(383, 371);
            this.txtVListDetailName.MaxLength = 50;
            this.txtVListDetailName.Name = "txtVListDetailName";
            this.txtVListDetailName.Size = new System.Drawing.Size(390, 29);
            this.txtVListDetailName.TabIndex = 5;
            // 
            // lblVListDetailName
            // 
            this.lblVListDetailName.AutoSize = true;
            this.lblVListDetailName.Location = new System.Drawing.Point(243, 375);
            this.lblVListDetailName.Name = "lblVListDetailName";
            this.lblVListDetailName.Size = new System.Drawing.Size(138, 21);
            this.lblVListDetailName.TabIndex = 4;
            this.lblVListDetailName.Text = "值列表明细名称：";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(372, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 50);
            this.btnSave.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(621, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmValueListDetailManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVListDetailName);
            this.Controls.Add(this.lblVListDetailName);
            this.Controls.Add(this.txtVListDetailValue);
            this.Controls.Add(this.lblVListDetailValue);
            this.Controls.Add(this.txtVListId);
            this.Controls.Add(this.lblVListId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmValueListDetailManageEdit";
            this.Text = "值列表明细新增";
            this.Load += new System.EventHandler(this.frmValueListManageManageEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVListDetailValue;
        private System.Windows.Forms.TextBox txtVListId;
        private System.Windows.Forms.Label lblVListId;
        private System.Windows.Forms.TextBox txtVListDetailValue;
        private System.Windows.Forms.TextBox txtVListDetailName;
        private System.Windows.Forms.Label lblVListDetailName;
        private Eap.Control.ButtonEx btnSave;
        private Eap.Control.ButtonEx btnCancel;
    }
}