// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PlannerRecentPlanReference.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PlannerRecentPlanReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerRecentPlanReference"/> class.
        /// </summary>
        public PlannerRecentPlanReference()
        {
            this.ODataType = "microsoft.graph.plannerRecentPlanReference";
        }

        /// <summary>
        /// Gets or sets lastAccessedDateTime.
        /// The date and time the plan was last viewed by the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastAccessedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastAccessedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets planTitle.
        /// The title of the plan at the time the user viewed it.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planTitle", Required = Newtonsoft.Json.Required.Default)]
        public string PlanTitle { get; set; }
    
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
