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
    /// The trigger based on base image dependency.
    /// </summary>
    public partial class BaseImageTrigger
    {
        /// <summary>
        /// Initializes a new instance of the BaseImageTrigger class.
        /// </summary>
        public BaseImageTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseImageTrigger class.
        /// </summary>
        /// <param name="baseImageTriggerType">The type of the auto trigger for
        /// base image dependency updates. Possible values include: 'All',
        /// 'Runtime'</param>
        /// <param name="name">The name of the trigger.</param>
        /// <param name="status">The current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        public BaseImageTrigger(string baseImageTriggerType, string name, string status = default(string))
        {
            this.BaseImageTriggerType = baseImageTriggerType;
            this.Status = status;
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the auto trigger for base image dependency
        /// updates. Possible values include: 'All', 'Runtime'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "baseImageTriggerType")]
        public string BaseImageTriggerType { get; set; }

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
            if (this.BaseImageTriggerType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "BaseImageTriggerType");
            }
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
