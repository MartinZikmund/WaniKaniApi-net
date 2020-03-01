using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Reset
    {
        [JsonPropertyName("original_level")]
        public int OriginalLevel { get; set; }

        [JsonPropertyName("target_level")]
        public int TargetLevel { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("confirmed_at")]
        public DateTimeOffset? ConfirmedAt { get; set; }
    }
}
