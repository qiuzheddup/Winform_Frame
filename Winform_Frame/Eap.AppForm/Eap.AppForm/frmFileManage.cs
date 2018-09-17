using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using Eap.Entity;
using Eap.Enum;

namespace Eap.AppForm
{
    public partial class frmFileManage : Form
    {
        public frmFileManage()
        {
            InitializeComponent();
            Func.FormatForm(this);
            ButtonRight.FormatFormButtonEnabled(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFileManage_Load(object sender, EventArgs e)
        {
            page.PageNo = 1;
            page.PageSize = 20;

            BindData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFileId.Text = string.Empty;
            txtFileVersion.Text = string.Empty;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            page.PageNo = 1;
            BindData();
        }

        private EapFile getQuery()
        {
            EapFile query = new EapFile();

            query.FILE_ID = txtFileId.Text.Trim();
            if (Func.StringLength(query.FILE_ID) > 20)
            {
                Func.ShowMessage(MessageType.Error, "文件名称最大长度为20个字符（10个汉字）");
                return null;
            }

            query.FILE_VERSION = txtFileVersion.Text.Trim();
            if (Func.StringLength(query.FILE_VERSION) > 20)
            {
                Func.ShowMessage(MessageType.Error, "文件版本最大长度为20个字符（10个汉字）");
                return null;
            }

            return query;
        }

        private void BindData()
        {
            EapFile query = getQuery();
            if (query == null)
            {
                return;
            }

            chkAllSelect.Checked = false;

            int icnt;
            dgv.DataSource = Bll.GetBll().GetAppFiles(query, page.PageNo, page.PageSize, out icnt);
            page.RecordCount = icnt;
        }

        private void page_PageChange()
        {
            BindData();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            pfd.Multiselect = true;
            pfd.Filter = "所有支持的文件(*.dll,*.exe,*.config,*.bat)|*.dll;*.exe;*.config;*.bat";

            if (pfd.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in pfd.FileNames)
                {
                    FileInfo fi = new FileInfo(path);
                    
                    //获取文件信息
                    EapFile eapfile = new EapFile();
                    eapfile.FILE_ID = fi.Name;
                    eapfile.FILE_VERSION = FileVersionInfo.GetVersionInfo(path).FileVersion;
                    if (eapfile.FILE_VERSION == null)
                    {
                        eapfile.FILE_VERSION = string.Empty;
                    }
                    eapfile.FILE_EDIT_TIME = fi.LastWriteTime;

                    //读取文件
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    if (fs.Length == 0)
                    {
                        Func.ShowMessage(MessageType.Error, "不能上传空文件");
                        break;
                    }
                    eapfile.FILE_DATA = new byte[fs.Length];
                    fs.Read(eapfile.FILE_DATA, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();

                    //上传文件
                    string ret = Bll.GetBll().UploadFile(eapfile);
                    Log.Write(MessageType.Information, "上传文件[" + eapfile.FILE_ID + "]", Config.GetConfig().user.USER_ID);
                    if (ret != string.Empty)
                    {
                        Func.ShowMessage(MessageType.Error, ret);
                        break;
                    }
                }

                page.PageNo = 1;
                BindData();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgv.Rows[e.RowIndex].Cells["colSelect"];
                if ((bool)cell.Value)
                    cell.Value = "false";
                else
                    cell.Value = "true";
            }
            catch (Exception ex)
            {
                Func.ShowMessage(MessageType.Error, ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Func.ShowQuestion("确定要删除选中的文件吗（警告，不可恢复）？"))
            {
                return;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                //删除选中行的文件
                if ((bool)row.Cells["colSelect"].Value)
                {
                    string ret = Bll.GetBll().DeleteFile(row.Cells["colFileId"].Value.ToString());
                    Log.Write(MessageType.Information, "删除文件[" + row.Cells["colFileId"].Value.ToString() + "]", Config.GetConfig().user.USER_ID);
                    if (ret != string.Empty)
                    {
                        Func.ShowMessage(MessageType.Error, ret);
                        break;
                    }
                }
            }

            page.PageNo = 1;
            BindData();
        }

        private void chkAllSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllSelect.Checked)
            {
                //全选
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells["colSelect"].Value = "true";
                }
            }
            else
            {
                //取消全选
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells["colSelect"].Value = "false";
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\" + Config.GetConfig().APP_DOWNLOAD
                + "\\" + Func.FormatDate(DateTime.Now, false) + Func.FormatTime(DateTime.Now, true, false);
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                //下载选中行的文件
                if ((bool)row.Cells["colSelect"].Value)
                {
                    //获取文件数据
                    EapFile file = Bll.GetBll().DownloadFile(row.Cells["colFileId"].Value.ToString());
                    if (file == null)
                    {
                        Func.ShowMessage(MessageType.Error, "下载文件[" + row.Cells["colFileId"].Value.ToString() + "]失败");
                        return;
                    }

                    //写入文件
                    FileStream fs = new FileStream(path + "\\" + file.FILE_ID, FileMode.Create, FileAccess.Write);
                    fs.Write(file.FILE_DATA, 0, file.FILE_DATA.Length);
                    fs.Close();
                }
            }

            Func.ShowMessage(MessageType.Information, "文件下载成功，下载的文件已保存到目录[" + path + "]");
        }
    }
}
