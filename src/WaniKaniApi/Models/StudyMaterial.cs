using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class StudyMaterial
    {
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("subject_id")]
        public int SubjectId { get; set; }

        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; } = null!;

        [JsonPropertyName("meaning_note")]
        public string? MeaningNote { get; set; }

        [JsonPropertyName("meaning_synonyms")]
        public List<string> MeaningSynonyms { get; set; } = new List<string>();

        [JsonPropertyName("reading_note")]
        public string? ReadingNote { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }
    }
}
