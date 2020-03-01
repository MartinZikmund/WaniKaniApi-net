using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubjectType
    {
        Kanji,
        Radical,
        Vocabulary
    }
}
