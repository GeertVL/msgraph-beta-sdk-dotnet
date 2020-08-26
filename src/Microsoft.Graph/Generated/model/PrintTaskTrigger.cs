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
    /// The type Print Task Trigger.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrintTaskTrigger : Entity
    {
    
		///<summary>
		/// The PrintTaskTrigger constructor
		///</summary>
        public PrintTaskTrigger()
        {
            this.ODataType = "microsoft.graph.printTaskTrigger";
        }
	
        /// <summary>
        /// Gets or sets event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "event", Required = Newtonsoft.Json.Required.Default)]
        public PrintEvent? Event { get; set; }
    
        /// <summary>
        /// Gets or sets definition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definition", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskDefinition Definition { get; set; }
    
    }
}
