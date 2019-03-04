// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeliveryOptimizationGroupIdOptionsType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeliveryOptimizationGroupIdOptionsType
    {
    
        /// <summary>
        /// not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// ad Site
        /// </summary>
        AdSite = 1,
	
        /// <summary>
        /// authenticated Domain Sid
        /// </summary>
        AuthenticatedDomainSid = 2,
	
        /// <summary>
        /// dhcp User Option
        /// </summary>
        DhcpUserOption = 3,
	
        /// <summary>
        /// dns Suffix
        /// </summary>
        DnsSuffix = 4,
	
    }
}
