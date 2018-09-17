using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using Eap.Enum;
using Eap.DbUnit;
using Eap.Entity;

namespace Eap.Server.ProcessMonitor
{
    partial class ProcessMonitor : ServiceBase
    {
        public ProcessMonitor()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread thread_fm = new Thread(new ThreadStart(Bll.GetBll().Start));
            thread_fm.Start(); 
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
