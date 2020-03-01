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
        /// <summary>
        /// The kind of object returned. See the object types section below for all the kinds.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; } = null!;

        /// <summary>
        /// The URL of the request. For collections, that will contain all the filters and options 
        /// you've passed to the API. Resources have a single URL and don't need to be filtered, 
        /// so the URL will be the same in both resource and collection responses.
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; } = null!;

        /// <summary>
        /// For collections, this is the timestamp of the most recently updated resource in the specified 
        /// scope and is not limited by pagination. For a resource, then this is the last time that particular 
        /// resource was updated.
        /// </summary>
        [JsonPropertyName("data_updated_at")]
        public DateTimeOffset DataUpdatedAt { get; set; }

        /// <summary>
        /// For collections, this is going to be the resources returned by the specified scope. For resources, 
        /// these are the attributes that are specific to that particular instance and kind of resource.
        /// </summary>
        [JsonPropertyName("data")]
        public T Data { get; set; } = default(T)!;
    }
}
