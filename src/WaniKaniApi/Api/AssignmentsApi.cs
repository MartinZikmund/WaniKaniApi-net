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
    public class AssignmentsApi : ApiBase, IAssignmentsApi
    {
        public AssignmentsApi(HttpClient client) : base(client)
        {
        }

        public Task<Assignment[]> GetAllAsync(AssignmentsFilter? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Assignment> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Assignment> StartAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
