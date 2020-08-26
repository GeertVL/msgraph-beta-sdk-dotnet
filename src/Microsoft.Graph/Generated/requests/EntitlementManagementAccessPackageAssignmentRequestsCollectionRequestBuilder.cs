// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial class EntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder : BaseRequestBuilder, IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EntitlementManagementAccessPackageAssignmentRequestsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEntitlementManagementAccessPackageAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EntitlementManagementAccessPackageAssignmentRequestsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageAssignmentRequestRequestBuilder"/> for the specified EntitlementManagementAccessPackageAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the EntitlementManagementAccessPackageAssignmentRequest.</param>
        /// <returns>The <see cref="IAccessPackageAssignmentRequestRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentRequestRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageAssignmentRequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentRequestMy.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentRequestMyRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentRequestMyRequestBuilder My()
        {
            return new AccessPackageAssignmentRequestMyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.My"),
                this.Client);
        }
    }
}