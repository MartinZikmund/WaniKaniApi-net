using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Summaries
{
    public class Summary
    {
        [JsonPropertyName("lessons")]
        public List<SummaryItem> Lessons { get; set; } = new List<SummaryItem>();

        [JsonPropertyName("reviews")]
        public List<SummaryItem> Reviews { get; set; } = new List<SummaryItem>();

        [JsonPropertyName("next_reviews_at")]
        public DateTimeOffset? NextReviewsAt { get; set; }
    }
}
