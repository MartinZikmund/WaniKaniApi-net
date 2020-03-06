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

        public Task<StudyMaterial[]> GetAllAsync(StudyMaterialsFilter? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<StudyMaterial> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
