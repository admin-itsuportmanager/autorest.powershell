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
    /// The sku determines the type of environment, either standard (S1 or S2)
    /// or long-term (L1). For standard environments the sku determines the
    /// capacity of the environment, the ingress rate, and the billing rate.
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
        /// <param name="name">The name of this SKU. Possible values include:
        /// 'S1', 'S2', 'P1', 'L1'</param>
        /// <param name="capacity">The capacity of the sku. For standard
        /// environments, this value can be changed to support scale out of
        /// environments after they have been created.</param>
        public Sku(SkuName name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of this SKU. Possible values include: 'S1',
        /// 'S2', 'P1', 'L1'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets or sets the capacity of the sku. For standard environments,
        /// this value can be changed to support scale out of environments
        /// after they have been created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Capacity > 10)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "Capacity", 10);
            }
            if (this.Capacity < 1)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "Capacity", 1);
            }
        }
    }
}