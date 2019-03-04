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
    /// The interface IMacOSImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IMacOSImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSImportedPFXCertificateProfile using PUT.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToCreate">The MacOSImportedPFXCertificateProfile to create.</param>
        /// <returns>The created MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> CreateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToCreate);        /// <summary>
        /// Creates the specified MacOSImportedPFXCertificateProfile using PUT.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToCreate">The MacOSImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> CreateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToUpdate">The MacOSImportedPFXCertificateProfile to update.</param>
        /// <returns>The updated MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> UpdateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified MacOSImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToUpdate">The MacOSImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MacOSImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> UpdateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSImportedPFXCertificateProfileRequest Expand(Expression<Func<MacOSImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSImportedPFXCertificateProfileRequest Select(Expression<Func<MacOSImportedPFXCertificateProfile, object>> selectExpression);

    }
}
