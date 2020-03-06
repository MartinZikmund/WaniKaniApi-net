using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models.Summaries;

namespace WaniKaniApi.Api
{
    public interface ISummaryApi
    {
        Task<Summary> GetAsync();
    }
}
