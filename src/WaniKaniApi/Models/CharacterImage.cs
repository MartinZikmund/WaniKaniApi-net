using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class CharacterImage
    {
        /// <summary>
        /// The location of the image.
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; } = null!;

        /// <summary>
        /// The content type of the image. 
        /// Currently the API delivers image/png and image/svg+xml.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; } = null!;

        /// <summary>
        /// Details about the image. Each content_type returns a uniquely structured object.
        /// </summary>
        public string Metadata { get; set; } = null!;
    }
}
