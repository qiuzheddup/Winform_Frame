using System;

namespace Eap.Entity
{
    public class EapLog
    {
        private decimal _LOG_ID;
        public decimal LOG_ID
        {
            get { return _LOG_ID; }
            set { _LOG_ID = value; }
        }

        private decimal _LOG_TYPE;
        public decimal LOG_TYPE
        {
            get { return _LOG_TYPE; }
            set { _LOG_TYPE = value; }
        }

        private string _LOG_TYPE_NAME;
        public string LOG_TYPE_NAME
        {
            get { return _LOG_TYPE_NAME; }
            set { _LOG_TYPE_NAME = value; }
        }

        private string _OPERATE_NOTE;
        public string OPERATE_NOTE
        {
            get { return _OPERATE_NOTE; }
            set { _OPERATE_NOTE = value; }
        }

        private string _OPERATE_USER;
        public string OPERATE_USER
        {
            get { return _OPERATE_USER; }
            set { _OPERATE_USER = value; }
        }

        private string _OPERATE_USER_NAME;
        public string OPERATE_USER_NAME
        {
            get { return _OPERATE_USER_NAME; }
            set { _OPERATE_USER_NAME = value; }
        }

        private DateTime _OPERATE_TIME;
        public DateTime OPERATE_TIME
        {
            get { return _OPERATE_TIME; }
            set { _OPERATE_TIME = value; }
        }

        private DateTime _BEGIN_TIME;
        public DateTime BEGIN_TIME
        {
            get { return _BEGIN_TIME; }
            set { _BEGIN_TIME = value; }
        }

        private DateTime _END_TIME;
        public DateTime END_TIME
        {
            get { return _END_TIME; }
            set { _END_TIME = value; }
        }
    }
}
