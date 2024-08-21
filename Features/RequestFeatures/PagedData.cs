using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.RequestFeatures
{
    public class PagedData<T> 
    {

        public PagedData(MetaData info,T nData) {
            CurrentPage = info.CurrentPage;
            TotalPages = info.TotalPages;
            PageSize = info.PageSize;
            TotalCount = info.TotalCount;

            this.Data = nData;

        }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public T Data { get; set; }

    }
}
