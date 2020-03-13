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
        public List<int>? AssignmentIds { get; set; }

        [QueryStringName("ids")]
        public List<int>? Ids { get; set; }

        [QueryStringName("subject_ids")]
        public List<int>? SubjectIds { get; set; }

        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
