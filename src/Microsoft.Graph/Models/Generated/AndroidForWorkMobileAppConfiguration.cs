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
    /// The type Android For Work Mobile App Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkMobileAppConfiguration : ManagedDeviceMobileAppConfiguration
    {
    
        /// <summary>
        /// Gets or sets package id.
        /// Android For Work app configuration package id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageId", Required = Newtonsoft.Json.Required.Default)]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets payload json.
        /// Android For Work app configuration JSON payload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadJson", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadJson { get; set; }
    
        /// <summary>
        /// Gets or sets permission actions.
        /// List of Android app permissions and corresponding permission actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permissionActions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AndroidPermissionAction> PermissionActions { get; set; }
    
    }
}

