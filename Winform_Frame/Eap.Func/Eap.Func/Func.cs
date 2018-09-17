using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Net;
using System.Drawing;
using System.Media;

using Eap.Enum;
using Eap.Control;
using Eap.Resource;

namespace Eap
{
    public class Func
    {
        /// <summary>
        /// 计算中英文字符串长度
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字符串的长度</returns>
        public static int StringLength(string str)
        {
            return Encoding.Default.GetBytes(str).Length;
        }

        /// <summary>
        /// 统一窗体格式
        /// </summary>
        /// <param name="frm"></param>
        public static void FormatForm(Form frm)
        {
            //背景色
            frm.BackColor = FormatBackColor();

            //文本框样式
            FormatTextBox(frm.Controls);

            //按钮样式
            FormatButtonEx(frm.Controls);
        }

        /// <summary>
        /// 统一文本框样式
        /// </summary>
        /// <param name="ctls">控件集合</param>
        public static void FormatTextBox(System.Windows.Forms.Control.ControlCollection ctls)
        {
            foreach (System.Windows.Forms.Control ctl in ctls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox textbox = (TextBox)ctl;
                    textbox.ImeMode = ImeMode.OnHalf;
                }
                else
                {
                    if (ctl.Controls.Count > 0)
                    {
                        FormatTextBox(ctl.Controls);
                    }
                }
            }
        }

        /// <summary>
        /// 统一按钮样式
        /// </summary>
        /// <param name="ctls">控件集合</param>
        public static void FormatButtonEx(System.Windows.Forms.Control.ControlCollection ctls)
        {
            foreach (System.Windows.Forms.Control ctl in ctls)
            {
                if (ctl is ButtonEx)
                {
                    ctl.BackgroundImage = EapResource.BrownButtonUp;
                }
                else
                {
                    if (ctl.Controls.Count > 0)
                    {
                        FormatButtonEx(ctl.Controls);
                    }
                }
            }
        }

        /// <summary>
        /// 统一背景颜色
        /// </summary>
        /// <returns>颜色对象</returns>
        public static Color FormatBackColor()
        {
            return Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(207)))), ((int)(((byte)(162)))));
        }

        /// <summary>
        /// 格式化日期字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="split">是否包含分隔符</param>
        /// <returns>YYYYMMDD</returns>
        public static string FormatDate(DateTime dt, bool split)
        {
            if (split)
            {
                return dt.Year.ToString().PadLeft(4, '0')
                    + "-" + dt.Month.ToString().PadLeft(2, '0')
                    + "-" + dt.Day.ToString().PadLeft(2, '0');
            }
            else
            {
                return dt.Year.ToString().PadLeft(4, '0')
                    + dt.Month.ToString().PadLeft(2, '0')
                    + dt.Day.ToString().PadLeft(2, '0');
            }
        }

        /// <summary>
        /// 格式化时间字符串
        /// </summary>
        /// <param name="dt">时间</param>
        /// <param name="mflag">是否包含毫秒位</param>
        /// <param name="split">是否包含分隔符</param>
        /// <returns>HHMMSSMMM</returns>
        public static string FormatTime(DateTime dt, bool mflag, bool split)
        {
            if (mflag)
            {
                if (split)
                {
                    return dt.Hour.ToString().PadLeft(2, '0')
                        + ":" + dt.Minute.ToString().PadLeft(2, '0')
                        + ":" + dt.Second.ToString().PadLeft(2, '0')
                        + ":" + dt.Millisecond.ToString().PadLeft(3, '0');
                }
                else
                {
                    return dt.Hour.ToString().PadLeft(2, '0')
                        + dt.Minute.ToString().PadLeft(2, '0')
                        + dt.Second.ToString().PadLeft(2, '0')
                        + dt.Millisecond.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                if (split)
                {
                    return dt.Hour.ToString().PadLeft(2, '0')
                        + ":" + dt.Minute.ToString().PadLeft(2, '0')
                        + ":" + dt.Second.ToString().PadLeft(2, '0');
                }
                else
                {
                    return dt.Hour.ToString().PadLeft(2, '0')
                        + dt.Minute.ToString().PadLeft(2, '0')
                        + dt.Second.ToString().PadLeft(2, '0');
                }
            }
        }

        /// <summary>
        /// 获取本机Ip地址
        /// </summary>
        /// <returns>本机Ip地址</returns>
        public static string[] GetHostIp()
        {
            IPAddress[] ip_add = Dns.GetHostAddresses(Environment.MachineName);
            string[] str = new string[ip_add.Length];

            int i = 0;

            foreach (IPAddress ip in ip_add)
            {
                str[i] = ip.ToString();
                i++;
            }

            return str;
        }

        //密钥初始化向量
        private static byte[] keys = { 0x34, 0x12, 0x78, 0x56, 0xAB, 0x90, 0xEF, 0xCD };

        /// <summary>
        /// 加密字符串
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <param name="key">密钥（8位）</param>
        /// <returns>成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptString(string str, string key)
        {
            if (key.Length != 8)
            {
                ShowMessage(MessageType.Error, "密钥错误，请输入8位密钥");
                return str;
            }

            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(key);
                byte[] rgbIV = keys;
                byte[] strArray = Encoding.UTF8.GetBytes(str);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();

                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cs.Write(strArray, 0, strArray.Length);
                cs.FlushFinalBlock();

                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                ShowMessage(MessageType.Error, ex.Message);
                return str;
            }
        }

        /// <summary>
        /// 解密字符串
        /// </summary>
        /// <param name="str">要解密的字符串</param>
        /// <param name="key">密钥（8位），要求和加密密钥相同</param>
        /// <returns>成功返回解密后的字符串，失败返回源串</returns>
        public static string DecryptString(string str, string key)
        {
            if (key.Length != 8)
            {
                ShowMessage(MessageType.Error, "密钥错误，请输入8位密钥");
                return str;
            }

            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(key);
                byte[] rgbIV = keys;
                byte[] strArray = Convert.FromBase64String(str);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();

                ICryptoTransform ict = des.CreateDecryptor(rgbKey, rgbIV);
                CryptoStream cs = new CryptoStream(ms, ict, CryptoStreamMode.Write);
                cs.Write(strArray, 0, strArray.Length);
                cs.FlushFinalBlock();

                return Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                ShowMessage(MessageType.Error, ex.Message);
                return str;
            }
        }

        /// <summary>
        /// 显示询问问题对话框
        /// </summary>
        /// <param name="msg">要询问的消息</param>
        /// <returns>true：用户点击了Yes按钮；false：用户点击了No按钮</returns>
        public static bool ShowQuestion(string msg)
        {
            if (MessageBox.Show(msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 显示指定类型的消息框
        /// </summary>
        /// <param name="mt">消息类型</param>
        /// <param name="msg">消息内容</param>
        public static void ShowMessage(MessageType mt, string msg)
        {
            switch (mt)
            {
                case MessageType.Information:
                    MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case MessageType.Warning:
                    MessageBox.Show(msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case MessageType.Error:
                    MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        //播放声音对象
        private static SoundPlayer _PlanSound;

        /// <summary>
        /// 播放声音
        /// </summary>
        public static void PlanSound()
        {
            if (_PlanSound == null)
            {
                _PlanSound = new SoundPlayer(Eap.Resource.EapResource.WarningSound);
            }

            _PlanSound.Play();
        }

        //播放声音对象2
        private static SoundPlayer _PlanWarnSound1;
        /// <summary>
        /// 播放报警声音1
        /// </summary>
        public static void PlanWarnSound1()
        {
            if (_PlanWarnSound1 == null)
            {
                _PlanWarnSound1 = new SoundPlayer(Eap.Resource.EapResource.WarningSound1);
            }

            _PlanWarnSound1.Play();
        }

        //播放声音对象3
        private static SoundPlayer _PlanPassSound;
        /// <summary>
        /// 播放通过声音
        /// </summary>
        public static void PlanPassSound()
        {
            if (_PlanPassSound == null)
            {
                _PlanPassSound = new SoundPlayer(Eap.Resource.EapResource.PassSound);
            }

            _PlanPassSound.Play();
        }

        //播放声音对象4
        private static SoundPlayer PassSound2;
        /// <summary>
        /// 播放通过声音
        /// </summary>
        public static void PlanPassSound2()
        {
            if (PassSound2 == null)
            {
                PassSound2 = new SoundPlayer(Eap.Resource.EapResource.Feed);
            }

            PassSound2.Play();
        }
    }
}
