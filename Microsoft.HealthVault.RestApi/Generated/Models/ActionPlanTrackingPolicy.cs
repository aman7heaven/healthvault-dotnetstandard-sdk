// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.HealthVault.RestApi.Generated.Models
{
    /// <summary>
    /// The tracking policy to apply to the Action Plan Task
    /// </summary>
    public partial class ActionPlanTrackingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ActionPlanTrackingPolicy class.
        /// </summary>
        public ActionPlanTrackingPolicy()
        {
          this.CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionPlanTrackingPolicy class.
        /// </summary>
        /// <param name="isAutoTrackable">Gets or sets an indicator as to
        /// whether or not the Tracking Policy is AutoTrackable</param>
        /// <param name="occurrenceMetrics">Gets or sets the Occurrence Metrics
        /// for the tracking policy</param>
        /// <param name="targetEvents">The target events to track
        /// against</param>
        public ActionPlanTrackingPolicy(bool? isAutoTrackable = default(bool?), ActionPlanTaskOccurrenceMetrics occurrenceMetrics = default(ActionPlanTaskOccurrenceMetrics), IList<ActionPlanTaskTargetEvent> targetEvents = default(IList<ActionPlanTaskTargetEvent>))
        {
            this.IsAutoTrackable = isAutoTrackable;
            this.OccurrenceMetrics = occurrenceMetrics;
            this.TargetEvents = targetEvents;
            this.CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an indicator as to whether or not the Tracking Policy
        /// is AutoTrackable
        /// </summary>
        [JsonProperty(PropertyName = "isAutoTrackable")]
        public bool? IsAutoTrackable { get; set; }

        /// <summary>
        /// Gets or sets the Occurrence Metrics for the tracking policy
        /// </summary>
        [JsonProperty(PropertyName = "occurrenceMetrics")]
        public ActionPlanTaskOccurrenceMetrics OccurrenceMetrics { get; set; }

        /// <summary>
        /// Gets or sets the target events to track against
        /// </summary>
        [JsonProperty(PropertyName = "targetEvents")]
        public IList<ActionPlanTaskTargetEvent> TargetEvents { get; set; }

    }
}
