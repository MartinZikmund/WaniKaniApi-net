using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Kanji : SubjectBase
    {
        /// <summary>
        /// The UTF-8 characters for the subject, including kanji and hiragana.
        /// </summary>
        [JsonPropertyName("characters")]
        public string Characters { get; set; } = null!;

        /// <summary>
        /// An array of numeric identifiers for the kanji that have the radical as a component.
        /// </summary>
        [JsonPropertyName("amalgamation_subject_ids")]
        public List<int> AmalgamationSubjectIds { get; set; } = new List<int>();

        /// <summary>
        /// An array of numeric identifiers for the radicals that make up this kanji. Note that 
        /// these are the subjects that must be have passed assignments in order to unlock this 
        /// subject's assignment.
        /// </summary>
        [JsonPropertyName("component_subject_ids")]
        public List<int> ComponentSubjectIds { get; set; } = new List<int>();

        /// <summary>
        /// Selected readings for the kanji. See table below for the object structure.
        /// </summary>
        [JsonPropertyName("readings")]
        public List<KanjiReading> Readings { get; set; } = new List<KanjiReading>();

        /// <summary>
        /// An array of numeric identifiers for kanji which are visually similar to the kanji in question.
        /// </summary>
        [JsonPropertyName("visually_similar_subject_ids")]
        public List<int> VisuallySimilarSubjectIds { get; set; } = new List<int>();
    }
}
