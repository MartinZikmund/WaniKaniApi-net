using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    public class LevelProgressionsFilter
    {
        /// <summary>
        /// Only level progressions where data.id 
        /// matches one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Only level_progressions updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
