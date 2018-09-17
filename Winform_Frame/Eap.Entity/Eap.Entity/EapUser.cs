namespace Eap.Entity
{
    public class EapUser
    {
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        private string _USER_ID;
        public string USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        private string _USER_NAME;
        public string USER_NAME
        {
            get { return _USER_NAME; }
            set { _USER_NAME = value; }
        }

        private string _PWD;
        public string PWD
        {
            get { return _PWD; }
            set { _PWD = value; }
        }

        private decimal _IS_STOP;
        public decimal IS_STOP
        {
            get { return _IS_STOP; }
            set { _IS_STOP = value; }
        }

        private string _IS_STOP_NAME;
        public string IS_STOP_NAME
        {
            get { return _IS_STOP_NAME; }
            set { _IS_STOP_NAME = value; }
        }

        /// <summary>
        /// 装配线
        /// </summary>
        private string _ASSEMBLY_LINE;
        public string ASSEMBLY_LINE
        {
            get { return _ASSEMBLY_LINE; }
            set { _ASSEMBLY_LINE = value; }
        }

        /// <summary>
        /// 目视卡打印章节
        /// </summary>
        private string _PRINT_POSITION;
        public string PRINT_POSITION
        {
            get { return _PRINT_POSITION; }
            set { _PRINT_POSITION = value; }
        }

       
    }
}
