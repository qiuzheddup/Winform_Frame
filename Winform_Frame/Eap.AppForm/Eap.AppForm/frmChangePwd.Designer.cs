namespace Eap.AppForm
{
    partial class frmChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePwd));
            this.lblOld = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.btnOK = new Eap.Control.ButtonEx();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnCancle = new Eap.Control.ButtonEx();
            this.txtNewAgain = new System.Windows.Forms.TextBox();
            this.lblNewAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(378, 182);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(79, 21);
            this.lblOld.TabIndex = 0;
            this.lblOld.Text = "旧密码 ：";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(459, 178);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(215, 29);
            this.txtOld.TabIndex = 1;
            this.txtOld.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(334, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 50);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(378, 257);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(79, 21);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "新密码 ：";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(459, 253);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(215, 29);
            this.txtNew.TabIndex = 3;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // btnCancle
            // 
            this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(594, 407);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 50);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtNewAgain
            // 
            this.txtNewAgain.Location = new System.Drawing.Point(459, 328);
            this.txtNewAgain.Name = "txtNewAgain";
            this.txtNewAgain.Size = new System.Drawing.Size(215, 29);
            this.txtNewAgain.TabIndex = 5;
            this.txtNewAgain.UseSystemPasswordChar = true;
            // 
            // lblNewAgain
            // 
            this.lblNewAgain.AutoSize = true;
            this.lblNewAgain.Location = new System.Drawing.Point(330, 332);
            this.lblNewAgain.Name = "lblNewAgain";
            this.lblNewAgain.Size = new System.Drawing.Size(127, 21);
            this.lblNewAgain.TabIndex = 4;
            this.lblNewAgain.Text = "再次输入密码 ：";
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.txtNewAgain);
            this.Controls.Add(this.lblNewAgain);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.lblOld);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChangePwd";
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.TextBox txtOld;
        private Control.ButtonEx btnOK;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtNew;
        private Control.ButtonEx btnCancle;
        private System.Windows.Forms.TextBox txtNewAgain;
        private System.Windows.Forms.Label lblNewAgain;
    }
}