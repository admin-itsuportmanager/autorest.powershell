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
    /// The list of available upgrades for compute pools.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ManagedClusterUpgradeProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterUpgradeProfile
        /// class.
        /// </summary>
        public ManagedClusterUpgradeProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterUpgradeProfile
        /// class.
        /// </summary>
        /// <param name="controlPlaneProfile">The list of available upgrade
        /// versions for the control plane.</param>
        /// <param name="agentPoolProfiles">The list of available upgrade
        /// versions for agent pools.</param>
        /// <param name="id">The ID of the upgrade profile.</param>
        /// <param name="name">The name of the upgrade profile.</param>
        /// <param name="type">The type of the upgrade profile.</param>
        public ManagedClusterUpgradeProfile(ManagedClusterPoolUpgradeProfile controlPlaneProfile, System.Collections.Generic.IList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles, string id = default(string), string name = default(string), string type = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.ControlPlaneProfile = controlPlaneProfile;
            this.AgentPoolProfiles = agentPoolProfiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the upgrade profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the upgrade profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the upgrade profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the list of available upgrade versions for the control
        /// plane.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.controlPlaneProfile")]
        public ManagedClusterPoolUpgradeProfile ControlPlaneProfile { get; set; }

        /// <summary>
        /// Gets or sets the list of available upgrade versions for agent
        /// pools.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public System.Collections.Generic.IList<ManagedClusterPoolUpgradeProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ControlPlaneProfile == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ControlPlaneProfile");
            }
            if (this.AgentPoolProfiles == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AgentPoolProfiles");
            }
            if (this.ControlPlaneProfile != null)
            {
                this.ControlPlaneProfile.Validate();
            }
            if (this.AgentPoolProfiles != null)
            {
                foreach (var element in this.AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
