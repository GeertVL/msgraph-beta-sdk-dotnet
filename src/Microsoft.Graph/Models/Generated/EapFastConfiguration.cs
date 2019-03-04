// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EapFastConfiguration.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EapFastConfiguration
    {
    
        /// <summary>
        /// no Protected Access Credential
        /// </summary>
        NoProtectedAccessCredential = 0,
	
        /// <summary>
        /// use Protected Access Credential
        /// </summary>
        UseProtectedAccessCredential = 1,
	
        /// <summary>
        /// use Protected Access Credential And Provision
        /// </summary>
        UseProtectedAccessCredentialAndProvision = 2,
	
        /// <summary>
        /// use Protected Access Credential And Provision Anonymously
        /// </summary>
        UseProtectedAccessCredentialAndProvisionAnonymously = 3,
	
    }
}
