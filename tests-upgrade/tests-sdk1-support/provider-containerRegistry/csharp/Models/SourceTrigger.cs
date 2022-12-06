// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of a source based trigger.
    /// </summary>
    public partial class SourceTrigger
    {
        /// <summary>
        /// Initializes a new instance of the SourceTrigger class.
        /// </summary>
        public SourceTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceTrigger class.
        /// </summary>
        /// <param name="sourceRepository">The properties that describes the
        /// source(code) for the task.</param>
        /// <param name="sourceTriggerEvents">The source event corresponding to
        /// the trigger.</param>
        /// <param name="name">The name of the trigger.</param>
        /// <param name="status">The current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        public SourceTrigger(SourceProperties sourceRepository, System.Collections.Generic.IList<string> sourceTriggerEvents, string name, string status = default(string))
        {
            this.SourceRepository = sourceRepository;
            this.SourceTriggerEvents = sourceTriggerEvents;
            this.Status = status;
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties that describes the source(code) for the
        /// task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceRepository")]
        public SourceProperties SourceRepository { get; set; }

        /// <summary>
        /// Gets or sets the source event corresponding to the trigger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceTriggerEvents")]
        public System.Collections.Generic.IList<string> SourceTriggerEvents { get; set; }

        /// <summary>
        /// Gets or sets the current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SourceRepository == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceRepository");
            }
            if (this.SourceTriggerEvents == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceTriggerEvents");
            }
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.SourceRepository != null)
            {
                this.SourceRepository.Validate();
            }
        }
    }
}