// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type RoleScopeTagWithReferenceRequestBuilder.
    /// </summary>
    public partial class RoleScopeTagWithReferenceRequestBuilder : BaseRequestBuilder, IRoleScopeTagWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new RoleScopeTagWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RoleScopeTagWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IRoleScopeTagWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IRoleScopeTagWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new RoleScopeTagWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the roleScopeTag.
        /// </summary>
        /// <returns>The <see cref="IRoleScopeTagReferenceRequestBuilder"/>.</returns>
        public IRoleScopeTagReferenceRequestBuilder Reference
        {
            get
            {
                return new RoleScopeTagReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
