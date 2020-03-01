using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Users
{
    public class Preferences
    {
        /// <summary>
        /// The voice actor to be used for lessons and reviews. 
        /// The value is associated to subject.pronunciation_audios.metadata.voice_actor_id
        /// </summary>
        [JsonPropertyName("default_voice_actor_id")]
        public int DefaultVoiceActorId { get; set; }

        /// <summary>
        /// Automatically play pronunciation audio for vocabulary during lessons.
        /// </summary>
        [JsonPropertyName("lessons_autoplay_audio")]
        public bool LessonsAutoplayAudio { get; set; }

        /// <summary>
        /// Number of subjects introduced to the user during lessons before quizzing.
        /// </summary>
        [JsonPropertyName("lessons_batch_size")]
        public int LessonsBatchSize { get; set; }

        /// <summary>
        /// The order in which lessons are presented. 
        /// The options are ascending_level_then_subject, shuffled, 
        /// and ascending_level_then_shuffled. 
        /// The default (and best experience) is ascending_level_then_subject.
        /// </summary>
        [JsonPropertyName("lessons_presentation_order")]
        public string LessonsPresentationOrder { get; set; } = null!;

        /// <summary>
        /// Automatically play pronunciation audio for vocabulary during reviews.
        /// </summary>
        [JsonPropertyName("reviews_autoplay_audio")]
        public bool ReviewsAutoplayAudio { get; set; }

        /// <summary>
        /// Toggle for display SRS change indicator after 
        /// a subject has been completely answered during review.
        /// </summary>
        [JsonPropertyName("reviews_display_srs_indicator")]
        public bool ReviewsDisplaySrsIndicator { get; set; }
    }
}
