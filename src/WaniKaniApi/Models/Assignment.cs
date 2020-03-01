using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Assignment
    {
        [JsonPropertyName("srs_stage_name")]
        public string SrsStageName { get; set; } = null!;

        [JsonPropertyName("srs_stage")]
        public int SrsStageId { get; set; }

        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; } = null!;

        [JsonPropertyName("subject_id")]
        public int SubjectId { get; set; }

        [JsonPropertyName("passed")]
        public bool Passed { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("resurrected_at")]
        public DateTimeOffset? ResurrectedAt { get; set; }

        [JsonPropertyName("unlocked_at")]
        public DateTimeOffset? UnlockedAt { get; set; }

        [JsonPropertyName("started_at")]
        public DateTimeOffset? StartedAt { get; set; }

        [JsonPropertyName("passed_at")]
        public DateTimeOffset? PassedAt { get; set; }

        [JsonPropertyName("available_at")]
        public DateTimeOffset? AvailableAt { get; set; }

        [JsonPropertyName("burned_at")]
        public DateTimeOffset? BurnedAt { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }
    }
}
