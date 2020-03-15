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
    public class LevelProgressionsApi : ApiBase, ILevelProgressionsApi
    {
        public LevelProgressionsApi(HttpClient client) : base(client)
        {
        }

        public async Task<IPagedCollection<LevelProgression>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<LevelProgression>(pageUrl);

        public Task<LevelProgression> GetAsync(int id) => GetObjectResponseAsync<LevelProgression>($"level_progressions/{id}");

        public async Task<IPagedCollection<LevelProgression>> GetAllAsync(LevelProgressionsFilter? filter) =>
            await GetPagedResponseAsync<LevelProgression>("level_progressions", filter);
    }
}
