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
    /// The type Group Policy Presentation Value Multi Text.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyPresentationValueMultiText : GroupPolicyPresentationValue
    {
    
        /// <summary>
        /// Gets or sets values.
        /// A collection of non-empty strings for the associated presentation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Values { get; set; }
    
    }
}

