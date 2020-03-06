using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public class ReviewsApi : ApiBase, IReviewsApi
    {
        public ReviewsApi(HttpClient client) : base(client)
        {
        }

        public Task<Review> CreateAsync(Review review)
        {
            throw new NotImplementedException();
        }

        public Task<Review[]> GetAllAsync(ReviewsFilter? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
