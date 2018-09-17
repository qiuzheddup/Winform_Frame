using System;
using System.Collections.Generic;
using Eap.Enum;
using Eap.Entity;
using Eap.DbUnit;
using System.Threading;
using System.ServiceProcess;

namespace Eap.Server.ProcessMonitor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] { new ProcessMonitor() };
            ServiceBase.Run(ServicesToRun);

            //Thread thread_fm = new Thread(new ThreadStart(Bll.GetBll().Start));
            //thread_fm.Start();    
            
        }
    }
}
