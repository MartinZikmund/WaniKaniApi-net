using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Base;

namespace WaniKaniApi.Api
{
    public abstract class ApiBase
    {
        public ApiBase(HttpClient client)
        {
            Client = client;
        }

        protected HttpClient Client { get; }

        public async Task<T> GetObjectResponseAsync<T>(string relativeUri)
        {
            var response = await Client.GetStringAsync(relativeUri);
            var wrappedResponse = JsonSerializer.Deserialize<WkResponse<T>>(response);
            return wrappedResponse.Data;
        }

        public async Task<T[]> GetCollectionResponseAsync<T>(string relativeUri)
        {
            var response = await Client.GetStringAsync(relativeUri);
            var wrappedResponse = JsonSerializer.Deserialize<WkCollectionResponse<T>>(response);
            return wrappedResponse.Data.Select(d => d.Data).ToArray();
        }
    }
}
