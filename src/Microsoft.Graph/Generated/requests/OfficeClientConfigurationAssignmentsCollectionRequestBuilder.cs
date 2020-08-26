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
    /// The type OfficeClientConfigurationAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class OfficeClientConfigurationAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IOfficeClientConfigurationAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OfficeClientConfigurationAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OfficeClientConfigurationAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOfficeClientConfigurationAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOfficeClientConfigurationAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OfficeClientConfigurationAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOfficeClientConfigurationAssignmentRequestBuilder"/> for the specified OfficeClientConfigurationOfficeClientConfigurationAssignment.
        /// </summary>
        /// <param name="id">The ID for the OfficeClientConfigurationOfficeClientConfigurationAssignment.</param>
        /// <returns>The <see cref="IOfficeClientConfigurationAssignmentRequestBuilder"/>.</returns>
        public IOfficeClientConfigurationAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new OfficeClientConfigurationAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}