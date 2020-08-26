// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidDeviceOwnerWiFiSecurityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidDeviceOwnerWiFiSecurityType
    {
    
        /// <summary>
        /// Open
        /// </summary>
        Open = 0,
	
        /// <summary>
        /// Wep
        /// </summary>
        Wep = 1,
	
        /// <summary>
        /// Wpa Personal
        /// </summary>
        WpaPersonal = 2,
	
        /// <summary>
        /// Wpa Enterprise
        /// </summary>
        WpaEnterprise = 4,
	
    }
}