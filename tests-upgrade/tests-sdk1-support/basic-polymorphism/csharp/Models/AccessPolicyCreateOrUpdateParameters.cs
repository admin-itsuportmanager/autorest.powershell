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

    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AccessPolicyCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AccessPolicyCreateOrUpdateParameters class.
        /// </summary>
        public AccessPolicyCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AccessPolicyCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="principalObjectId">The objectId of the principal in
        /// Azure Active Directory.</param>
        /// <param name="description">An description of the access
        /// policy.</param>
        /// <param name="roles">The list of roles the principal is assigned on
        /// the environment.</param>
        public AccessPolicyCreateOrUpdateParameters(string principalObjectId = default(string), string description = default(string), System.Collections.Generic.IList<AccessPolicyRole?> roles = default(System.Collections.Generic.IList<AccessPolicyRole?>))
        {
            this.PrincipalObjectId = principalObjectId;
            this.Description = description;
            this.Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the objectId of the principal in Azure Active
        /// Directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.principalObjectId")]
        public string PrincipalObjectId { get; set; }

        /// <summary>
        /// Gets or sets an description of the access policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of roles the principal is assigned on the
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.roles")]
        public System.Collections.Generic.IList<AccessPolicyRole?> Roles { get; set; }

    }
}
