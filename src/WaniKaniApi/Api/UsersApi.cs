using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Models.Base;
using WaniKaniApi.Models.Users;

namespace WaniKaniApi.Api
{
    public class UsersApi : ApiBase, IUsersApi
    {
        public UsersApi(HttpClient client) : base(client)
        {
        }

        public async Task<User> GetAsync() =>
            await GetObjectResponseAsync<User>("user");

        public async Task<Preferences> UpdatePreferencesAsync(Preferences preferences)
        {
            var user = new User() { Preferences = preferences };
            var serialized = JsonSerializer.Serialize(user);
            var content = new StringContent(serialized, Encoding.UTF8, "application/json");
            var response = await Client.PutAsync("user", content);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var wrappedResponse = JsonSerializer.Deserialize<WkResponse<User>>(stringResponse);
            return wrappedResponse.Data.Preferences;
        }
    }
}
