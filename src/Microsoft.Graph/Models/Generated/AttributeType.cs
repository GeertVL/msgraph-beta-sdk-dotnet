// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AttributeType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AttributeType
    {
    
        /// <summary>
        /// Date Time
        /// </summary>
        DateTime = 5,
	
        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 4,
	
        /// <summary>
        /// Binary
        /// </summary>
        Binary = 3,
	
        /// <summary>
        /// Reference
        /// </summary>
        Reference = 2,
	
        /// <summary>
        /// Integer
        /// </summary>
        Integer = 1,
	
        /// <summary>
        /// String
        /// </summary>
        @String = 0,
	
    }
}
