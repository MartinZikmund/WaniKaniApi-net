using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class PagedCollection<T> : IPagedCollection<T>
    {
        internal PagedCollection(IReadOnlyCollection<T> data, WkCollectionPages pages, int totalCount)
        {
            Data = data;
            PageSize = pages.PerPage;
            PreviousPageUrl = pages.PreviousUrl;
            NextPageUrl = pages.NextUrl;
            TotalCount = totalCount;
        }

        public IReadOnlyCollection<T> Data { get; }

        public int PageSize { get; }

        public int TotalCount { get; }

        public Uri? PreviousPageUrl { get; }

        public Uri? NextPageUrl { get; }
    }
}
