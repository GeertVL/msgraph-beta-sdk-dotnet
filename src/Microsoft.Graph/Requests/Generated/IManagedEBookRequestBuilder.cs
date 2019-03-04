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
    /// The interface IManagedEBookRequestBuilder.
    /// </summary>
    public partial interface IManagedEBookRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedEBookRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedEBookRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookCategoriesCollectionWithReferencesRequestBuilder"/>.</returns>
        IManagedEBookCategoriesCollectionWithReferencesRequestBuilder Categories { get; }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookAssignmentsCollectionRequestBuilder"/>.</returns>
        IManagedEBookAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for InstallSummary.
        /// </summary>
        /// <returns>The <see cref="IEBookInstallSummaryRequestBuilder"/>.</returns>
        IEBookInstallSummaryRequestBuilder InstallSummary { get; }

        /// <summary>
        /// Gets the request builder for DeviceStates.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookDeviceStatesCollectionRequestBuilder"/>.</returns>
        IManagedEBookDeviceStatesCollectionRequestBuilder DeviceStates { get; }

        /// <summary>
        /// Gets the request builder for UserStateSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookUserStateSummaryCollectionRequestBuilder"/>.</returns>
        IManagedEBookUserStateSummaryCollectionRequestBuilder UserStateSummary { get; }
    
        /// <summary>
        /// Gets the request builder for ManagedEBookAssign.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookAssignRequestBuilder"/>.</returns>
        IManagedEBookAssignRequestBuilder Assign(
            IEnumerable<ManagedEBookAssignment> managedEBookAssignments = null);
    
    }
}
