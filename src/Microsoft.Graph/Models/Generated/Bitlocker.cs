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
    /// The type Bitlocker.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Bitlocker : Entity
    {
    
		///<summary>
		/// The Bitlocker constructor
		///</summary>
        public Bitlocker()
        {
            this.ODataType = "microsoft.graph.bitlocker";
        }
	
        /// <summary>
        /// Gets or sets recovery keys.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recoveryKeys", Required = Newtonsoft.Json.Required.Default)]
        public IBitlockerRecoveryKeysCollectionPage RecoveryKeys { get; set; }
    
    }
}
