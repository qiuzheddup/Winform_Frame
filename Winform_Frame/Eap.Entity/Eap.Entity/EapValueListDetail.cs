using System;

namespace Eap.Entity
{
    public class EapValueListDetail
    {
        private decimal _VLIST_DETAIL_ID;
        public decimal VLIST_DETAIL_ID
        {
            get { return _VLIST_DETAIL_ID; }
            set { _VLIST_DETAIL_ID = value; }
        }

        private string _VLIST_ID;
        public string VLIST_ID
        {
            get { return _VLIST_ID; }
            set { _VLIST_ID = value; }
        }

        private decimal _VLIST_DETAIL_VALUE;
        public decimal VLIST_DETAIL_VALUE
        {
            get { return _VLIST_DETAIL_VALUE; }
            set { _VLIST_DETAIL_VALUE = value; }
        }

        private string _VLIST_DETAIL_NAME;
        public string VLIST_DETAIL_NAME
        {
            get { return _VLIST_DETAIL_NAME; }
            set { _VLIST_DETAIL_NAME = value; }
        }
    }
}
