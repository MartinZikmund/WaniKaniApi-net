using System;
using System.Collections.Generic;
using System.Text;

namespace WaniKaniApi.Models.Filters
{
    internal interface IFilter
    {
        string BuildQueryString();
    }
}
