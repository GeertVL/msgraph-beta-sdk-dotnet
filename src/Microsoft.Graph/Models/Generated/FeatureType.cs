// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum FeatureType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FeatureType
    {
    
        /// <summary>
        /// registration
        /// </summary>
        Registration = 0,
	
        /// <summary>
        /// reset
        /// </summary>
        Reset = 1,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
