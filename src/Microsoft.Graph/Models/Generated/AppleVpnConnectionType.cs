// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AppleVpnConnectionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AppleVpnConnectionType
    {
    
        /// <summary>
        /// cisco Any Connect
        /// </summary>
        CiscoAnyConnect = 0,
	
        /// <summary>
        /// pulse Secure
        /// </summary>
        PulseSecure = 1,
	
        /// <summary>
        /// f5Edge Client
        /// </summary>
        F5EdgeClient = 2,
	
        /// <summary>
        /// dell Sonic Wall Mobile Connect
        /// </summary>
        DellSonicWallMobileConnect = 3,
	
        /// <summary>
        /// check Point Capsule Vpn
        /// </summary>
        CheckPointCapsuleVpn = 4,
	
        /// <summary>
        /// custom Vpn
        /// </summary>
        CustomVpn = 5,
	
        /// <summary>
        /// cisco IPSec
        /// </summary>
        CiscoIPSec = 6,
	
        /// <summary>
        /// citrix
        /// </summary>
        Citrix = 7,
	
        /// <summary>
        /// cisco Any Connect V2
        /// </summary>
        CiscoAnyConnectV2 = 8,
	
        /// <summary>
        /// palo Alto Global Protect
        /// </summary>
        PaloAltoGlobalProtect = 9,
	
        /// <summary>
        /// zscaler Private Access
        /// </summary>
        ZscalerPrivateAccess = 10,
	
        /// <summary>
        /// f5Access2018
        /// </summary>
        F5Access2018 = 11,
	
        /// <summary>
        /// citrix Sso
        /// </summary>
        CitrixSso = 12,
	
        /// <summary>
        /// palo Alto Global Protect V2
        /// </summary>
        PaloAltoGlobalProtectV2 = 13,
	
    }
}
