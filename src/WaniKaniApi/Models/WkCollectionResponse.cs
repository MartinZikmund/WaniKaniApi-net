using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WaniKaniApi.Models.Base;

namespace WaniKaniApi.Models
{
    public class WkCollectionResponse<T> : WkResponse<List<T>>
    {
        [JsonPropertyName("pages")]
        public WkCollectionPages Pages { get; set; } = null!;

        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
