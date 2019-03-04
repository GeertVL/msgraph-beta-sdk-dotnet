// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Win32LobAppPowerShellScriptDetection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppPowerShellScriptDetection : Win32LobAppDetection
    {
        public Win32LobAppPowerShellScriptDetection()
        {
            this.ODataType = "microsoft.graph.win32LobAppPowerShellScriptDetection";
        }
        /// <summary>
        /// Gets or sets enforceSignatureCheck.
        /// A value indicating whether signature check is enforced
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforceSignatureCheck", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnforceSignatureCheck { get; set; }
    
        /// <summary>
        /// Gets or sets runAs32Bit.
        /// A value indicating whether this script should run as 32-bit
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runAs32Bit", Required = Newtonsoft.Json.Required.Default)]
        public bool? RunAs32Bit { get; set; }
    
        /// <summary>
        /// Gets or sets scriptContent.
        /// The base64 encoded script content to detect Win32 Line of Business (LoB) app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scriptContent", Required = Newtonsoft.Json.Required.Default)]
        public string ScriptContent { get; set; }
    
    }
}
