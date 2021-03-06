// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISecurityBaselineSettingStateRequest.
    /// </summary>
    public partial interface ISecurityBaselineSettingStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityBaselineSettingState using POST.
        /// </summary>
        /// <param name="securityBaselineSettingStateToCreate">The SecurityBaselineSettingState to create.</param>
        /// <returns>The created SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> CreateAsync(SecurityBaselineSettingState securityBaselineSettingStateToCreate);        /// <summary>
        /// Creates the specified SecurityBaselineSettingState using POST.
        /// </summary>
        /// <param name="securityBaselineSettingStateToCreate">The SecurityBaselineSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> CreateAsync(SecurityBaselineSettingState securityBaselineSettingStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineSettingState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineSettingState.
        /// </summary>
        /// <returns>The SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> GetAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineSettingState using PATCH.
        /// </summary>
        /// <param name="securityBaselineSettingStateToUpdate">The SecurityBaselineSettingState to update.</param>
        /// <returns>The updated SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> UpdateAsync(SecurityBaselineSettingState securityBaselineSettingStateToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineSettingState using PATCH.
        /// </summary>
        /// <param name="securityBaselineSettingStateToUpdate">The SecurityBaselineSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityBaselineSettingState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineSettingState> UpdateAsync(SecurityBaselineSettingState securityBaselineSettingStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineSettingStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineSettingStateRequest Expand(Expression<Func<SecurityBaselineSettingState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineSettingStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineSettingStateRequest Select(Expression<Func<SecurityBaselineSettingState, object>> selectExpression);

    }
}
