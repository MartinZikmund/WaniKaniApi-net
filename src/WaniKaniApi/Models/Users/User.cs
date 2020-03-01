using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Users
{
    public class User
    {
        [JsonPropertyName("current_vacation_started_at")]
        public DateTimeOffset? CurrentVacationStartedAt { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }
        
        [JsonPropertyName("preferences")]
        public Preferences Preferences { get; set; } = null!;

        [JsonPropertyName("started_at")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; } = null!;

        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;
    }
}