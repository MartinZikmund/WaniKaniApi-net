using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;

namespace WaniKaniApi.Api
{
    public interface ISrsStagesApi
    {
        Task<SrsStage[]> GetSrsStagesAsync();
    }
}
