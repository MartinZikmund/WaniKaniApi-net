using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class AuxiliaryMeaning
    {
        [JsonPropertyName("meaning")]
        public string Text { get; set; } = null!;

        [JsonPropertyName("type")]
        public AuxiliaryMeaningType Type { get; set; }
    }
}
