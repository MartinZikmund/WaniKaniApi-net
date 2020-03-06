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
    public class SubjectsApi : ApiBase, ISubjectsApi
    {
        public SubjectsApi(HttpClient client) : base(client)
        {
        }

        public Task<Subject[]> GetAllAsync(SubjectsFilter? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
