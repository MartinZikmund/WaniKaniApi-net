using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public abstract class Subject
    {
        public abstract SubjectType Type { get; }

        /// <summary>
        /// Timestamp when the subject was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the subject was hidden, indicating associated 
        /// assignments will no longer appear in lessons or reviews 
        /// and that the subject page is no longer visible on wanikani.com.
        /// </summary>
        [JsonPropertyName("hidden_at")]
        public DateTimeOffset? HiddenAt { get; set; }
        
        /// <summary>
        /// A URL pointing to the page on wanikani.com 
        /// that provides detailed information about this subject.
        /// </summary>
        [JsonPropertyName("document_url")]
        public Uri DocumentUrl { get; set; } = null!;

        /// <summary>
        /// The position that the subject appears in lessons. 
        /// Note that the value is scoped to the level of the subject, 
        /// so there are duplicate values across levels.
        /// </summary>
        [JsonPropertyName("lesson_position")]
        public int LessonPosition { get; set; }

        /// <summary>
        /// The level of the subject, from 1 to 60.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// The subject's meaning mnemonic.
        /// </summary>
        [JsonPropertyName("meaning_mnemonic")]
        public string MeaningMnemonic { get; set; } = null!;

        /// <summary>
        /// The subject meanings.
        /// </summary>
        [JsonPropertyName("meanings")]
        public List<Meaning> Meanings { get; set; } = new List<Meaning>();

        /// <summary>
        /// Collection of auxiliary meanings.
        /// </summary>
        public List<AuxiliaryMeaning> AuxiliaryMeanings { get; set; } = new List<AuxiliaryMeaning>();

        /// <summary>
        /// The string that is used when generating the document URL for the subject. 
        /// Radicals use their meaning, downcased. Kanji and vocabulary use their characters.
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; } = null!;
    }
}
