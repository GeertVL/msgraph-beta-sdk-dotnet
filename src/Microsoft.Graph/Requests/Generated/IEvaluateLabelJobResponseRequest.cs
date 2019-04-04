// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEvaluateLabelJobResponseRequest.
    /// </summary>
    public partial interface IEvaluateLabelJobResponseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EvaluateLabelJobResponse using PUT.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToCreate">The EvaluateLabelJobResponse to create.</param>
        /// <returns>The created EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> CreateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToCreate);        /// <summary>
        /// Creates the specified EvaluateLabelJobResponse using PUT.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToCreate">The EvaluateLabelJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> CreateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <returns>The EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> GetAsync();

        /// <summary>
        /// Gets the specified EvaluateLabelJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EvaluateLabelJobResponse using PATCH.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToUpdate">The EvaluateLabelJobResponse to update.</param>
        /// <returns>The updated EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> UpdateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToUpdate);

        /// <summary>
        /// Updates the specified EvaluateLabelJobResponse using PATCH.
        /// </summary>
        /// <param name="evaluateLabelJobResponseToUpdate">The EvaluateLabelJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EvaluateLabelJobResponse.</returns>
        System.Threading.Tasks.Task<EvaluateLabelJobResponse> UpdateAsync(EvaluateLabelJobResponse evaluateLabelJobResponseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Expand(Expression<Func<EvaluateLabelJobResponse, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEvaluateLabelJobResponseRequest Select(Expression<Func<EvaluateLabelJobResponse, object>> selectExpression);

    }
}