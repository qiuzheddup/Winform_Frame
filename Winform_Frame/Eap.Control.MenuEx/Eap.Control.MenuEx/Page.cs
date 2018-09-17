using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eap.Control
{
    internal class Page<T> : Object
    {
        private int _pageIndex = 1;
        public int PageIndex
        {
            get
            {
                return _pageIndex;
            }
            set
            {
                if (value > 0 && value <= PageCount)
                {
                    _pageIndex = value;
                }
            }
        }

        private int _pageSize = 1;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                if (value > 0)
                {
                    _pageSize = value;
                }
            }
        }

        public int PageCount
        {
            get
            {
                return (0 == RecordCount % PageSize) ? (RecordCount / PageSize) : (RecordCount / PageSize + 1);
            }
        }

        public int RecordCount
        {
            get
            {
                return null == DataSource ? 0 : DataSource.Count;
            }
        }

        public IList<T> DataSource { get; set; }

        public IList<T> GetPageData()
        {
            IList<T> datas = new List<T>();
            if (null != DataSource)
            {
                datas = DataSource.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
            }

            return datas;
        }

        public bool HasNextPage()
        {
            return (PageIndex < PageCount) ? true : false;
        }

        public bool HasPrevPage()
        {
            return (PageIndex > 1) ? true : false;
        }

        public void NextPage()
        {
            PageIndex++;
        }

        public void PrevPage()
        {
            PageIndex--;
        }
    }
}
