using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.Api
{
    public class ReviewStatisticsApi : ApiBase, IReviewStatisticsApi
    {
        public ReviewStatisticsApi(HttpClient client) : base(client)
        {
        }

        public async Task<ReviewStatistic> GetReviewStatisticAsync(int id) =>
          await GetObjectResponseAsync<ReviewStatistic>($"review_statistics/{id}");

        public Task<ReviewStatistic[]> GetReviewStatisticsAsync()
        {
            throw new NotImplementedException();
        }

    }
}
