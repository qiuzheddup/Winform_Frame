namespace Eap.Entity
{
    public class EapCommonQuery
    {
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        /// <summary>
        /// 窗体名
        /// </summary>
        private string _FROM_NAME;
        public string FROM_NAME
        {
            get { return _FROM_NAME; }
            set { _FROM_NAME = value; }
        }

        /// <summary>
        /// 表名
        /// </summary>
        private string _TABLE_NAME;
        public string TABLE_NAME
        {
            get { return _TABLE_NAME; }
            set { _TABLE_NAME = value; }
        }

        /// <summary>
        /// 字段1
        /// </summary>
        private string _FIELD1;
        public string FIELD1
        {
            get { return _FIELD1; }
            set { _FIELD1 = value; }
        }

        /// <summary>
        /// 字段1的显示名称
        /// </summary>
        private string _FIELD_NAME1;
        public string FIELD_NAME1
        {
            get { return _FIELD_NAME1; }
            set { _FIELD_NAME1 = value; }
        }

        /// <summary>
        /// 字段2
        /// </summary>
        private string _FIELD2;
        public string FIELD2
        {
            get { return _FIELD2; }
            set { _FIELD2 = value; }
        }

        /// <summary>
        /// 字段2的显示名称
        /// </summary>
        private string _FIELD_NAME2;
        public string FIELD_NAME2
        {
            get { return _FIELD_NAME2; }
            set { _FIELD_NAME2 = value; }
        }
    }
}
