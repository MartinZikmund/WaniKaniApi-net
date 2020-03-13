using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    [Preserve(AllMembers = true)]
    public class LevelProgressionsFilter : FilterBase
    {
        /// <summary>
        /// Only level progressions where data.id 
        /// matches one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public int[]? Ids { get; set; }

        /// <summary>
        /// Only level_progressions updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
