using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    public class ReviewStatisticsFilter : FilterBase
    {
        [QueryStringName("hidden")]
        public bool? Hidden { get; set; }

        [QueryStringName("ids")]
        public int[]? Ids { get; set; }

        [QueryStringName("percentages_greater_than")]
        public int? PercentagesGreaterThan { get; set; }

        [QueryStringName("subject_ids")]
        public int[]? SubjectIds { get; set; }

        [QueryStringName("subject_types")]
        public string[]? SubjectTypes { get; set; }

        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
