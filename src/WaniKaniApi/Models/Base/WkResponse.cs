using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Base
{
    public class WkResponse<T>
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("data_updated_at")]
        public DateTime DataUpdatedAt { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
