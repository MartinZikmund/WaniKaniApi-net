using System;
using System.Collections.Generic;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    public class StudyMaterialsFilter
    {
        /// <summary>
        /// Return study materials with a matching 
        /// value in the hidden attribute.
        /// </summary>
        [QueryStringName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Only study material records where data.id 
        /// matches one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public List<int>? Ids { get; set; }

        /// <summary>
        /// Only study material records where data.subject_id 
        /// matches one of the array values are returned.
        /// </summary>
        [QueryStringName("subject_ids")]
        public List<int>? SubjectIds { get; set; }

        /// <summary>
        /// Only study material records where data.subject_type 
        /// matches one of the array values are returned. 
        /// Valid values are: radical, kanji, or vocabulary.
        /// </summary>
        [QueryStringName("subject_types")]
        public List<SubjectType>? SubjectTypes { get; set; }

        /// <summary>
        /// Only study material records updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
