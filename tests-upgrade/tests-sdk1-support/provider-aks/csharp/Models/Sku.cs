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
    /// The resource model definition representing SKU
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The name of the SKU. Ex - P3. It is typically a
        /// letter+number code</param>
        /// <param name="tier">Possible values include: 'Free', 'Basic',
        /// 'Standard', 'Premium'</param>
        /// <param name="size">The SKU size. When the name field is the
        /// combination of tier and some other value, this would be the
        /// standalone code. </param>
        /// <param name="family">If the service has different generations of
        /// hardware, for the same SKU, then that can be captured here.</param>
        /// <param name="capacity">If the SKU supports scale out/in then the
        /// capacity integer should be included. If scale out/in is not
        /// possible for the resource this may be omitted.</param>
        public Sku(string name, SkuTier? tier = default(SkuTier?), string size = default(string), string family = default(string), int? capacity = default(int?))
        {
            this.Name = name;
            this.Tier = tier;
            this.Size = size;
            this.Family = family;
            this.Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SKU. Ex - P3. It is typically a
        /// letter+number code
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Free', 'Basic', 'Standard',
        /// 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; set; }

        /// <summary>
        /// Gets or sets the SKU size. When the name field is the combination
        /// of tier and some other value, this would be the standalone code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets if the service has different generations of hardware,
        /// for the same SKU, then that can be captured here.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets if the SKU supports scale out/in then the capacity
        /// integer should be included. If scale out/in is not possible for the
        /// resource this may be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
