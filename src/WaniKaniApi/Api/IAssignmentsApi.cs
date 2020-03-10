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
        Task<IPagedCollection<Assignment>> GetAllAsync(AssignmentsFilter? filter = null);

        Task<IPagedCollection<Assignment>> GetAllAsync(Uri? pageUrl = null);

        Task<Assignment> GetAsync(int id);

        Task<Assignment> StartAsync(int id, DateTimeOffset? startedAt = null);
    }
}
