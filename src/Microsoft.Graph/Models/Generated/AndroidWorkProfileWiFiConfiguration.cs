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
    /// The type Android Work Profile Wi Fi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileWiFiConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets network name.
        /// Network Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkName", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// This is the name of the Wi-Fi network that is broadcast to all devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ssid", Required = Newtonsoft.Json.Required.Default)]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets connect automatically.
        /// Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectAutomatically", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// When set to true, this profile forces the device to connect to a network that doesn't broadcast its SSID to all devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectWhenNetworkNameIsHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi security type.
        /// Indicates whether Wi-Fi endpoint uses an EAP based security type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wiFiSecurityType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWiFiSecurityType? WiFiSecurityType { get; set; }
    
    }
}

