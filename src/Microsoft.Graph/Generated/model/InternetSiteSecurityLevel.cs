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
    /// The enum InternetSiteSecurityLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum InternetSiteSecurityLevel
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 1,
	
        /// <summary>
        /// Medium High
        /// </summary>
        MediumHigh = 2,
	
        /// <summary>
        /// High
        /// </summary>
        High = 3,
	
    }
}