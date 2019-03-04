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
    /// The type ExcludedApps.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ExcludedApps
    {

        /// <summary>
        /// Gets or sets access.
        /// The value for if MS Office Access should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "access", Required = Newtonsoft.Json.Required.Default)]
        public bool? Access { get; set; }
    
        /// <summary>
        /// Gets or sets excel.
        /// The value for if MS Office Excel should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "excel", Required = Newtonsoft.Json.Required.Default)]
        public bool? Excel { get; set; }
    
        /// <summary>
        /// Gets or sets groove.
        /// The value for if MS Office OneDrive for Business - Groove should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groove", Required = Newtonsoft.Json.Required.Default)]
        public bool? Groove { get; set; }
    
        /// <summary>
        /// Gets or sets infoPath.
        /// The value for if MS Office InfoPath should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "infoPath", Required = Newtonsoft.Json.Required.Default)]
        public bool? InfoPath { get; set; }
    
        /// <summary>
        /// Gets or sets lync.
        /// The value for if MS Office Skype for Business - Lync should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lync", Required = Newtonsoft.Json.Required.Default)]
        public bool? Lync { get; set; }
    
        /// <summary>
        /// Gets or sets oneDrive.
        /// The value for if MS Office OneDrive should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneDrive", Required = Newtonsoft.Json.Required.Default)]
        public bool? OneDrive { get; set; }
    
        /// <summary>
        /// Gets or sets oneNote.
        /// The value for if MS Office OneNote should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneNote", Required = Newtonsoft.Json.Required.Default)]
        public bool? OneNote { get; set; }
    
        /// <summary>
        /// Gets or sets outlook.
        /// The value for if MS Office Outlook should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook", Required = Newtonsoft.Json.Required.Default)]
        public bool? Outlook { get; set; }
    
        /// <summary>
        /// Gets or sets powerPoint.
        /// The value for if MS Office PowerPoint should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "powerPoint", Required = Newtonsoft.Json.Required.Default)]
        public bool? PowerPoint { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// The value for if MS Office Publisher should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public bool? Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets sharePointDesigner.
        /// The value for if MS Office SharePointDesigner should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointDesigner", Required = Newtonsoft.Json.Required.Default)]
        public bool? SharePointDesigner { get; set; }
    
        /// <summary>
        /// Gets or sets visio.
        /// The value for if MS Office Visio should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visio", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visio { get; set; }
    
        /// <summary>
        /// Gets or sets word.
        /// The value for if MS Office Word should be excluded or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "word", Required = Newtonsoft.Json.Required.Default)]
        public bool? Word { get; set; }
    
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
