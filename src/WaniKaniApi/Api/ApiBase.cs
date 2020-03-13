using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Base;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public abstract class ApiBase
    {
        private const string JsonContentType = "application/json";

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

        protected async Task<T> ReadObjectResponseAsync<T>(HttpResponseMessage response)
        {
            var serializedResponse = await response.Content.ReadAsStringAsync();
            var wrappedResponse = JsonSerializer.Deserialize<WkResponse<T>>(serializedResponse);
            return wrappedResponse.Data;
        }

        public async Task<IPagedCollection<T>> ReadPagedResponseAsync<T>(HttpResponseMessage response)
        {
            var serializedResponse = await response.Content.ReadAsStringAsync();
            var wrappedResponse = JsonSerializer.Deserialize<WkCollectionResponse<T>>(serializedResponse);
            return new PagedCollection<T>(
                wrappedResponse.Data.Select(d => d.Data).ToArray(),
                wrappedResponse.Pages,
                wrappedResponse.TotalCount);
        }

        protected async Task<IPagedCollection<T>> GetPagedResponseAsync<T>(string relativeUri, IFilter? filter = null)
        {
            var queryString = filter?.BuildQueryString() ?? string.Empty;
            var response = await Client.GetAsync($"level_progressions{queryString}");
            return await ReadPagedResponseAsync<T>(response);
        }
        
        protected async Task<IPagedCollection<T>> GetPagedResponseAsync<T>(Uri pageUrl)
        {
            var response = await Client.GetAsync(pageUrl);
            return await ReadPagedResponseAsync<T>(response);
        }

        protected HttpContent CreateJsonContent<T>(T data)
            where T : class?
        {
            string json = data != null ? JsonSerializer.Serialize(data) : string.Empty;
            return new StringContent(json, Encoding.UTF8, JsonContentType);
        }
    }
}
