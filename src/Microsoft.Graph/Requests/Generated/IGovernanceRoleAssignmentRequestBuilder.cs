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
    /// The interface IGovernanceRoleAssignmentRequestBuilder.
    /// </summary>
    public partial interface IGovernanceRoleAssignmentRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGovernanceRoleAssignmentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGovernanceRoleAssignmentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Resource.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        IGovernanceResourceRequestBuilder Resource { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinition.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleDefinitionRequestBuilder"/>.</returns>
        IGovernanceRoleDefinitionRequestBuilder RoleDefinition { get; }

        /// <summary>
        /// Gets the request builder for Subject.
        /// </summary>
        /// <returns>The <see cref="IGovernanceSubjectRequestBuilder"/>.</returns>
        IGovernanceSubjectRequestBuilder Subject { get; }

        /// <summary>
        /// Gets the request builder for LinkedEligibleRoleAssignment.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentWithReferenceRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentWithReferenceRequestBuilder LinkedEligibleRoleAssignment { get; }
    
        
    
    }
}
