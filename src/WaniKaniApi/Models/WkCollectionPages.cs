using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class WkCollectionPages
    {
        [JsonPropertyName("next_url")]
        public Uri? NextUrl { get; set; }

        [JsonPropertyName("previous_url")]
        public Uri? PreviousUrl { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }
    }
}
