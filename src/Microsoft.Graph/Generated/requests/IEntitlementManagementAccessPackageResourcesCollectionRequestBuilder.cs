// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder.
    /// </summary>
    public partial interface IEntitlementManagementAccessPackageResourcesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEntitlementManagementAccessPackageResourcesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEntitlementManagementAccessPackageResourcesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAccessPackageResourceRequestBuilder"/> for the specified AccessPackageResource.
        /// </summary>
        /// <param name="id">The ID for the AccessPackageResource.</param>
        /// <returns>The <see cref="IAccessPackageResourceRequestBuilder"/>.</returns>
        IAccessPackageResourceRequestBuilder this[string id] { get; }

        
    }
}
