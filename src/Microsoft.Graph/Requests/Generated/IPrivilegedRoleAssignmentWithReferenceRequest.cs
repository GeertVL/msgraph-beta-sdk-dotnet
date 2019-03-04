// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrivilegedRoleAssignmentWithReferenceRequest.
    /// </summary>
    public partial interface IPrivilegedRoleAssignmentWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <returns>The PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified PrivilegedRoleAssignment using PUT.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToCreate">The PrivilegedRoleAssignment to create.</param>
        /// <returns>The created PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> CreateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToCreate);        /// <summary>
        /// Creates the specified PrivilegedRoleAssignment using PUT.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToCreate">The PrivilegedRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> CreateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified PrivilegedRoleAssignment using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToUpdate">The PrivilegedRoleAssignment to update.</param>
        /// <returns>The updated PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> UpdateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToUpdate);

        /// <summary>
        /// Updates the specified PrivilegedRoleAssignment using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToUpdate">The PrivilegedRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PrivilegedRoleAssignment.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleAssignment> UpdateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentWithReferenceRequest Expand(Expression<Func<PrivilegedRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleAssignmentWithReferenceRequest Select(Expression<Func<PrivilegedRoleAssignment, object>> selectExpression);

    }
}
