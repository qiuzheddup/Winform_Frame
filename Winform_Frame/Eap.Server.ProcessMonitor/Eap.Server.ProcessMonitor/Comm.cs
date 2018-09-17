using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eap.Server.ProcessMonitor
{
    public class Comm
    {
        public static Comm comm;

        public Comm()
        {
            Init();
        }

        public static Comm GetComm()
        {
            if (comm == null)
            {
                comm = new Comm();
                return comm;
            }

            return comm;
        }

        private void Init()
        {
            GetServerFlag();
        }

        private void GetServerFlag()
        {
            string part = AppDomain.CurrentDomain.BaseDirectory + "Eap.Server.ProcessMonitor.xml";

            Xml xml = new Xml(part);

            _ServerFlag = xml.GetNodeValue("config/server_flag");
        }

        private  string _ServerFlag;
        /// <summary>
        /// 服务器标志
        /// </summary>
        public string ServerFlag
        {
            get { return _ServerFlag; }
            set { _ServerFlag = value; }
        }

    }
}
