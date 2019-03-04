// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management Script Run Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementScriptRunSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets success device count.
        /// Success device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SuccessDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Error device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets success user count.
        /// Success user count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SuccessUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets error user count.
        /// Error user count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorUserCount { get; set; }
    
    }
}

