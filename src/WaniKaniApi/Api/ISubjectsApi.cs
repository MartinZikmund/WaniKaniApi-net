using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Filters;

namespace WaniKaniApi.Api
{
    public interface ISubjectsApi
    {
        /// <summary>
        /// Returns a collection of all subjects, ordered by ascending created_at, 1000 at a time.
        /// </summary>
        /// <param name="filter">Filter.</param>
        /// <returns>Subjects.</returns>
        Task<Subject[]> GetAllAsync(SubjectsFilter? filter = null);

        /// <summary>
        /// Retrieves a specific subject by its id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Subject.</returns>
        Task<Subject> GetAsync(int id);
    }
}
