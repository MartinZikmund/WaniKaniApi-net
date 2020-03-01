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
        /// <summary>
        /// The level of the progression, with possible values from 1 to 60.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Timestamp when the level progression is created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the user passes at least 90% of the assignments 
        /// with a type of kanji belonging to the associated subject's level.
        /// </summary>
        [JsonPropertyName("passed_at")]
        public DateTimeOffset? PassedAt { get; set; }

        /// <summary>
        /// Timestamp when the user starts their first 
        /// lesson of a subject belonging to the level.
        /// </summary>
        [JsonPropertyName("started_at")]
        public DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when the user can access lessons and reviews for the level.
        /// </summary>
        [JsonPropertyName("unlocked_at")]
        public DateTimeOffset? UnlockedAt { get; set; }

        /// <summary>
        /// Timestamp when the user burns 100% of the assignments 
        /// belonging to the associated subject's level.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Timestamp when the user abandons the level. 
        /// This is primary used when the user initiates a reset.
        /// </summary>
        [JsonPropertyName("abandoned_at")]
        public DateTimeOffset? AbandonedAt { get; set; }
    }
}
