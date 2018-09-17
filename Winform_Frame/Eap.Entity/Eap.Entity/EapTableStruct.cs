namespace Eap.Entity
{
    public class EapTableStruct
    {
        private string _COLUMN_NAME;
        public string COLUMN_NAME
        {
            get { return _COLUMN_NAME; }
            set { _COLUMN_NAME = value; }
        }

        private string _DATA_TYPE;
        public string DATA_TYPE
        {
            get { return _DATA_TYPE; }
            set { _DATA_TYPE = value; }
        }

        private decimal _DATA_PRECISION;
        public decimal DATA_PRECISION
        {
            get { return _DATA_PRECISION; }
            set { _DATA_PRECISION = value; }
        }
    }
}
