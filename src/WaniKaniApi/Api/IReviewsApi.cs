using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface IReviewsApi
    {
        Task<Review[]> GetAllAsync(ReviewsFilter? filter = null);

        Task<Review> GetAsync(int id);

        Task<Review> CreateAsync(Review review);
    }
}
