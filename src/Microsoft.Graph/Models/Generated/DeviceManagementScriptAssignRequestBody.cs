// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DeviceManagementScriptAssignRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementScriptAssignRequestBody
    {
    
        /// <summary>
        /// Gets or sets DeviceManagementScriptGroupAssignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementScriptGroupAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementScriptGroupAssignment> DeviceManagementScriptGroupAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets DeviceManagementScriptAssignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementScriptAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementScriptAssignment> DeviceManagementScriptAssignments { get; set; }
    
    }
}
