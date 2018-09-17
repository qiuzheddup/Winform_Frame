using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data.OracleClient;

using Eap;
using Eap.Enum;
using Eap.DbUnit;
using Eap.Entity;

namespace Eap.Tool.Entity
{
    public partial class frmEntity : Form
    {
        public frmEntity()
        {
            InitializeComponent();
            Func.FormatForm(this);
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "\\entity"))
            {
                Directory.Delete(Application.StartupPath + "\\entity", true);
            }
            Directory.CreateDirectory(Application.StartupPath + "\\entity");

            if (radOracle.Checked)
            {
                //取用户所有表名称
                List<EapTableAll> list = Oracle.GetOracle().QueryToList<EapTableAll>(new StringBuilder("SELECT t.TABLE_NAME FROM USER_TABLES t where t.TABLE_NAME not like '%T_EAP_%'"));
                if (list == null)
                {
                    Func.ShowMessage(MessageType.Error, "数据库连接失败");
                }
                else if (list.Count == 0)
                {
                    Func.ShowMessage(MessageType.Error, "没有找到表");
                }

                foreach (EapTableAll sub in list)
                {
                    //查询表结构
                    OracleParameter[] para = { new OracleParameter(":table_name", OracleType.VarChar) };
                    para[0].Value = sub.TABLE_NAME;

                    List<EapTableStruct> slist = Oracle.GetOracle().QueryToList<EapTableStruct>(new StringBuilder("select t.COLUMN_NAME,t.DATA_TYPE,t.DATA_PRECISION from USER_TAB_COLUMNS t where t.TABLE_NAME=:TABLE_NAME"), para);
                    if (slist == null || slist.Count == 0)
                        continue;

                    //创建实体类
                    string path = Application.StartupPath + "\\entity\\" + sub.TABLE_NAME + ".cs";
                    string[] str = new string[slist.Count * 7 + 8];
                    str[0] = "using System;";
                    str[1] = "using System.Text;";
                    str[2] = string.Empty;
                    str[3] = "namespace " + txtNameSpace.Text.Trim();
                    str[4] = "{";
                    str[5] = "    public class " + sub.TABLE_NAME;
                    str[6] = "    {";

                    int j = 0;
                    foreach (EapTableStruct ssub in slist)
                    {
                        str[7 + j] = "        private " + OracleConvertType(ssub) + " _" + ssub.COLUMN_NAME + ";";
                        str[8 + j] = "        public " + OracleConvertType(ssub) + " " + ssub.COLUMN_NAME;
                        str[9 + j] = "        {";
                        str[10 + j] = "            get { return _" + ssub.COLUMN_NAME + "; }";
                        str[11 + j] = "            set { _" + ssub.COLUMN_NAME + " = value; }";
                        str[12 + j] = "        }";
                        str[13 + j] = string.Empty;

                        j += 7;
                    }

                    j -= 7;
                    str[13 + j] = "    }";
                    str[14 + j] = "}";

                    File.AppendAllLines(path, str, Encoding.ASCII);
                }
            }

            Func.ShowMessage(MessageType.Information, "创建成功");
        }

        private string OracleConvertType(EapTableStruct t)
        {
            switch (t.DATA_TYPE)
            {
                case "VARCHAR2":
                    return "string";
                case "NUMBER":
                    return "decimal";
                case "DATE":
                    return "DateTime";
                case "BLOB":
                    return "byte[]";
                default:
                    return "string";
            }
        }

        private void frmEntity_Load(object sender, EventArgs e)
        {
            txtServer.Text = Config.GetConfig().DB_IP;
            txtDbName.Text = Config.GetConfig().DB_NAME;
            txtUserId.Text = Config.GetConfig().DB_UID;
            txtPwd.Text = Config.GetConfig().DB_PWD;
            txtNameSpace.Text = Config.GetConfig().APP_NAMESPACE;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
