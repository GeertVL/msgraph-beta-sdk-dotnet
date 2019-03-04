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
    /// The type TextPrompt.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TextPrompt : Prompt
    {
        public TextPrompt()
        {
            this.ODataType = "microsoft.graph.TextPrompt";
        }
        /// <summary>
        /// Gets or sets text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets voiceGender.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "voiceGender", Required = Newtonsoft.Json.Required.Default)]
        public VoiceGender? VoiceGender { get; set; }
    
        /// <summary>
        /// Gets or sets culture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "culture", Required = Newtonsoft.Json.Required.Default)]
        public Culture? Culture { get; set; }
    
        /// <summary>
        /// Gets or sets emphasize.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emphasize", Required = Newtonsoft.Json.Required.Default)]
        public bool? Emphasize { get; set; }
    
        /// <summary>
        /// Gets or sets sayAs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sayAs", Required = Newtonsoft.Json.Required.Default)]
        public SayAs? SayAs { get; set; }
    
        /// <summary>
        /// Gets or sets loop.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "loop", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Loop { get; set; }
    
    }
}
