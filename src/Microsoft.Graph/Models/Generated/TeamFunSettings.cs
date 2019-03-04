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
    /// The type TeamFunSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TeamFunSettings
    {

        /// <summary>
        /// Gets or sets allowGiphy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowGiphy", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowGiphy { get; set; }
    
        /// <summary>
        /// Gets or sets giphyContentRating.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "giphyContentRating", Required = Newtonsoft.Json.Required.Default)]
        public GiphyRatingType? GiphyContentRating { get; set; }
    
        /// <summary>
        /// Gets or sets allowStickersAndMemes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowStickersAndMemes", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowStickersAndMemes { get; set; }
    
        /// <summary>
        /// Gets or sets allowCustomMemes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowCustomMemes", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowCustomMemes { get; set; }
    
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
