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
        Task<IPagedCollection<Review>> GetAllAsync(ReviewsFilter? filter = null);

        Task<IPagedCollection<Review>> GetAllAsync(Uri pageUrl);

        Task<Review> GetAsync(int id);

        Task<Review> CreateAsync(Review review);
    }
}
