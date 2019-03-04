// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AuthMethodsType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AuthMethodsType
    {
    
        /// <summary>
        /// email
        /// </summary>
        Email = 0,
	
        /// <summary>
        /// mobile SMS
        /// </summary>
        MobileSMS = 1,
	
        /// <summary>
        /// mobile Phone
        /// </summary>
        MobilePhone = 2,
	
        /// <summary>
        /// office Phone
        /// </summary>
        OfficePhone = 3,
	
        /// <summary>
        /// security Question
        /// </summary>
        SecurityQuestion = 4,
	
        /// <summary>
        /// app Notification
        /// </summary>
        AppNotification = 5,
	
        /// <summary>
        /// app Notification Code
        /// </summary>
        AppNotificationCode = 6,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}
