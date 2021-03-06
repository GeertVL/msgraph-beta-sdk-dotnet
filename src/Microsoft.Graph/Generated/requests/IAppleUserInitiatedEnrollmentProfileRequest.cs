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
    /// The interface IAppleUserInitiatedEnrollmentProfileRequest.
    /// </summary>
    public partial interface IAppleUserInitiatedEnrollmentProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AppleUserInitiatedEnrollmentProfile using POST.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToCreate">The AppleUserInitiatedEnrollmentProfile to create.</param>
        /// <returns>The created AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> CreateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToCreate);        /// <summary>
        /// Creates the specified AppleUserInitiatedEnrollmentProfile using POST.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToCreate">The AppleUserInitiatedEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> CreateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <returns>The AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> GetAsync();

        /// <summary>
        /// Gets the specified AppleUserInitiatedEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AppleUserInitiatedEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToUpdate">The AppleUserInitiatedEnrollmentProfile to update.</param>
        /// <returns>The updated AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> UpdateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToUpdate);

        /// <summary>
        /// Updates the specified AppleUserInitiatedEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="appleUserInitiatedEnrollmentProfileToUpdate">The AppleUserInitiatedEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppleUserInitiatedEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AppleUserInitiatedEnrollmentProfile> UpdateAsync(AppleUserInitiatedEnrollmentProfile appleUserInitiatedEnrollmentProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleUserInitiatedEnrollmentProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAppleUserInitiatedEnrollmentProfileRequest Expand(Expression<Func<AppleUserInitiatedEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleUserInitiatedEnrollmentProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAppleUserInitiatedEnrollmentProfileRequest Select(Expression<Func<AppleUserInitiatedEnrollmentProfile, object>> selectExpression);

    }
}
