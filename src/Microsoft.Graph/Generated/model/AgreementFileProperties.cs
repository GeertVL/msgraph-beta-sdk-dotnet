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
    /// The type Agreement File Properties.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AgreementFileProperties : Entity
    {
    
		///<summary>
		/// The AgreementFileProperties constructor
		///</summary>
        public AgreementFileProperties()
        {
            this.ODataType = "microsoft.graph.agreementFileProperties";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets file data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileData", Required = Newtonsoft.Json.Required.Default)]
        public AgreementFileData FileData { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets is major version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMajorVersion", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMajorVersion { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "language", Required = Newtonsoft.Json.Required.Default)]
        public string Language { get; set; }
    
    }
}

