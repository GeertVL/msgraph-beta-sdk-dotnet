// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type SynchronizationJobValidateCredentialsRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SynchronizationJobValidateCredentialsRequestBody
    {
    
        /// <summary>
        /// Gets or sets ApplicationIdentifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets TemplateId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateId", Required = Newtonsoft.Json.Required.Default)]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets UseSavedCredentials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useSavedCredentials", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseSavedCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credentials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
    
    }
}
