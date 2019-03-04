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
    /// The type AudioConferencing.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AudioConferencing
    {

        /// <summary>
        /// Gets or sets tollNumber.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tollNumber", Required = Newtonsoft.Json.Required.Default)]
        public string TollNumber { get; set; }
    
        /// <summary>
        /// Gets or sets tollFreeNumber.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tollFreeNumber", Required = Newtonsoft.Json.Required.Default)]
        public string TollFreeNumber { get; set; }
    
        /// <summary>
        /// Gets or sets participantPasscode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participantPasscode", Required = Newtonsoft.Json.Required.Default)]
        public string ParticipantPasscode { get; set; }
    
        /// <summary>
        /// Gets or sets leaderPasscode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "leaderPasscode", Required = Newtonsoft.Json.Required.Default)]
        public string LeaderPasscode { get; set; }
    
        /// <summary>
        /// Gets or sets dialinUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dialinUrl", Required = Newtonsoft.Json.Required.Default)]
        public string DialinUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
