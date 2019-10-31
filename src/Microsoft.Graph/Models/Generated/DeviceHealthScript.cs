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
    /// The type Device Health Script.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceHealthScript : DeviceManagementScript
    {
    
        /// <summary>
        /// Gets or sets compliance rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceRule", Required = Newtonsoft.Json.Required.Default)]
        public DeviceHealthScriptComplianceRule ComplianceRule { get; set; }
    
        /// <summary>
        /// Gets or sets remediation script content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediationScriptContent", Required = Newtonsoft.Json.Required.Default)]
        public byte[] RemediationScriptContent { get; set; }
    
        /// <summary>
        /// Gets or sets run remediation script.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runRemediationScript", Required = Newtonsoft.Json.Required.Default)]
        public bool? RunRemediationScript { get; set; }
    
    }
}
