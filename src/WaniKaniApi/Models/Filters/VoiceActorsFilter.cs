﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    /// <summary>
    /// The collection of voice_actors will be filtered on the parameters provided.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class VoiceActorsFilter : FilterBase
    {
        /// <summary>
        /// Only voice_actors where data.id matches 
        /// one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public int[]? Ids { get; set; }

        /// <summary>
        /// Only voice_actors updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
