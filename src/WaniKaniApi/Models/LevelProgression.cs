using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class LevelProgression
    {
        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("passed_at")]
        public DateTimeOffset? PassedAt { get; set; }

        [JsonPropertyName("started_at")]
        public DateTimeOffset? StartedAt { get; set; }
        
        [JsonPropertyName("unlocked_at")]
        public DateTimeOffset? UnlockedAt { get; set; }

        [JsonPropertyName("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        [JsonPropertyName("abandoned_at")]
        public DateTimeOffset? AbandonedAt { get; set; }
    }
}
