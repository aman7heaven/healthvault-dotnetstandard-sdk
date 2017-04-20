// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.HealthVault.RestApi.Generated.Models
{
    /// <summary>
    /// A goal defines a target for a measurement or action to be performed by
    /// a user.
    /// For example, walk 5000 steps per day, burn 1500 calories per day
    /// </summary>
    public partial class Goal
    {
        /// <summary>
        /// Initializes a new instance of the Goal class.
        /// </summary>
        public Goal()
        {
          this.CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Goal class.
        /// </summary>
        /// <param name="id">The unique identifier of a goal instance.</param>
        /// <param name="name">The name of the goal.
        /// For example, Daily walk goal</param>
        /// <param name="description">The description of the goal.</param>
        /// <param name="startDate">The start date of the goal in Universal
        /// Time Zone(UTC).</param>
        /// <param name="endDate">The end date of the goal in Universal Time
        /// Zone(UTC).
        /// If the end date is in the future, this is the target date.</param>
        /// <param name="goalType">Specifies the type of data related to this
        /// goal. Possible values include: 'Unknown', 'Steps',
        /// 'CaloriesBurned', 'Weight'</param>
        /// <param name="recurrenceMetrics">The goal recurrence metrics.
        /// For example, A goal can be defined on a weekly interval, meaning
        /// the target is intended to be achieved every week. Walking 50000
        /// steps in a week.</param>
        /// <param name="range">The primary range of achievement for the goal.
        /// For example, the ideal weight or daily steps target.</param>
        /// <param name="additionalRanges">Other ranges of achievement for the
        /// goal.</param>
        public Goal(string id = default(string), string name = default(string), string description = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string goalType = default(string), GoalRecurrenceMetrics recurrenceMetrics = default(GoalRecurrenceMetrics), GoalRange range = default(GoalRange), IList<GoalRange> additionalRanges = default(IList<GoalRange>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GoalType = goalType;
            this.RecurrenceMetrics = recurrenceMetrics;
            this.Range = range;
            this.AdditionalRanges = additionalRanges;
            this.CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier of a goal instance.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the goal.
        /// For example, Daily walk goal
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the goal.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the start date of the goal in Universal Time
        /// Zone(UTC).
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the goal in Universal Time Zone(UTC).
        /// If the end date is in the future, this is the target date.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets specifies the type of data related to this goal.
        /// Possible values include: 'Unknown', 'Steps', 'CaloriesBurned',
        /// 'Weight'
        /// </summary>
        [JsonProperty(PropertyName = "goalType")]
        public string GoalType { get; set; }

        /// <summary>
        /// Gets or sets the goal recurrence metrics.
        /// For example, A goal can be defined on a weekly interval, meaning
        /// the target is intended to be achieved every week. Walking 50000
        /// steps in a week.
        /// </summary>
        [JsonProperty(PropertyName = "recurrenceMetrics")]
        public GoalRecurrenceMetrics RecurrenceMetrics { get; set; }

        /// <summary>
        /// Gets or sets the primary range of achievement for the goal.
        /// For example, the ideal weight or daily steps target.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public GoalRange Range { get; set; }

        /// <summary>
        /// Gets or sets other ranges of achievement for the goal.
        /// </summary>
        [JsonProperty(PropertyName = "additionalRanges")]
        public IList<GoalRange> AdditionalRanges { get; set; }

    }
}
