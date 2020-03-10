using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public interface IPagedCollection<T>
    {
        IReadOnlyCollection<T> Data { get; } 

        int PageSize { get; }

        int TotalCount { get; }

        Uri? PreviousPageUrl { get; }

        Uri? NextPageUrl { get; }
    }
}
