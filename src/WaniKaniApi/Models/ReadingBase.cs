using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public abstract class ReadingBase
    {
        /// <summary>
        /// A singular subject reading.
        /// </summary>
        [JsonPropertyName("reading")]
        public string Text { get; set; } = null!;

        /// <summary>
        /// Indicates priority in the WaniKani system.
        /// </summary>
        [JsonPropertyName("primary")]
        public bool Primary { get; set; }

        /// <summary>
        /// Indicates if the reading is used to evaluate user input for correctness.
        /// </summary>
        [JsonPropertyName("accepted_answer")]
        public bool AcceptedAnswer { get; set; }
    }
}
