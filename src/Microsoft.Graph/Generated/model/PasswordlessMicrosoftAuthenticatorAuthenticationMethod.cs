// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Passwordless Microsoft Authenticator Authentication Method.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PasswordlessMicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod
    {
    
		///<summary>
		/// The PasswordlessMicrosoftAuthenticatorAuthenticationMethod constructor
		///</summary>
        public PasswordlessMicrosoftAuthenticatorAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.passwordlessMicrosoftAuthenticatorAuthenticationMethod";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// The timestamp when this method was registered to the user.
        /// </summary>
        [Obsolete("The creationDateTime property is deprecated and will stop returning data on December 31, 2020. Please use the createdDateTime property.")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the mobile device as given by the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "device", Required = Newtonsoft.Json.Required.Default)]
        public Device Device { get; set; }
    
    }
}

