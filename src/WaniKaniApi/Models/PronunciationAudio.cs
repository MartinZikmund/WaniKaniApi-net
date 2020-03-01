using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class PronunciationAudio
    {
        /// <summary>
        /// The location of the audio.
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; } = null!;

        /// <summary>
        /// The content type of the audio. Currently the API delivers audio/mpeg and audio/ogg.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; } = null!;

        /// <summary>
        /// Details about the pronunciation audio.
        /// </summary>
        [JsonPropertyName("metadata")]
        public PronunciationAudioMetadata Metadata { get; set; } = null!;
    }
}
