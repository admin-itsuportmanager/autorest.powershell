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

    public partial class ImportImageParameters
    {
        /// <summary>
        /// Initializes a new instance of the ImportImageParameters class.
        /// </summary>
        public ImportImageParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportImageParameters class.
        /// </summary>
        /// <param name="source">The source of the image.</param>
        /// <param name="targetTags">List of strings of the form repo[:tag].
        /// When tag is omitted the source will be used (or 'latest' if source
        /// tag is also omitted).</param>
        /// <param name="untaggedTargetRepositories">List of strings of
        /// repository names to do a manifest only copy. No tag will be
        /// created.</param>
        /// <param name="mode">When Force, any existing target tags will be
        /// overwritten. When NoForce, any existing target tags will fail the
        /// operation before any copying begins. Possible values include:
        /// 'NoForce', 'Force'</param>
        public ImportImageParameters(ImportSource source, System.Collections.Generic.IList<string> targetTags = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> untaggedTargetRepositories = default(System.Collections.Generic.IList<string>), string mode = default(string))
        {
            this.Source = source;
            this.TargetTags = targetTags;
            this.UntaggedTargetRepositories = untaggedTargetRepositories;
            this.Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source of the image.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "source")]
        public ImportSource Source { get; set; }

        /// <summary>
        /// Gets or sets list of strings of the form repo[:tag]. When tag is
        /// omitted the source will be used (or 'latest' if source tag is also
        /// omitted).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetTags")]
        public System.Collections.Generic.IList<string> TargetTags { get; set; }

        /// <summary>
        /// Gets or sets list of strings of repository names to do a manifest
        /// only copy. No tag will be created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "untaggedTargetRepositories")]
        public System.Collections.Generic.IList<string> UntaggedTargetRepositories { get; set; }

        /// <summary>
        /// Gets or sets when Force, any existing target tags will be
        /// overwritten. When NoForce, any existing target tags will fail the
        /// operation before any copying begins. Possible values include:
        /// 'NoForce', 'Force'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Source == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Source");
            }
            if (this.Source != null)
            {
                this.Source.Validate();
            }
        }
    }
}