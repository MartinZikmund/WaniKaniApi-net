using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface IVoiceActorsApi
    {
        Task<IPagedCollection<VoiceActor>> GetAllAsync(VoiceActorsFilter? filter = null);

        Task<IPagedCollection<VoiceActor>> GetAllAsync(Uri pageUrl);

        Task<VoiceActor> GetAsync(int id);
    }
}
