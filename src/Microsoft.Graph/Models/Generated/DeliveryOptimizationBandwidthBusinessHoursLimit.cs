// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeliveryOptimizationBandwidthBusinessHoursLimit.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeliveryOptimizationBandwidthBusinessHoursLimit
    {

        /// <summary>
        /// Gets or sets bandwidthBeginBusinessHours.
        /// Specifies the beginning of business hours using a 24-hour clock (0-23). Valid values 0 to 23
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bandwidthBeginBusinessHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BandwidthBeginBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets bandwidthEndBusinessHours.
        /// Specifies the end of business hours using a 24-hour clock (0-23). Valid values 0 to 23
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bandwidthEndBusinessHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BandwidthEndBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets bandwidthPercentageDuringBusinessHours.
        /// Specifies the percentage of bandwidth to limit during business hours (0-100). Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bandwidthPercentageDuringBusinessHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BandwidthPercentageDuringBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets bandwidthPercentageOutsideBusinessHours.
        /// Specifies the percentage of bandwidth to limit outsidse business hours (0-100). Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bandwidthPercentageOutsideBusinessHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BandwidthPercentageOutsideBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
