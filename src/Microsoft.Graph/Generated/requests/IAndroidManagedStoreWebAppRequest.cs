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
    /// The interface IAndroidManagedStoreWebAppRequest.
    /// </summary>
    public partial interface IAndroidManagedStoreWebAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidManagedStoreWebApp using POST.
        /// </summary>
        /// <param name="androidManagedStoreWebAppToCreate">The AndroidManagedStoreWebApp to create.</param>
        /// <returns>The created AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> CreateAsync(AndroidManagedStoreWebApp androidManagedStoreWebAppToCreate);        /// <summary>
        /// Creates the specified AndroidManagedStoreWebApp using POST.
        /// </summary>
        /// <param name="androidManagedStoreWebAppToCreate">The AndroidManagedStoreWebApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> CreateAsync(AndroidManagedStoreWebApp androidManagedStoreWebAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidManagedStoreWebApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidManagedStoreWebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidManagedStoreWebApp.
        /// </summary>
        /// <returns>The AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> GetAsync();

        /// <summary>
        /// Gets the specified AndroidManagedStoreWebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidManagedStoreWebApp using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreWebAppToUpdate">The AndroidManagedStoreWebApp to update.</param>
        /// <returns>The updated AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> UpdateAsync(AndroidManagedStoreWebApp androidManagedStoreWebAppToUpdate);

        /// <summary>
        /// Updates the specified AndroidManagedStoreWebApp using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreWebAppToUpdate">The AndroidManagedStoreWebApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreWebApp.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreWebApp> UpdateAsync(AndroidManagedStoreWebApp androidManagedStoreWebAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreWebAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreWebAppRequest Expand(Expression<Func<AndroidManagedStoreWebApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreWebAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreWebAppRequest Select(Expression<Func<AndroidManagedStoreWebApp, object>> selectExpression);

    }
}