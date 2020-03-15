using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    /// <summary>
    /// The collection of subjects will be filtered on the parameters provided.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SubjectsFilter : FilterBase
    {
        /// <summary>
        /// Only subjects where data.id matches one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public int[]? Ids { get; set; }

        /// <summary>
        /// Return subjects of the specified types.
        /// </summary>
        [QueryStringName("types")]
        public SubjectType[]? Types { get; set; }

        /// <summary>
        /// Return subjects of the specified slug.
        /// </summary>
        [QueryStringName("slugs")]
        public string[]? Slugs { get; set; }

        /// <summary>
        /// Return subjects at the specified levels.
        /// </summary>
        [QueryStringName("levels")]
        public int[]? Levels { get; set; }

        /// <summary>
        /// Return subjects which are or are not hidden from the user-facing application.
        /// </summary>
        [QueryStringName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Only subjects updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
