// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsKioskAppType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsKioskAppType
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// store
        /// </summary>
        Store = 1,
	
        /// <summary>
        /// desktop
        /// </summary>
        Desktop = 2,
	
        /// <summary>
        /// aum Id
        /// </summary>
        AumId = 3,
	
    }
}
