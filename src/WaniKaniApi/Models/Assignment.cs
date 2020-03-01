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
        /// <summary>
        /// The stage name associated current SRS stage.
        /// </summary>
        [JsonPropertyName("srs_stage_name")]
        public string SrsStageName { get; set; } = null!;

        /// <summary>
        /// The current SRS stage interval, from 0 to 9.
        /// </summary>
        [JsonPropertyName("srs_stage")]
        public int SrsStageId { get; set; }

        /// <summary>
        /// The type of the associated subject, one of: kanji, radical, or vocabulary.
        /// </summary>
        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; } = null!;

        /// <summary>
        /// Unique identifier of the associated subject.
        /// </summary>
        [JsonPropertyName("subject_id")]
        public int SubjectId { get; set; }

        /// <summary>
        /// The boolean equivalent of passed_at
        /// </summary>
        [JsonPropertyName("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// Timestamp when the assignment was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the subject is resurrected 
        /// and placed back in the user's review queue.
        /// </summary>
        [JsonPropertyName("resurrected_at")]
        public DateTimeOffset? ResurrectedAt { get; set; }

        [JsonPropertyName("unlocked_at")]
        public DateTimeOffset? UnlockedAt { get; set; }

        /// <summary>
        /// Timestamp when the user completes the lesson for the related subject.
        /// </summary>
        [JsonPropertyName("started_at")]
        public DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when the user reaches SRS stage 5 for the first time.
        /// </summary>
        [JsonPropertyName("passed_at")]
        public DateTimeOffset? PassedAt { get; set; }

        /// <summary>
        /// Timestamp when the related subject will be available in the user's review queue.
        /// </summary>
        [JsonPropertyName("available_at")]
        public DateTimeOffset? AvailableAt { get; set; }

        /// <summary>
        /// Timestamp when the user reaches SRS stage 9 the first time.
        /// </summary>
        [JsonPropertyName("burned_at")]
        public DateTimeOffset? BurnedAt { get; set; }

        /// <summary>
        /// Indicates if the associated subject has been hidden, 
        /// preventing it from appearing in lessons or reviews.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }
    }
}
