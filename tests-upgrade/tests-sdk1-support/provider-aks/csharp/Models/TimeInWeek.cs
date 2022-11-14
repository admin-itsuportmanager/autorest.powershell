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
    /// Time in a week.
    /// </summary>
    public partial class TimeInWeek
    {
        /// <summary>
        /// Initializes a new instance of the TimeInWeek class.
        /// </summary>
        public TimeInWeek()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeInWeek class.
        /// </summary>
        /// <param name="day">The day of the week. Possible values include:
        /// 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday'</param>
        /// <param name="hourSlots">A list of hours in the day used to identify
        /// a time range.</param>
        public TimeInWeek(string day = default(string), System.Collections.Generic.IList<int?> hourSlots = default(System.Collections.Generic.IList<int?>))
        {
            this.Day = day;
            this.HourSlots = hourSlots;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the day of the week. Possible values include:
        /// 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        /// <summary>
        /// Gets or sets a list of hours in the day used to identify a time
        /// range.
        /// </summary>
        /// <remarks>
        /// Each integer hour represents a time range beginning at 0m after the
        /// hour ending at the next hour (non-inclusive). 0 corresponds to
        /// 00:00 UTC, 23 corresponds to 23:00 UTC. Specifying [0, 1] means the
        /// 00:00 - 02:00 UTC time range.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hourSlots")]
        public System.Collections.Generic.IList<int?> HourSlots { get; set; }

    }
}
