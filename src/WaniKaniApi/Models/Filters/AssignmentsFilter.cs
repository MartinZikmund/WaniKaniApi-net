using System;
using System.Collections.Generic;
using System.Text;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    /// <summary>
    /// The collection of assignments will be filtered on the parameters provided.
    /// Properties default to null - filter not used.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AssignmentsFilter : FilterBase
    {
        /// <summary>
        /// Only assignments available at or after this time are returned.
        /// </summary>
        [QueryStringName("available-after")]
        public DateTimeOffset? AvailableAfter { get; set; }

        /// <summary>
        /// Only assignments available at or before this time are returned.
        /// </summary>
        [QueryStringName("available-before")]
        public DateTimeOffset? AvailableBefore { get; set; }

        /// <summary>
        /// When set to true, returns assignments that have a value in data.burned_at. 
        /// Returns assignments with a null data.burned_at if false.
        /// </summary>
        [QueryStringName("burned")]
        public bool? Burned { get; set; }

        /// <summary>
        /// Return assignments with a matching value in the hidden attribute.
        /// </summary>
        [QueryStringName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Only assignments where data.id matches one of the array values are returned.
        /// </summary>
        [QueryStringName("ids")]
        public List<int>? Ids { get; set; } = new List<int>();

        /// <summary>
        /// Returns assignments which are immediately available for lessons
        /// when set.
        /// </summary>
        [QueryStringName("immediately_available_for_lessons")]
        public bool? ImmediatelyAvailableForLessons { get; set; }

        /// <summary>
        /// Returns assignments which are immediately available for review
        /// when set.
        /// </summary>
        [QueryStringName("immediately_available_for_review")]
        public bool? ImmediatelyAvailableForReview { get; set; }

        /// <summary>
        /// Returns assignments which are in the review state when set.
        /// </summary>
        [QueryStringName("in_review")]
        public bool? InReview { get; set; }

        /// <summary>
        /// Only assignments where the associated subject level 
        /// matches one of the array values are returned. Valid values 
        /// range from 1 to 60.
        /// </summary>
        [QueryStringName("levels")]
        public List<int>? Levels { get; set; } = new List<int>();

        /// <summary>
        /// Returns assignments where data.passed equals passed.
        /// </summary>
        [QueryStringName("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// Only assignments where data.srs_stage matches one of the array 
        /// values are returned. Valid values range from 0 to 9.
        /// </summary>
        [QueryStringName("srs_stages")]
        public List<int>? SrsStages { get; set; } = new List<int>();

        /// <summary>
        /// When set to true, returns assignments that have a value in 
        /// data.started_at. Returns assignments with a null data.started_at 
        /// if false.
        /// </summary>
        [QueryStringName("started")]
        public bool? Started { get; set; }

        /// <summary>
        /// Only assignments where data.subject_id matches 
        /// one of the array values are returned.
        /// </summary>
        [QueryStringName("subject_ids")]
        public List<int>? SubjectIds { get; set; } = new List<int>();

        /// <summary>
        /// Only assignments where data.subject_type matches one of the array 
        /// values are returned. Valid values are: radical, kanji, or vocabulary.
        /// </summary>
        [QueryStringName("subject_types")]
        public List<SubjectType>? SubjectTypes { get; set; } = new List<SubjectType>();

        /// <summary>
        /// When set to true, returns assignments that have a value in data.unlocked_at. 
        /// Returns assignments with a null data.unlocked_at if false.
        /// </summary>
        [QueryStringName("unlocked")]
        public bool? Unlocked { get; set; }

        /// <summary>
        /// Only assignments updated after this time are returned.
        /// </summary>
        [QueryStringName("updated_after")]
        public DateTimeOffset? UpdatedAfter { get; set; }
    }
}
