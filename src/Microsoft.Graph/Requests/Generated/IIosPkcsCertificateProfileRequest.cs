// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosPkcsCertificateProfileRequest.
    /// </summary>
    public partial interface IIosPkcsCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosPkcsCertificateProfile using PUT.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToCreate">The IosPkcsCertificateProfile to create.</param>
        /// <returns>The created IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> CreateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToCreate);        /// <summary>
        /// Creates the specified IosPkcsCertificateProfile using PUT.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToCreate">The IosPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> CreateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <returns>The IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToUpdate">The IosPkcsCertificateProfile to update.</param>
        /// <returns>The updated IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> UpdateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified IosPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToUpdate">The IosPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> UpdateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Expand(Expression<Func<IosPkcsCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Select(Expression<Func<IosPkcsCertificateProfile, object>> selectExpression);

    }
}
