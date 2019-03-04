// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidManagedStoreAccountAppSyncStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidManagedStoreAccountAppSyncStatus
    {
    
        /// <summary>
        /// success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// credentials Not Valid
        /// </summary>
        CredentialsNotValid = 1,
	
        /// <summary>
        /// android For Work Api Error
        /// </summary>
        AndroidForWorkApiError = 2,
	
        /// <summary>
        /// management Service Error
        /// </summary>
        ManagementServiceError = 3,
	
        /// <summary>
        /// unknown Error
        /// </summary>
        UnknownError = 4,
	
        /// <summary>
        /// none
        /// </summary>
        None = 5,
	
    }
}
