// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Audio Routing Group.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AudioRoutingGroup : Entity
    {
    
		///<summary>
		/// The AudioRoutingGroup constructor
		///</summary>
        public AudioRoutingGroup()
        {
            this.ODataType = "microsoft.graph.audioRoutingGroup";
        }
	
        /// <summary>
        /// Gets or sets receivers.
        /// List of receiving participant ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Receivers { get; set; }
    
        /// <summary>
        /// Gets or sets routing mode.
        /// Routing group mode.  Possible values are: oneToOne, multicast.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routingMode", Required = Newtonsoft.Json.Required.Default)]
        public RoutingMode? RoutingMode { get; set; }
    
        /// <summary>
        /// Gets or sets sources.
        /// List of source participant ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sources", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Sources { get; set; }
    
    }
}

