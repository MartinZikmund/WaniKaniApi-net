using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models.Summaries;

namespace WaniKaniApi.Api
{
    public class SummaryApi : ApiBase, ISummaryApi
    {
        public SummaryApi(HttpClient client) : base(client)
        {
        }

        public async Task<Summary> GetAsync() =>
            await GetObjectResponseAsync<Summary>("summary");
    }
}
