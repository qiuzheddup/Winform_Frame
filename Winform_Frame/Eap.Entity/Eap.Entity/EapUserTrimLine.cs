namespace Eap.Entity
{
    public class EapUserTrimLine
    {
        private string _USER_ID;

        /// <summary>
        /// 用户ID
        /// </summary>
        public string USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        private decimal _TRIM_LINE;

        /// <summary>
        /// 总装生产线
        /// </summary>
        public decimal TRIM_LINE
        {
            get { return _TRIM_LINE; }
            set { _TRIM_LINE = value; }
        }
    }
}
