using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class ContextSentence
    {
        [JsonPropertyName("en")]
        public string English { get; set; }

        [JsonPropertyName("ja")]
        public string Japanese { get; set; }
    }
}
