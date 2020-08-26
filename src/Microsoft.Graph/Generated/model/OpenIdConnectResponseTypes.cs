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
    /// The enum OpenIdConnectResponseTypes.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum OpenIdConnectResponseTypes
    {
    
        /// <summary>
        /// Code
        /// </summary>
        Code = 1,
	
        /// <summary>
        /// Id_token
        /// </summary>
        Id_token = 2,
	
        /// <summary>
        /// Token
        /// </summary>
        Token = 4,
	
    }
}