using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class KanjiReading : ReadingBase
    {
        [JsonPropertyName("type")]
        public ReadingType Type { get; set; }
    }
}
