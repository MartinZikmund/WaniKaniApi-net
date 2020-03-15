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
    public class StudyMaterialsApi : ApiBase, IStudyMaterialsApi
    {
        public StudyMaterialsApi(HttpClient client) : base(client)
        {
        }

        public async Task<StudyMaterial> GetAsync(int id) =>
            await GetObjectResponseAsync<StudyMaterial>("study_materials");

        public async Task<IPagedCollection<StudyMaterial>> GetAllAsync(StudyMaterialsFilter? filter = null) =>
            await GetPagedResponseAsync<StudyMaterial>("study_materials", filter);

        public async Task<IPagedCollection<StudyMaterial>> GetAllAsync(Uri pageUrl) =>
            await GetPagedResponseAsync<StudyMaterial>(pageUrl);
    }
}
