using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Users
{
    public class Subscription
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("max_level_granted")]
        public int MaxLevelGranted { get; set; }

        [JsonPropertyName("period_ends_at")]
        public DateTimeOffset? PeriodEndsAt { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;
    }
}
