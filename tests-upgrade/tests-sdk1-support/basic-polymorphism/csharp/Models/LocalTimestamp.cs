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
    /// An object that represents the local timestamp property. It contains the
    /// format of local timestamp that needs to be used and the corresponding
    /// timezone offset information. If a value isn't specified for
    /// localTimestamp, or if null, then the local timestamp will not be
    /// ingressed with the events.
    /// </summary>
    public partial class LocalTimestamp
    {
        /// <summary>
        /// Initializes a new instance of the LocalTimestamp class.
        /// </summary>
        public LocalTimestamp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalTimestamp class.
        /// </summary>
        /// <param name="format">An enum that represents the format of the
        /// local timestamp property that needs to be set. Possible values
        /// include: 'Embedded', 'Iana', 'TimeSpan'</param>
        /// <param name="timeZoneOffset">An object that represents the offset
        /// information for the local timestamp format specified. Should not be
        /// specified for LocalTimestampFormat - Embedded.</param>
        public LocalTimestamp(LocalTimestampFormat? format = default(LocalTimestampFormat?), LocalTimestampTimeZoneOffset timeZoneOffset = default(LocalTimestampTimeZoneOffset))
        {
            this.Format = format;
            this.TimeZoneOffset = timeZoneOffset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an enum that represents the format of the local
        /// timestamp property that needs to be set. Possible values include:
        /// 'Embedded', 'Iana', 'TimeSpan'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "format")]
        public LocalTimestampFormat? Format { get; set; }

        /// <summary>
        /// Gets or sets an object that represents the offset information for
        /// the local timestamp format specified. Should not be specified for
        /// LocalTimestampFormat - Embedded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeZoneOffset")]
        public LocalTimestampTimeZoneOffset TimeZoneOffset { get; set; }

    }
}
