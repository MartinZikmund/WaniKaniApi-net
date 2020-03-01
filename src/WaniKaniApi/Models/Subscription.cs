using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WaniKaniApi.Models.Users
{
    public class Subscription
    {
        /// <summary>
        /// Whether or not the user currently has a paid subscription.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// The maximum level of content accessible to the user for lessons, 
        /// reviews, and content review. For unsubscribed/free users, the maximum 
        /// level is 3. For subscribed users, this is 60. 
        /// Any application that uses data from the WaniKani API must respect these access limits.
        /// </summary>
        [JsonPropertyName("max_level_granted")]
        public int MaxLevelGranted { get; set; }

        /// <summary>
        /// The date when the user's subscription period ends. 
        /// If the user has subscription type lifetime or free then the value is null.
        /// </summary>
        [JsonPropertyName("period_ends_at")]
        public DateTimeOffset? PeriodEndsAt { get; set; }

        /// <summary>
        /// The type of subscription the user has. Options are following: free, recurring, and lifetime.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;
    }
}
