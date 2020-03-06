using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface IAssignmentsApi
    {
        Task<Assignment[]> GetAllAsync(AssignmentsFilter? filter = null);

        Task<Assignment> GetAsync(int id);

        Task<Assignment> StartAsync(int id);
    }
}
