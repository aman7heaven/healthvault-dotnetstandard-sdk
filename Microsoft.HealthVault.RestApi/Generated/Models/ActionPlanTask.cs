// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.HealthVault.RestApi.Generated.Models
{
    /// <summary>
    /// An action a user should complete.
    /// Adherence to a plan is measured by completion statistics against tasks
    /// </summary>
    public partial class ActionPlanTask
    {
        /// <summary>
        /// Initializes a new instance of the ActionPlanTask class.
        /// </summary>
        public ActionPlanTask()
        {
          this.CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionPlanTask class.
        /// </summary>
        /// <param name="name">The friendly name of the task</param>
        /// <param name="shortDescription">The short description of the
        /// task</param>
        /// <param name="longDescription">The detailed description of the
        /// task</param>
        /// <param name="imageUrl">The image URL of the task. Suggested
        /// resolution is 200 x 200</param>
        /// <param name="thumbnailImageUrl">The thumbnail image URL of the
        /// task. Suggested resolution is 90 x 90</param>
        /// <param name="taskType">The type of the task, used to choose the UI
        /// editor for the task. Possible values include: 'Unknown',
        /// 'BloodPressure', 'Other'</param>
        /// <param name="trackingPolicy">The tracking policy</param>
        /// <param name="signupName">The text shown during task signup.</param>
        /// <param name="associatedPlanId">The ID of the associated plan. This
        /// is not needed when adding a task as part of a new plan</param>
        /// <param name="associatedObjectiveIds">The list of objective IDs the
        /// task is associated with</param>
        /// <param name="completionType">The Completion Type of the Task.
        /// Possible values include: 'Unknown', 'Frequency',
        /// 'Scheduled'</param>
        /// <param name="frequencyTaskCompletionMetrics">Completion metrics for
        /// frequency based tasks</param>
        /// <param name="scheduledTaskCompletionMetrics">Completion metrics for
        /// schedule based tasks</param>
        public ActionPlanTask(string name = default(string), string shortDescription = default(string), string longDescription = default(string), string imageUrl = default(string), string thumbnailImageUrl = default(string), string taskType = default(string), ActionPlanTrackingPolicy trackingPolicy = default(ActionPlanTrackingPolicy), string signupName = default(string), string associatedPlanId = default(string), IList<string> associatedObjectiveIds = default(IList<string>), string completionType = default(string), ActionPlanFrequencyTaskCompletionMetrics frequencyTaskCompletionMetrics = default(ActionPlanFrequencyTaskCompletionMetrics), ActionPlanScheduledTaskCompletionMetrics scheduledTaskCompletionMetrics = default(ActionPlanScheduledTaskCompletionMetrics))
        {
            this.Name = name;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
            this.ImageUrl = imageUrl;
            this.ThumbnailImageUrl = thumbnailImageUrl;
            this.TaskType = taskType;
            this.TrackingPolicy = trackingPolicy;
            this.SignupName = signupName;
            this.AssociatedPlanId = associatedPlanId;
            this.AssociatedObjectiveIds = associatedObjectiveIds;
            this.CompletionType = completionType;
            this.FrequencyTaskCompletionMetrics = frequencyTaskCompletionMetrics;
            this.ScheduledTaskCompletionMetrics = scheduledTaskCompletionMetrics;
            this.CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name of the task
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short description of the task
        /// </summary>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the detailed description of the task
        /// </summary>
        [JsonProperty(PropertyName = "longDescription")]
        public string LongDescription { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the task. Suggested resolution is 200
        /// x 200
        /// </summary>
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail image URL of the task. Suggested
        /// resolution is 90 x 90
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailImageUrl")]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the type of the task, used to choose the UI editor for
        /// the task. Possible values include: 'Unknown', 'BloodPressure',
        /// 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "taskType")]
        public string TaskType { get; set; }

        /// <summary>
        /// Gets or sets the tracking policy
        /// </summary>
        [JsonProperty(PropertyName = "trackingPolicy")]
        public ActionPlanTrackingPolicy TrackingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the text shown during task signup.
        /// </summary>
        [JsonProperty(PropertyName = "signupName")]
        public string SignupName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated plan. This is not needed when
        /// adding a task as part of a new plan
        /// </summary>
        [JsonProperty(PropertyName = "associatedPlanId")]
        public string AssociatedPlanId { get; set; }

        /// <summary>
        /// Gets or sets the list of objective IDs the task is associated with
        /// </summary>
        [JsonProperty(PropertyName = "associatedObjectiveIds")]
        public IList<string> AssociatedObjectiveIds { get; set; }

        /// <summary>
        /// Gets or sets the Completion Type of the Task. Possible values
        /// include: 'Unknown', 'Frequency', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "completionType")]
        public string CompletionType { get; set; }

        /// <summary>
        /// Gets or sets completion metrics for frequency based tasks
        /// </summary>
        [JsonProperty(PropertyName = "frequencyTaskCompletionMetrics")]
        public ActionPlanFrequencyTaskCompletionMetrics FrequencyTaskCompletionMetrics { get; set; }

        /// <summary>
        /// Gets or sets completion metrics for schedule based tasks
        /// </summary>
        [JsonProperty(PropertyName = "scheduledTaskCompletionMetrics")]
        public ActionPlanScheduledTaskCompletionMetrics ScheduledTaskCompletionMetrics { get; set; }

    }
}
