using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi
{
    public interface IWaniKaniClient
    {
        Task<User> GetUserAsync();

        Task<ReviewStatistic> GetReviewStatisticAsync(int id);

        Task<ReviewStatistic[]> GetReviewStatisticsAsync();

        Task<Reset> GetResetAsync(int id);

        Task<Reset[]> GetResetsAsync();

        Task<SrsStage[]> GetSrsStagesAsync(); 

        Task<User> UpdateUserPreferencesAsync(Preferences preferences);
    }
}
