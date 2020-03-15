using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    [Preserve(AllMembers = true)]
    public class ReviewsFilter : FilterBase
    {
        [QueryStringName("assignment_ids")]
        public int[]? AssignmentIds { get; set; }

        [QueryStringName("ids")]
        public int[]? Ids { get; set; }

        [QueryStringName("subject_ids")]
        public int[]? SubjectIds { get; set; }

        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
