using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Vocabulary : Subject
    {
        public override SubjectType Type => SubjectType.Vocabulary;

        /// <summary>
        /// The UTF-8 characters for the subject, including kanji and hiragana.
        /// </summary>
        [JsonPropertyName("characters")]
        public string Characters { get; set; } = null!;

        /// <summary>
        /// An array of numeric identifiers for the kanji that make up this vocabulary. 
        /// Note that these are the subjects that must be have passed assignments in order 
        /// to unlock this subject's assignment.
        /// </summary>
        [JsonPropertyName("component_subject_ids")]
        public List<int> ComponentSubjectIds { get; set; } = new List<int>();

        /// <summary>
        /// A collection of context sentences.
        /// </summary>
        [JsonPropertyName("context_sentences")]
        public List<ContextSentence> ContextSentences { get; set; } = new List<ContextSentence>();

        /// <summary>
        /// Parts of speech.
        /// </summary>
        [JsonPropertyName("parts_of_speech")]
        public List<string> PartsOfSpeech { get; set; } = new List<string>();

        /// <summary>
        /// A collection of pronunciation audio.
        /// </summary>
        [JsonPropertyName("pronunciation_audios")]
        public List<PronunciationAudio> PronunciationAudios { get; set; } = new List<PronunciationAudio>();

        /// <summary>
        /// Selected readings for the vocabulary.
        /// </summary>
        [JsonPropertyName("readings")]
        public List<VocabularyReading> Readings { get; set; } = new List<VocabularyReading>();

        /// <summary>
        /// The subject's reading mnemonic.
        /// </summary>
        [JsonPropertyName("reading_mnemonic")]
        public string ReadingMnemonic { get; set; } = null!;
    }
}
