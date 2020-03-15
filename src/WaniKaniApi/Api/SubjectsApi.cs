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

        public async Task<IPagedCollection<Subject>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<Subject>(pageUrl);

        public async Task<Subject> GetAsync(int id) =>
            await GetObjectResponseAsync<Subject>($"subjects/{id}");

        public async Task<IPagedCollection<Subject>> GetAllAsync(SubjectsFilter? filter) =>
            await GetPagedResponseAsync<Subject>("subjects", filter);
    }
}
