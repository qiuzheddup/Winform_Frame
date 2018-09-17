using System;

namespace Eap.Entity
{
    public class EapProcess
    {
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        private string _PROCESS_ID;
        public string PROCESS_ID
        {
            get { return _PROCESS_ID; }
            set { _PROCESS_ID = value; }
        }

        private string _PROCESS_NAME;
        public string PROCESS_NAME
        {
            get { return _PROCESS_NAME; }
            set { _PROCESS_NAME = value; }
        }

        private DateTime _REFRESH_DATE;
        public DateTime REFRESH_DATE
        {
            get { return _REFRESH_DATE; }
            set { _REFRESH_DATE = value; }
        }

        private decimal _PROCESS_STATUS;
        public decimal PROCESS_STATUS
        {
            get { return _PROCESS_STATUS; }
            set { _PROCESS_STATUS = value; }
        }

        private decimal? _PROCESS_SOCKET_STATUS;
        public decimal? PROCESS_SOCKET_STATUS
        {
            get { return _PROCESS_SOCKET_STATUS; }
            set { _PROCESS_SOCKET_STATUS = value; }
        }

        private string _PROCESS_URL;
        public string PROCESS_URL
        {
            get { return _PROCESS_URL; }
            set { _PROCESS_URL = value; }
        }

        private decimal _SERVER_FLAG;
        public decimal SERVER_FLAG
        {
            get { return _SERVER_FLAG; }
            set { _SERVER_FLAG = value; }
        }

        private string _SERVER_FLAG_NAME;
        public string SERVER_FLAG_NAME
        {
            get { return _SERVER_FLAG_NAME; }
            set { _SERVER_FLAG_NAME = value; }
        }

        private DateTime _DBTIME;
        public DateTime DBTIME
        {
            get { return _DBTIME; }
            set { _DBTIME = value; }
        }
    }
}
