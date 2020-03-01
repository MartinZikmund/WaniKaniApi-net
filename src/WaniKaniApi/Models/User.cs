using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Users
{
    public class User
    {
        /// <summary>
        /// The user's ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The user's username.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; } = null!;

        /// <summary>
        /// The current level of the user. This ignores subscription status.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// User settings specific to the WaniKani application.
        /// </summary>
        [JsonPropertyName("preferences")]
        public Preferences Preferences { get; set; } = null!;

        /// <summary>
        /// The URL to the user's public facing profile page.
        /// </summary>
        [JsonPropertyName("profile_url")]
        public Uri ProfileUrl { get; set; } = null!;

        /// <summary>
        /// The signup date for the user.
        /// </summary>
        [JsonPropertyName("started_at")]
        public DateTimeOffset StartedAt { get; set; }

        /// <summary>
        /// Details about the user's subscription state.
        /// </summary>
        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; } = null!;

        /// <summary>
        /// If the user is on vacation, this will be the timestamp of when 
        /// that vacation started. If the user is not on vacation, this is null.
        /// </summary>
        [JsonPropertyName("current_vacation_started_at")]
        public DateTimeOffset? CurrentVacationStartedAt { get; set; }
    }
}