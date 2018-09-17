namespace Eap.Entity
{
    public class EapParameter
    {
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        private string _PARA_ID;
        public string PARA_ID
        {
            get { return _PARA_ID; }
            set { _PARA_ID = value; }
        }

        private string _PARA_NAME;
        public string PARA_NAME
        {
            get { return _PARA_NAME; }
            set { _PARA_NAME = value; }
        }

        private string _PARA_VALUE;
        public string PARA_VALUE
        {
            get { return _PARA_VALUE; }
            set { _PARA_VALUE = value; }
        }
    }
}
