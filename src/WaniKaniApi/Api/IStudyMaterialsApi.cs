using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface IStudyMaterialsApi
    {
        Task<StudyMaterial[]> GetAllAsync(StudyMaterialsFilter? filter = null);

        Task<StudyMaterial> GetAsync(int id);
    }
}
