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
    /// The type MobileAppTroubleshootingAppStateHistory.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppTroubleshootingAppStateHistory : MobileAppTroubleshootingHistoryItem
    {

        /// <summary>
        /// Gets or sets actionType.
        /// AAD security group id to which it was targeted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionType", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppActionType? ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets runState.
        /// Status of the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runState", Required = Newtonsoft.Json.Required.Default)]
        public RunState? RunState { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Error code for the failure, empty if no failure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorCode { get; set; }
    
    }
}
