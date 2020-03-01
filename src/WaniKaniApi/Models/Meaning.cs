using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class Meaning
    {
        [JsonPropertyName("meaning")]
        public string Text { get; set; } = null!;

        [JsonPropertyName("primary")]
        public bool Primary { get; set; }

        [JsonPropertyName("accepted_answer")]
        public bool AcceptedAnswer { get; set; }
    }
}
