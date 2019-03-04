// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupPolicyPresentationValueBooleanRequestBuilder.
    /// </summary>
    public partial class GroupPolicyPresentationValueBooleanRequestBuilder : GroupPolicyPresentationValueRequestBuilder, IGroupPolicyPresentationValueBooleanRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyPresentationValueBooleanRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyPresentationValueBooleanRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupPolicyPresentationValueBooleanRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupPolicyPresentationValueBooleanRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyPresentationValueBooleanRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
