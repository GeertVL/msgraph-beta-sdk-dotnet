// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum TlpLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TlpLevel
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// white
        /// </summary>
        White = 1,
	
        /// <summary>
        /// green
        /// </summary>
        Green = 2,
	
        /// <summary>
        /// amber
        /// </summary>
        Amber = 3,
	
        /// <summary>
        /// red
        /// </summary>
        Red = 4,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
