// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGroupGroupLifecyclePoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGroupGroupLifecyclePoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGroupGroupLifecyclePoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGroupGroupLifecyclePoliciesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGroupLifecyclePolicyRequestBuilder"/> for the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="id">The ID for the GroupLifecyclePolicy.</param>
        /// <returns>The <see cref="IGroupLifecyclePolicyRequestBuilder"/>.</returns>
        IGroupLifecyclePolicyRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for GroupLifecyclePolicyRenewGroup.
        /// </summary>
        /// <returns>The <see cref="IGroupLifecyclePolicyRenewGroupRequestBuilder"/>.</returns>
        IGroupLifecyclePolicyRenewGroupRequestBuilder RenewGroup(
            string groupId);
    }
}
