namespace Eap.AppForm
{
    partial class frmSystemParameterManageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemParameterManageEdit));
            this.lblParaValue = new System.Windows.Forms.Label();
            this.txtParaName = new System.Windows.Forms.TextBox();
            this.lblParaName = new System.Windows.Forms.Label();
            this.txtParaId = new System.Windows.Forms.TextBox();
            this.lblParaId = new System.Windows.Forms.Label();
            this.txtParaValue = new System.Windows.Forms.TextBox();
            this.btnSave = new Eap.Control.ButtonEx();
            this.btnCancel = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // lblParaValue
            // 
            this.lblParaValue.AutoSize = true;
            this.lblParaValue.Location = new System.Drawing.Point(283, 376);
            this.lblParaValue.Name = "lblParaValue";
            this.lblParaValue.Size = new System.Drawing.Size(74, 21);
            this.lblParaValue.TabIndex = 4;
            this.lblParaValue.Text = "参数值：";
            // 
            // txtParaName
            // 
            this.txtParaName.Location = new System.Drawing.Point(359, 294);
            this.txtParaName.MaxLength = 30;
            this.txtParaName.Name = "txtParaName";
            this.txtParaName.Size = new System.Drawing.Size(390, 29);
            this.txtParaName.TabIndex = 3;
            // 
            // lblParaName
            // 
            this.lblParaName.AutoSize = true;
            this.lblParaName.Location = new System.Drawing.Point(267, 298);
            this.lblParaName.Name = "lblParaName";
            this.lblParaName.Size = new System.Drawing.Size(90, 21);
            this.lblParaName.TabIndex = 2;
            this.lblParaName.Text = "参数名称：";
            // 
            // txtParaId
            // 
            this.txtParaId.Location = new System.Drawing.Point(359, 216);
            this.txtParaId.MaxLength = 30;
            this.txtParaId.Name = "txtParaId";
            this.txtParaId.Size = new System.Drawing.Size(390, 29);
            this.txtParaId.TabIndex = 1;
            // 
            // lblParaId
            // 
            this.lblParaId.AutoSize = true;
            this.lblParaId.Location = new System.Drawing.Point(282, 220);
            this.lblParaId.Name = "lblParaId";
            this.lblParaId.Size = new System.Drawing.Size(75, 21);
            this.lblParaId.TabIndex = 0;
            this.lblParaId.Text = "参数ID：";
            // 
            // txtParaValue
            // 
            this.txtParaValue.Location = new System.Drawing.Point(359, 372);
            this.txtParaValue.MaxLength = 20;
            this.txtParaValue.Name = "txtParaValue";
            this.txtParaValue.Size = new System.Drawing.Size(390, 29);
            this.txtParaValue.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(348, 438);
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
            this.btnCancel.Location = new System.Drawing.Point(597, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSystemParameterManageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtParaValue);
            this.Controls.Add(this.lblParaValue);
            this.Controls.Add(this.txtParaName);
            this.Controls.Add(this.lblParaName);
            this.Controls.Add(this.txtParaId);
            this.Controls.Add(this.lblParaId);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSystemParameterManageEdit";
            this.Text = "系统参数维护";
            this.Load += new System.EventHandler(this.frmSystemParameManageEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaValue;
        private System.Windows.Forms.TextBox txtParaName;
        private System.Windows.Forms.Label lblParaName;
        private System.Windows.Forms.TextBox txtParaId;
        private System.Windows.Forms.Label lblParaId;
        private System.Windows.Forms.TextBox txtParaValue;
        private Eap.Control.ButtonEx btnSave;
        private Eap.Control.ButtonEx btnCancel;
    }
}