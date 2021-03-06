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
    /// The interface IMacOSSoftwareUpdateConfigurationRequest.
    /// </summary>
    public partial interface IMacOSSoftwareUpdateConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <returns>The created MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> CreateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateConfiguration using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToCreate">The MacOSSoftwareUpdateConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> CreateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <returns>The MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <returns>The updated MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> UpdateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateConfigurationToUpdate">The MacOSSoftwareUpdateConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSSoftwareUpdateConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSSoftwareUpdateConfiguration> UpdateAsync(MacOSSoftwareUpdateConfiguration macOSSoftwareUpdateConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSSoftwareUpdateConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSSoftwareUpdateConfigurationRequest Expand(Expression<Func<MacOSSoftwareUpdateConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSSoftwareUpdateConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSSoftwareUpdateConfigurationRequest Select(Expression<Func<MacOSSoftwareUpdateConfiguration, object>> selectExpression);

    }
}
