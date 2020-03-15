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
        Task<IPagedCollection<StudyMaterial>> GetAllAsync(StudyMaterialsFilter? filter = null);

        Task<IPagedCollection<StudyMaterial>> GetAllAsync(Uri pageUrl);

        Task<StudyMaterial> GetAsync(int id);
    }
}
