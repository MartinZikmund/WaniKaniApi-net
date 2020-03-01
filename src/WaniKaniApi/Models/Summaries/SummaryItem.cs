using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Summaries
{
    public class SummaryItem
    {
        [JsonPropertyName("available_at")]
        public DateTimeOffset AvailableAt { get; set; }

        [JsonPropertyName("subject_ids")]
        public List<int> SubjectIds { get; set; } = new List<int>();
    }
}
