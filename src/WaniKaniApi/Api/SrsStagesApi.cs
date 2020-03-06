using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.Api
{
    public class SrsStagesApi : ApiBase, ISrsStagesApi
    {
        public SrsStagesApi(HttpClient client) : base(client)
        {
        }

        /// <summary>
        /// Returns a summary of srs stages.
        /// </summary>
        /// <returns>SRS Stages</returns>
        public async Task<SrsStage[]> GetSrsStagesAsync() =>
            await GetCollectionResponseAsync<SrsStage>("srs_stages");

    }
}
