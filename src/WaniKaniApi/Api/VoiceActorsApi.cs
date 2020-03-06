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
    public class VoiceActorsApi : ApiBase, IVoiceActorsApi
    {
        public VoiceActorsApi(HttpClient client) : base(client)
        {
        }

        public Task<VoiceActor[]> GetAllAsync(VoiceActorsFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<VoiceActor> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
