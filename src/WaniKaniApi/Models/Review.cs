using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Review
    {
        [JsonPropertyName("assignment_id")]
        public int AssignmentId { get; set; }

        [JsonPropertyName("subject_id")]
        public int SubjectId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("starting_srs_stage")]
        public int StartingSrsStageId { get; set; }

        [JsonPropertyName("starting_srs_stage_name")]
        public string StartingSrsStageName { get; set; } = null!;

        [JsonPropertyName("ending_srs_stage")]
        public int EndingSrsStageId { get; set; }

        [JsonPropertyName("ending_srs_stage_name")]
        public int EndingSrsStageName { get; set; }

        [JsonPropertyName("incorrect_meaning_answers")]
        public int IncorrectMeaningAnswers { get; set; }

        [JsonPropertyName("incorrect_reading_answers")]
        public int IncorrectReadingAnswers { get; set; }        
    }
}
