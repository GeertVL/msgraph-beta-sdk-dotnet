// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum VppTokenActionFailureReason.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VppTokenActionFailureReason
    {
    
        /// <summary>
        /// none
        /// </summary>
        None = 0,
	
        /// <summary>
        /// apple Failure
        /// </summary>
        AppleFailure = 1,
	
        /// <summary>
        /// internal Error
        /// </summary>
        InternalError = 2,
	
        /// <summary>
        /// expired Vpp Token
        /// </summary>
        ExpiredVppToken = 3,
	
        /// <summary>
        /// expired Apple Push Notification Certificate
        /// </summary>
        ExpiredApplePushNotificationCertificate = 4,
	
    }
}
