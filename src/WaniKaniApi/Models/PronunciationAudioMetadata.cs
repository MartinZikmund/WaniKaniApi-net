using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class PronunciationAudioMetadata
    {
        /// <summary>
        /// The gender of the voice actor.
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; } = null!;

        /// <summary>
        /// A unique ID shared between same source pronunciation audio.
        /// </summary>
        [JsonPropertyName("source_id")]
        public int SourceId { get; set; }

        /// <summary>
        /// Vocabulary being pronounced in kana.
        /// </summary>
        [JsonPropertyName("pronunciation")]
        public string Pronunciation { get; set; } = null!;

        /// <summary>
        /// A unique ID belonging to the voice actor.
        /// </summary>
        [JsonPropertyName("voice_actor_id")]
        public int VoiceActorId { get; set; }

        /// <summary>
        /// Humanized name of the voice actor.
        /// </summary>
        [JsonPropertyName("voice_actor_name")]
        public string VoiceActorName { get; set; } = null!;

        /// <summary>
        /// Description of the voice.
        /// </summary>
        [JsonPropertyName("voice_description")]
        public string Description { get; set; } = null!;
    }
}
