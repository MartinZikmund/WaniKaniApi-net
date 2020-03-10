using System;
using System.Text.Json.Serialization;

namespace WaniKaniApi.Models.Parameters
{
    public class AssignmentStartParameters
    {
        [JsonPropertyName("started_at")]
        internal DateTimeOffset? StartedAt { get; set; }
    }
}
