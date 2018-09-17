using System;
using System.Windows.Forms;
using System.ComponentModel;

using Eap.Resource;
using System.Drawing;

namespace Eap.Control
{
    public class ButtonEx : Button
    {
        public ButtonEx()
        {
            this.Width = 80;
            this.Height = 50;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = Color.White;
            this.BackgroundImage = EapResource.BrownButtonUp;

            this.MouseDown += new MouseEventHandler(btn_MouseDown);
            this.MouseUp += new MouseEventHandler(btn_MouseUp);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            //修改按钮可用状态时，刷新图片显示（设计状态时无法刷新，运行时OK）
            if (this.Enabled)
                this.BackgroundImage = EapResource.BrownButtonUp;
            else
                this.BackgroundImage = EapResource.BrownButtonDisable;
        }

        /// <summary>
        /// 鼠标按下时更换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = EapResource.BrownButtonDown;
        }

        /// <summary>
        /// 鼠标弹起时更换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            //不判断可用状态的话，禁用按钮有时会导致显示ButtonUp图片
            if (this.Enabled)
                this.BackgroundImage = EapResource.BrownButtonUp;
            else
                this.BackgroundImage = EapResource.BrownButtonDisable;
        }

        protected override bool ShowFocusCues
        {
            get
            {
                //获取焦点时不显示边框
                return false;
            }
        }
    }
}
