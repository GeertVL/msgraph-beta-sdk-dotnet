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
    /// The interface ITimeOffRequest.
    /// </summary>
    public partial interface ITimeOffRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TimeOff using POST.
        /// </summary>
        /// <param name="timeOffToCreate">The TimeOff to create.</param>
        /// <returns>The created TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> CreateAsync(TimeOff timeOffToCreate);        /// <summary>
        /// Creates the specified TimeOff using POST.
        /// </summary>
        /// <param name="timeOffToCreate">The TimeOff to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> CreateAsync(TimeOff timeOffToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TimeOff.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TimeOff.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TimeOff.
        /// </summary>
        /// <returns>The TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> GetAsync();

        /// <summary>
        /// Gets the specified TimeOff.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TimeOff using PATCH.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff to update.</param>
        /// <returns>The updated TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> UpdateAsync(TimeOff timeOffToUpdate);

        /// <summary>
        /// Updates the specified TimeOff using PATCH.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> UpdateAsync(TimeOff timeOffToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Expand(Expression<Func<TimeOff, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Select(Expression<Func<TimeOff, object>> selectExpression);

    }
}
