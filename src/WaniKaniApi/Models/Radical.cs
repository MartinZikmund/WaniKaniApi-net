using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Radical : SubjectBase
    {
        /// <summary>
        /// An array of numeric identifiers for the kanji that have the radical as a component.
        /// </summary>
        [JsonPropertyName("amalgamation_subject_ids")]
        public List<int> AmalgamationSubjectIds { get; set; } = new List<int>();

        /// <summary>
        /// Unlike kanji and vocabulary, radicals can have a null value for characters. 
        /// Not all radicals have a UTF entry, so the radical must be visually represented 
        /// with an image instead.
        /// </summary>
        [JsonPropertyName("characters")]
        public string? Characters { get; set; };

        /// <summary>
        /// A collection of images of the radical. See table below for the object structure.
        /// </summary>
        [JsonPropertyName("character_images")]
        public List<CharacterImage> CharacterImages { get; set; } = new List<CharacterImage>();
    }
}
