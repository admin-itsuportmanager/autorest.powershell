// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// AzureDisk CSI Driver settings for the storage profile.
    /// </summary>
    public partial class ManagedClusterStorageProfileDiskCSIDriver
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterStorageProfileDiskCSIDriver class.
        /// </summary>
        public ManagedClusterStorageProfileDiskCSIDriver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterStorageProfileDiskCSIDriver class.
        /// </summary>
        /// <param name="enabled">Whether to enable AzureDisk CSI Driver. The
        /// default value is true.</param>
        public ManagedClusterStorageProfileDiskCSIDriver(bool? enabled = default(bool?))
        {
            this.Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to enable AzureDisk CSI Driver. The default
        /// value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
