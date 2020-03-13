using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.Api
{
    public class ResetsApi : ApiBase, IResetsApi
    {
        public ResetsApi(HttpClient client) : base(client)
        {
        }

        public async Task<Reset> GetAsync(int id) =>
            await GetObjectResponseAsync<Reset>($"resets/{id}");

        public async Task<IPagedCollection<Reset>> GetAllAsync() =>
            await GetPagedResponseAsync<Reset>("resets");

        public async Task<IPagedCollection<Reset>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<Reset>(pageUrl);
    }
}
