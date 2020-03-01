using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models
{
    public class SrsStage
    {
        [JsonPropertyName("srs_stage")]
        public int Id { get; set; }

        [JsonPropertyName("srs_stage_name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("accelerated_interval")]
        public int AcceleratedInterval { get; set; }
    }
}
