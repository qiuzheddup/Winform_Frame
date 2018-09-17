namespace Eap.Entity
{
    /// <summary>
    /// Sql查询语句影响行数统计
    /// </summary>
    public class EapSqlCount
    {
        private decimal _CNT;
        /// <summary>
        /// 行数
        /// </summary>
        public decimal CNT
        {
            get { return _CNT; }
            set { _CNT = value; }
        }
    }
}
