// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type GroupPolicyUploadedLanguageFile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class GroupPolicyUploadedLanguageFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPolicyUploadedLanguageFile"/> class.
        /// </summary>
        public GroupPolicyUploadedLanguageFile()
        {
            this.ODataType = "microsoft.graph.groupPolicyUploadedLanguageFile";
        }

        /// <summary>
        /// Gets or sets content.
        /// The contents of the uploaded ADML file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Content { get; set; }
    
        /// <summary>
        /// Gets or sets fileName.
        /// The file name of the uploaded ADML file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Key of the entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets languageCode.
        /// The language code of the uploaded ADML file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "languageCode", Required = Newtonsoft.Json.Required.Default)]
        public string LanguageCode { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
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
