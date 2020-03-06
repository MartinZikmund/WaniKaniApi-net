using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface ILevelProgressionsApi
    {
        Task<LevelProgression[]> GetAllAsync(LevelProgressionsFilter? filter = null);

        Task<LevelProgression> GetAsync(int id);
    }
}
