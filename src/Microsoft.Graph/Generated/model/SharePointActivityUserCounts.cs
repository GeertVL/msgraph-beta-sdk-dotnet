// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Share Point Activity User Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SharePointActivityUserCounts : Entity
    {
    
		///<summary>
		/// The SharePointActivityUserCounts constructor
		///</summary>
        public SharePointActivityUserCounts()
        {
            this.ODataType = "microsoft.graph.sharePointActivityUserCounts";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets visited page.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visitedPage", Required = Newtonsoft.Json.Required.Default)]
        public Int64? VisitedPage { get; set; }
    
        /// <summary>
        /// Gets or sets viewed or edited.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "viewedOrEdited", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ViewedOrEdited { get; set; }
    
        /// <summary>
        /// Gets or sets synced.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "synced", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Synced { get; set; }
    
        /// <summary>
        /// Gets or sets shared internally.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedInternally", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharedInternally { get; set; }
    
        /// <summary>
        /// Gets or sets shared externally.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedExternally", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharedExternally { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}
