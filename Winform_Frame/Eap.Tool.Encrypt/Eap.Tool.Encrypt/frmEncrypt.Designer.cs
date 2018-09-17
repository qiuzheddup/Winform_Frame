namespace Eap.Tool.Encrypt
{
    partial class frmEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncrypt));
            this.btnEncrypt = new Eap.Control.ButtonEx();
            this.btnDecrypt = new Eap.Control.ButtonEx();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblEncryptString = new System.Windows.Forms.Label();
            this.txtEncryptString = new System.Windows.Forms.TextBox();
            this.lblDecryptString = new System.Windows.Forms.Label();
            this.txtDecryptString = new System.Windows.Forms.TextBox();
            this.btnExit = new Eap.Control.ButtonEx();
            this.btnClear = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.BackgroundImage")));
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(173, 423);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(80, 50);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.BackgroundImage")));
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(295, 423);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(80, 50);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(239, 165);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(58, 21);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "密钥：";
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(299, 161);
            this.txtKey.MaxLength = 8;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(300, 29);
            this.txtKey.TabIndex = 1;
            // 
            // lblEncryptString
            // 
            this.lblEncryptString.AutoSize = true;
            this.lblEncryptString.Location = new System.Drawing.Point(191, 303);
            this.lblEncryptString.Name = "lblEncryptString";
            this.lblEncryptString.Size = new System.Drawing.Size(106, 21);
            this.lblEncryptString.TabIndex = 4;
            this.lblEncryptString.Text = "加密字符串：";
            // 
            // txtEncryptString
            // 
            this.txtEncryptString.Location = new System.Drawing.Point(299, 299);
            this.txtEncryptString.MaxLength = 50;
            this.txtEncryptString.Name = "txtEncryptString";
            this.txtEncryptString.Size = new System.Drawing.Size(300, 29);
            this.txtEncryptString.TabIndex = 5;
            // 
            // lblDecryptString
            // 
            this.lblDecryptString.AutoSize = true;
            this.lblDecryptString.Location = new System.Drawing.Point(191, 234);
            this.lblDecryptString.Name = "lblDecryptString";
            this.lblDecryptString.Size = new System.Drawing.Size(106, 21);
            this.lblDecryptString.TabIndex = 2;
            this.lblDecryptString.Text = "解密字符串：";
            // 
            // txtDecryptString
            // 
            this.txtDecryptString.Location = new System.Drawing.Point(299, 230);
            this.txtDecryptString.MaxLength = 50;
            this.txtDecryptString.Name = "txtDecryptString";
            this.txtDecryptString.Size = new System.Drawing.Size(300, 29);
            this.txtDecryptString.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(539, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 50);
            this.btnExit.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(417, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDecryptString);
            this.Controls.Add(this.lblDecryptString);
            this.Controls.Add(this.txtEncryptString);
            this.Controls.Add(this.lblEncryptString);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串加解密工具";
            this.Load += new System.EventHandler(this.frmEncrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ButtonEx btnEncrypt;
        private Control.ButtonEx btnDecrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblEncryptString;
        private System.Windows.Forms.TextBox txtEncryptString;
        private System.Windows.Forms.Label lblDecryptString;
        private System.Windows.Forms.TextBox txtDecryptString;
        private Control.ButtonEx btnExit;
        private Control.ButtonEx btnClear;
    }
}