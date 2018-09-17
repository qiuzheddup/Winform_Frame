using System;

namespace Eap.Entity
{
    public class EapFile
    {
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        private bool _IS_SELECTED = false;
        public bool IS_SELECTED
        {
            get { return _IS_SELECTED; }
            set { _IS_SELECTED = value; }
        }

        private string _FILE_ID;
        public string FILE_ID
        {
            get { return _FILE_ID; }
            set { _FILE_ID = value; }
        }

        private string _FILE_VERSION;
        public string FILE_VERSION
        {
            get { return _FILE_VERSION; }
            set { _FILE_VERSION = value; }
        }

        private DateTime _FILE_EDIT_TIME;
        public DateTime FILE_EDIT_TIME
        {
            get { return _FILE_EDIT_TIME; }
            set { _FILE_EDIT_TIME = value; }
        }

        private DateTime _FILE_UPLOAD_TIME;
        public DateTime FILE_UPLOAD_TIME
        {
            get { return _FILE_UPLOAD_TIME; }
            set { _FILE_UPLOAD_TIME = value; }
        }

        private byte[] _FILE_DATA;
        public byte[] FILE_DATA
        {
            get { return _FILE_DATA; }
            set { _FILE_DATA = value; }
        }
    }
}
