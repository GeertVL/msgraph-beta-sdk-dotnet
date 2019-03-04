// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidUsernameSource.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidUsernameSource
    {
    
        /// <summary>
        /// username
        /// </summary>
        Username = 0,
	
        /// <summary>
        /// user Principal Name
        /// </summary>
        UserPrincipalName = 1,
	
        /// <summary>
        /// sam Account Name
        /// </summary>
        SamAccountName = 2,
	
        /// <summary>
        /// primary Smtp Address
        /// </summary>
        PrimarySmtpAddress = 3,
	
    }
}
