using Eap.Resource;
namespace Eap.Control
{
    partial class MenuEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEx));
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.tlpMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.btnMainPrevPage = new System.Windows.Forms.Button();
            this.btnMainNextPage = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.tlpSubMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubPrevPage = new System.Windows.Forms.Button();
            this.btnSubNextPage = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.tlpMainMenu.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.tlpSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.tlpMainMenu);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(1018, 706);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // tlpMainMenu
            // 
            this.tlpMainMenu.AutoSize = true;
            this.tlpMainMenu.ColumnCount = 9;
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.5F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.5F));
            this.tlpMainMenu.Controls.Add(this.lblErrMsg, 0, 0);
            this.tlpMainMenu.Controls.Add(this.btnMainPrevPage, 0, 2);
            this.tlpMainMenu.Controls.Add(this.btnMainNextPage, 8, 2);
            this.tlpMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainMenu.Name = "tlpMainMenu";
            this.tlpMainMenu.RowCount = 7;
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85671F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.52439F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85671F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.52439F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85671F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.52439F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85671F));
            this.tlpMainMenu.Size = new System.Drawing.Size(1018, 706);
            this.tlpMainMenu.TabIndex = 0;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Location = new System.Drawing.Point(5, 0);
            this.lblErrMsg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(0, 168);
            this.lblErrMsg.TabIndex = 2;
            // 
            // btnMainPrevPage
            // 
            this.btnMainPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMainPrevPage.FlatAppearance.BorderSize = 0;
            this.btnMainPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.btnMainPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("btnMainPrevPage.Image")));
            this.btnMainPrevPage.Location = new System.Drawing.Point(19, 290);
            this.btnMainPrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainPrevPage.Name = "btnMainPrevPage";
            this.tlpMainMenu.SetRowSpan(this.btnMainPrevPage, 3);
            this.btnMainPrevPage.Size = new System.Drawing.Size(67, 122);
            this.btnMainPrevPage.TabIndex = 1;
            this.btnMainPrevPage.UseVisualStyleBackColor = false;
            this.btnMainPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnMainNextPage
            // 
            this.btnMainNextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMainNextPage.FlatAppearance.BorderSize = 0;
            this.btnMainNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.btnMainNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnMainNextPage.Image")));
            this.btnMainNextPage.Location = new System.Drawing.Point(928, 290);
            this.btnMainNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnMainNextPage.Name = "btnMainNextPage";
            this.tlpMainMenu.SetRowSpan(this.btnMainNextPage, 3);
            this.btnMainNextPage.Size = new System.Drawing.Size(67, 122);
            this.btnMainNextPage.TabIndex = 0;
            this.btnMainNextPage.UseVisualStyleBackColor = false;
            this.btnMainNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.tlpSubMenu);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(1018, 706);
            this.pnlSubMenu.TabIndex = 0;
            // 
            // tlpSubMenu
            // 
            this.tlpSubMenu.ColumnCount = 10;
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpSubMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.tlpSubMenu.Controls.Add(this.btnSubPrevPage, 1, 4);
            this.tlpSubMenu.Controls.Add(this.btnSubNextPage, 9, 4);
            this.tlpSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpSubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSubMenu.Name = "tlpSubMenu";
            this.tlpSubMenu.RowCount = 9;
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpSubMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tlpSubMenu.Size = new System.Drawing.Size(1018, 706);
            this.tlpSubMenu.TabIndex = 0;
            // 
            // btnSubPrevPage
            // 
            this.btnSubPrevPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubPrevPage.FlatAppearance.BorderSize = 0;
            this.btnSubPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.btnSubPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("btnSubPrevPage.Image")));
            this.btnSubPrevPage.Location = new System.Drawing.Point(223, 286);
            this.btnSubPrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubPrevPage.Name = "btnSubPrevPage";
            this.btnSubPrevPage.Size = new System.Drawing.Size(61, 130);
            this.btnSubPrevPage.TabIndex = 1;
            this.btnSubPrevPage.UseVisualStyleBackColor = false;
            this.btnSubPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnSubNextPage
            // 
            this.btnSubNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubNextPage.FlatAppearance.BorderSize = 0;
            this.btnSubNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.btnSubNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnSubNextPage.Image")));
            this.btnSubNextPage.Location = new System.Drawing.Point(953, 286);
            this.btnSubNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubNextPage.Name = "btnSubNextPage";
            this.btnSubNextPage.Size = new System.Drawing.Size(65, 130);
            this.btnSubNextPage.TabIndex = 0;
            this.btnSubNextPage.UseVisualStyleBackColor = false;
            this.btnSubNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // MenuEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlSubMenu);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MenuEx";
            this.Size = new System.Drawing.Size(1018, 706);
            this.Load += new System.EventHandler(this.MenuEx_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.tlpMainMenu.ResumeLayout(false);
            this.tlpMainMenu.PerformLayout();
            this.pnlSubMenu.ResumeLayout(false);
            this.tlpSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenu;
        private System.Windows.Forms.TableLayoutPanel tlpSubMenu;
        private System.Windows.Forms.Button btnMainNextPage;
        private System.Windows.Forms.Button btnMainPrevPage;
        private System.Windows.Forms.Button btnSubNextPage;
        private System.Windows.Forms.Button btnSubPrevPage;
        private System.Windows.Forms.Label lblErrMsg;
    }
}
