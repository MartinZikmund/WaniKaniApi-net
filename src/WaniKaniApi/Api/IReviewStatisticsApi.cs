using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface IReviewStatisticsApi
    {
        Task<ReviewStatistic> GetReviewStatisticAsync(int id);

        Task<IPagedCollection<ReviewStatistic>> GetReviewStatisticsAsync(ReviewStatisticsFilter filter = null);

        Task<IPagedCollection<ReviewStatistic>> GetReviewStatisticsAsync(Uri pageUrl);
    }
}
