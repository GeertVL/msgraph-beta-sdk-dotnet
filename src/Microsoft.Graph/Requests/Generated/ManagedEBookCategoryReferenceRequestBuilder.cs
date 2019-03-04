// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedEBookCategoryReferenceRequestBuilder.
    /// </summary>
    public partial class ManagedEBookCategoryReferenceRequestBuilder : BaseRequestBuilder, IManagedEBookCategoryReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedEBookCategoryReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedEBookCategoryReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedEBookCategoryReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedEBookCategoryReferenceRequest Request(IEnumerable<Option> options)
        {
            return new ManagedEBookCategoryReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
