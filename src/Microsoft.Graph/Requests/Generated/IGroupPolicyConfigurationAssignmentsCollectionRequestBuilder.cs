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
    /// The interface IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGroupPolicyConfigurationAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGroupPolicyConfigurationAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGroupPolicyConfigurationAssignmentRequestBuilder"/> for the specified GroupPolicyConfigurationAssignment.
        /// </summary>
        /// <param name="id">The ID for the GroupPolicyConfigurationAssignment.</param>
        /// <returns>The <see cref="IGroupPolicyConfigurationAssignmentRequestBuilder"/>.</returns>
        IGroupPolicyConfigurationAssignmentRequestBuilder this[string id] { get; }

        
    }
}
