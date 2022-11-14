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
    /// The parameters for a docker quick build.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DockerBuildRequest")]
    public partial class DockerBuildRequest : RunRequest
    {
        /// <summary>
        /// Initializes a new instance of the DockerBuildRequest class.
        /// </summary>
        public DockerBuildRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DockerBuildRequest class.
        /// </summary>
        /// <param name="dockerFilePath">The Docker file path relative to the
        /// source location.</param>
        /// <param name="platform">The platform properties against which the
        /// run has to happen.</param>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled for the run or not.</param>
        /// <param name="imageNames">The fully qualified image names including
        /// the repository and tag.</param>
        /// <param name="isPushEnabled">The value of this property indicates
        /// whether the image built should be pushed to the registry or
        /// not.</param>
        /// <param name="noCache">The value of this property indicates whether
        /// the image cache is enabled or not.</param>
        /// <param name="target">The name of the target build stage for the
        /// docker build.</param>
        /// <param name="arguments">The collection of override arguments to be
        /// used when executing the run.</param>
        /// <param name="timeout">Run timeout in seconds.</param>
        /// <param name="agentConfiguration">The machine configuration of the
        /// run agent.</param>
        /// <param name="sourceLocation">The URL(absolute or relative) of the
        /// source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.</param>
        /// <param name="credentials">The properties that describes a set of
        /// credentials that will be used when this run is invoked.</param>
        public DockerBuildRequest(string dockerFilePath, PlatformProperties platform, bool? isArchiveEnabled = default(bool?), System.Collections.Generic.IList<string> imageNames = default(System.Collections.Generic.IList<string>), bool? isPushEnabled = default(bool?), bool? noCache = default(bool?), string target = default(string), System.Collections.Generic.IList<Argument> arguments = default(System.Collections.Generic.IList<Argument>), int? timeout = default(int?), AgentProperties agentConfiguration = default(AgentProperties), string sourceLocation = default(string), Credentials credentials = default(Credentials))
            : base(isArchiveEnabled)
        {
            this.ImageNames = imageNames;
            this.IsPushEnabled = isPushEnabled;
            this.NoCache = noCache;
            this.DockerFilePath = dockerFilePath;
            this.Target = target;
            this.Arguments = arguments;
            this.Timeout = timeout;
            this.Platform = platform;
            this.AgentConfiguration = agentConfiguration;
            this.SourceLocation = sourceLocation;
            this.Credentials = credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified image names including the
        /// repository and tag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageNames")]
        public System.Collections.Generic.IList<string> ImageNames { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// built should be pushed to the registry or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isPushEnabled")]
        public bool? IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// cache is enabled or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "noCache")]
        public bool? NoCache { get; set; }

        /// <summary>
        /// Gets or sets the Docker file path relative to the source location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dockerFilePath")]
        public string DockerFilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the target build stage for the docker
        /// build.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the collection of override arguments to be used when
        /// executing the run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.IList<Argument> Arguments { get; set; }

        /// <summary>
        /// Gets or sets run timeout in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the platform properties against which the run has to
        /// happen.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "platform")]
        public PlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or sets the machine configuration of the run agent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "agentConfiguration")]
        public AgentProperties AgentConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the URL(absolute or relative) of the source context.
        /// It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceLocation")]
        public string SourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the properties that describes a set of credentials
        /// that will be used when this run is invoked.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DockerFilePath == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DockerFilePath");
            }
            if (this.Platform == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Platform");
            }
            if (this.Arguments != null)
            {
                foreach (var element in this.Arguments)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Timeout != null)
            {
                if (this.Timeout > 28800)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "Timeout", 28800);
                }
                if (this.Timeout < 300)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "Timeout", 300);
                }
            }
            if (this.Platform != null)
            {
                this.Platform.Validate();
            }
        }
    }
}
