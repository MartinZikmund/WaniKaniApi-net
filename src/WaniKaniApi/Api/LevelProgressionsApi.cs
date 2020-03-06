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
    public class LevelProgressionsApi : ApiBase, ILevelProgressionsApi
    {
        public LevelProgressionsApi(HttpClient client) : base(client)
        {
        }

        public Task<LevelProgression[]> GetAllAsync(LevelProgressionsFilter? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<LevelProgression> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
