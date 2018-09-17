using System;

namespace Eap.Entity
{
    public class EapDepartment
    {
        /// <summary>
        /// ID
        /// </summary>
        private decimal _NO;
        public decimal NO
        {
            get { return _NO; }
            set { _NO = value; }
        }

        /// <summary>
        /// 部门ID
        /// </summary>
        private decimal _DEPARTMENT_ID;
        public decimal DEPARTMENT_ID
        {
            get { return _DEPARTMENT_ID; }
            set { _DEPARTMENT_ID = value; }
        }

        /// <summary>
        /// 部门编号
        /// </summary>
        private string _DEPARTMENT_CODE;
        public string DEPARTMENT_CODE
        {
            get { return _DEPARTMENT_CODE; }
            set { _DEPARTMENT_CODE = value; }
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        private string _DEPARTMENT_NAME;
        public string DEPARTMENT_NAME
        {
            get { return _DEPARTMENT_NAME; }
            set { _DEPARTMENT_NAME = value; }
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
        /// 类型
        /// </summary>
        private string _DEPARTMENT_TYPE;
        public string DEPARTMENT_TYPE
        {
            get { return _DEPARTMENT_TYPE; }
            set { _DEPARTMENT_TYPE = value; }
        }

        /// <summary>
        /// 状态1有效，0无效
        /// </summary>
        private decimal _STATUS;
        public decimal STATUS
        {
            get { return _STATUS; }
            set { _STATUS = value; }
        }

        /// <summary>
        /// 状态1有效，0无效
        /// </summary>
        private string _STATUS_FALSE;
        public string STATUS_FALSE
        {
            get {
                if (_STATUS_FALSE == "1") 
                {
                    return "有效";
                }

                if (_STATUS_FALSE == "0")
                {
                    return "无效";
                }
                return _STATUS_FALSE;
            }
            set { _STATUS_FALSE = value; }
        }
    }
}
