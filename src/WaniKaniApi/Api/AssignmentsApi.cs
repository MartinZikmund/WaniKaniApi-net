using System;
using System.Net.Http;
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

        public async Task<IPagedCollection<Assignment>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<Assignment>(pageUrl);        

        public Task<Assignment> GetAsync(int id) => GetObjectResponseAsync<Assignment>($"assignments/{id}");

        public async Task<Assignment> StartAsync(int id, DateTimeOffset? startedAt = null)
        {
            var content = startedAt != null ?
                CreateJsonContent(new AssignmentStartParameters() { StartedAt = startedAt }) :
                CreateJsonContent<object?>(null);

            var response = await Client.PutAsync($"assignments/{id}/start", content);
            return await ReadObjectResponseAsync<Assignment>(response);
        }

        public async Task<IPagedCollection<Assignment>> GetAllAsync(AssignmentsFilter? filter) =>
            await GetPagedResponseAsync<Assignment>("assignments", filter);
    }
}
