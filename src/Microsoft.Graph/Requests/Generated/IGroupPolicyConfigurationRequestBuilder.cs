// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGroupPolicyConfigurationRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyConfigurationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupPolicyConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupPolicyConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DefinitionValues.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationDefinitionValuesCollectionRequestBuilder"/>.</returns>
        IGroupPolicyConfigurationDefinitionValuesCollectionRequestBuilder DefinitionValues { get; }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }
    
        /// <summary>
        /// Gets the request builder for GroupPolicyConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationAssignRequestBuilder"/>.</returns>
        IGroupPolicyConfigurationAssignRequestBuilder Assign(
            IEnumerable<GroupPolicyConfigurationAssignment> assignments = null);
    
    }
}
