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
    /// The type Windows81Wifi Import Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows81WifiImportConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets payload file name.
        /// Payload file name (*.xml).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadFileName", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadFileName { get; set; }
    
        /// <summary>
        /// Gets or sets profile name.
        /// Profile name displayed in the UI.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileName", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets payload.
        /// Payload. (UTF8 encoded byte array). This is the XML file saved on the device you used to connect to the Wi-Fi endpoint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payload", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Payload { get; set; }
    
    }
}

