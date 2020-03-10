using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;
using WaniKaniApi.Models.Parameters;

namespace WaniKaniApi.Api
{
    public class AssignmentsApi : ApiBase, IAssignmentsApi
    {
        public AssignmentsApi(HttpClient client) : base(client)
        {
        }

        public Task<Assignment> GetAsync(int id) => GetObjectResponseAsync<Assignment>($"assignments/{id}");

        public async Task<Assignment> StartAsync(int id, DateTimeOffset? startedAt = null)
        {
            var content = startedAt != null ?
                CreateJsonContent(new AssignmentStartParameters() { StartedAt = startedAt }) :
                CreateJsonContent<object?>(null);

            var response = await Client.PutAsync($"assignments/{id}/start", content);
            return await ReadObjectResponseAsync<Assignment>(response);
        }

        Task<IPagedCollection<Assignment>> GetAllAsync(AssignmentsFilter? filter)
        {
            var content = CreateJsonContent(filter);
            var url = CreateQuery(filter);
        }
    }
}
