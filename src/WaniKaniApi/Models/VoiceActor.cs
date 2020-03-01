using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class VoiceActor
    {
        /// <summary>
        /// The voice actor's name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("gender")]
        public string Gender { get; set; } = null!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;
    }
}
