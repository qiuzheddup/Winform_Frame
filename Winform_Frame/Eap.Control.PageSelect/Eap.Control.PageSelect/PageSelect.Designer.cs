namespace Eap.Control
{
    partial class PageSelect
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSelect));
            this.lblPageCount = new System.Windows.Forms.Label();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.btnPageHome = new Eap.Control.ButtonEx();
            this.btnPageUp = new Eap.Control.ButtonEx();
            this.btnPageDown = new Eap.Control.ButtonEx();
            this.btnPageEnd = new Eap.Control.ButtonEx();
            this.btnGoPage = new Eap.Control.ButtonEx();
            this.SuspendLayout();
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(468, 15);
            this.lblPageCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(187, 21);
            this.lblPageCount.TabIndex = 4;
            this.lblPageCount.Text = "第999999页 共999999页";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(333, 11);
            this.txtPageNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(80, 29);
            this.txtPageNo.TabIndex = 5;
            this.txtPageNo.TextChanged += new System.EventHandler(this.txtPageNo_TextChanged);
            this.txtPageNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNo_KeyPress);
            // 
            // btnPageHome
            // 
            this.btnPageHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageHome.FlatAppearance.BorderSize = 0;
            this.btnPageHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageHome.Location = new System.Drawing.Point(0, 0);
            this.btnPageHome.Name = "btnPageHome";
            this.btnPageHome.Size = new System.Drawing.Size(80, 50);
            this.btnPageHome.TabIndex = 7;
            this.btnPageHome.Text = "首页";
            this.btnPageHome.UseVisualStyleBackColor = true;
            this.btnPageHome.Click += new System.EventHandler(this.btnPageHome_Click);
            // 
            // btnPageUp
            // 
            this.btnPageUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageUp.FlatAppearance.BorderSize = 0;
            this.btnPageUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageUp.Location = new System.Drawing.Point(80, 0);
            this.btnPageUp.Name = "btnPageUp";
            this.btnPageUp.Size = new System.Drawing.Size(80, 50);
            this.btnPageUp.TabIndex = 8;
            this.btnPageUp.Text = "上页";
            this.btnPageUp.UseVisualStyleBackColor = true;
            this.btnPageUp.Click += new System.EventHandler(this.btnPageUp_Click);
            // 
            // btnPageDown
            // 
            this.btnPageDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageDown.FlatAppearance.BorderSize = 0;
            this.btnPageDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageDown.Location = new System.Drawing.Point(160, 0);
            this.btnPageDown.Name = "btnPageDown";
            this.btnPageDown.Size = new System.Drawing.Size(80, 50);
            this.btnPageDown.TabIndex = 9;
            this.btnPageDown.Text = "下页";
            this.btnPageDown.UseVisualStyleBackColor = true;
            this.btnPageDown.Click += new System.EventHandler(this.btnPageDown_Click);
            // 
            // btnPageEnd
            // 
            this.btnPageEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageEnd.FlatAppearance.BorderSize = 0;
            this.btnPageEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageEnd.Location = new System.Drawing.Point(240, 0);
            this.btnPageEnd.Name = "btnPageEnd";
            this.btnPageEnd.Size = new System.Drawing.Size(80, 50);
            this.btnPageEnd.TabIndex = 10;
            this.btnPageEnd.Text = "尾页";
            this.btnPageEnd.UseVisualStyleBackColor = true;
            this.btnPageEnd.Click += new System.EventHandler(this.btnPageEnd_Click);
            // 
            // btnGoPage
            // 
            this.btnGoPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoPage.FlatAppearance.BorderSize = 0;
            this.btnGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPage.Location = new System.Drawing.Point(414, 0);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(50, 50);
            this.btnGoPage.TabIndex = 11;
            this.btnGoPage.Text = "GO";
            this.btnGoPage.UseVisualStyleBackColor = true;
            this.btnGoPage.Click += new System.EventHandler(this.btnGoPage_Click);
            // 
            // PageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoPage);
            this.Controls.Add(this.btnPageEnd);
            this.Controls.Add(this.btnPageDown);
            this.Controls.Add(this.btnPageUp);
            this.Controls.Add(this.btnPageHome);
            this.Controls.Add(this.txtPageNo);
            this.Controls.Add(this.lblPageCount);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PageSelect";
            this.Size = new System.Drawing.Size(655, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.TextBox txtPageNo;
        private ButtonEx btnPageHome;
        private ButtonEx btnPageUp;
        private ButtonEx btnPageDown;
        private ButtonEx btnPageEnd;
        private ButtonEx btnGoPage;
    }
}
