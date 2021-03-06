// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type UserSendMailRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserSendMailRequestBody
    {
    
        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Message", Required = Newtonsoft.Json.Required.Default)]
        public Message Message { get; set; }
    
        /// <summary>
        /// Gets or sets SaveToSentItems.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "SaveToSentItems", Required = Newtonsoft.Json.Required.Default)]
        public bool? SaveToSentItems { get; set; }
    
    }
}
