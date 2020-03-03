using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Base;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi
{
    public class WaniKaniClient : IWaniKaniClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;

        public WaniKaniClient(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.wanikani.com/v2/"),
                DefaultRequestHeaders = {
                    Authorization = new AuthenticationHeaderValue("Bearer", _apiKey)
                },
            };
        }

        public async Task<SrsStage[]> GetSrsStagesAsync() => 
            await GetCollectionResponseAsync<SrsStage>("srs_stages");

        public async Task<User> GetUserAsync() => 
            await GetObjectResponseAsync<User>("user");

        public async Task<User> UpdateUserPreferencesAsync(Preferences preferences)
        {
            var user = new User() { Preferences = preferences };
            var serialized = JsonSerializer.Serialize(user);
            var content = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("user", content);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var wrappedResponse = JsonSerializer.Deserialize<WkResponse<User>>(stringResponse);
            return wrappedResponse.Data;
        }

        public async Task<Reset> GetResetAsync(int id) =>
            await GetObjectResponseAsync<Reset>($"resets/{id}");

        public async Task<Reset[]> GetResetsAsync() =>
            await GetCollectionResponseAsync<Reset>($"resets");        

        public async Task<T> GetObjectResponseAsync<T>(string relativeUri)
        {
            var response = await _client.GetStringAsync(relativeUri);
            var wrappedResponse = JsonSerializer.Deserialize<WkResponse<T>>(response);
            return wrappedResponse.Data;
        }

        public async Task<T[]> GetCollectionResponseAsync<T>(string relativeUri)
        {
            var response = await _client.GetStringAsync(relativeUri);
            var wrappedResponse = JsonSerializer.Deserialize<WkCollectionResponse<T>>(response);
            return wrappedResponse.Data.Select(d=>d.Data).ToArray();
        }

        public async Task<ReviewStatistic> GetReviewStatisticAsync(int id) =>
            await GetObjectResponseAsync<ReviewStatistic>($"review_statistics/{id}");

        public Task<ReviewStatistic[]> GetReviewStatisticsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
