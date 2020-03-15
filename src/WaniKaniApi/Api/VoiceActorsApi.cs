using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public class VoiceActorsApi : ApiBase, IVoiceActorsApi
    {
        public VoiceActorsApi(HttpClient client) : base(client)
        {
        }

        public async Task<IPagedCollection<VoiceActor>> GetAllAsync(VoiceActorsFilter? filter = null) =>
            await GetPagedResponseAsync<VoiceActor>("voice_actors", filter);

        public async Task<IPagedCollection<VoiceActor>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<VoiceActor>(pageUrl);

        public async Task<VoiceActor> GetAsync(int id) =>
            await GetObjectResponseAsync<VoiceActor>($"voice_actors/{id}");
    }
}
