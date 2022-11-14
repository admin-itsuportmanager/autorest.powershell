// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// Information about workspace.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Workspace
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        /// <param name="managedResourceGroupId">The managed resource group
        /// Id.</param>
        public Workspace(string managedResourceGroupId = default(string))
        {
            this.ManagedResourceGroupId = managedResourceGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed resource group Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.managedResourceGroupId")]
        public string ManagedResourceGroupId { get; set; }

    }
}
