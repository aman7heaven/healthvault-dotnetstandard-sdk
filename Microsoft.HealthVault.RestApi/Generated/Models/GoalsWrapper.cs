// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.HealthVault.RestApi.Generated.Models
{
    /// <summary>
    /// The goals wrapper.
    /// </summary>
    public partial class GoalsWrapper
    {
        /// <summary>
        /// Initializes a new instance of the GoalsWrapper class.
        /// </summary>
        public GoalsWrapper()
        {
          this.CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalsWrapper class.
        /// </summary>
        /// <param name="goals">The collection of goals</param>
        public GoalsWrapper(IList<Goal> goals = default(IList<Goal>))
        {
            this.Goals = goals;
            this.CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of goals
        /// </summary>
        [JsonProperty(PropertyName = "goals")]
        public IList<Goal> Goals { get; set; }

    }
}
