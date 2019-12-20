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
    /// The interface IMacOSWiredNetworkConfigurationRequest.
    /// </summary>
    public partial interface IMacOSWiredNetworkConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSWiredNetworkConfiguration using POST.
        /// </summary>
        /// <param name="macOSWiredNetworkConfigurationToCreate">The MacOSWiredNetworkConfiguration to create.</param>
        /// <returns>The created MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> CreateAsync(MacOSWiredNetworkConfiguration macOSWiredNetworkConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSWiredNetworkConfiguration using POST.
        /// </summary>
        /// <param name="macOSWiredNetworkConfigurationToCreate">The MacOSWiredNetworkConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> CreateAsync(MacOSWiredNetworkConfiguration macOSWiredNetworkConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSWiredNetworkConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSWiredNetworkConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSWiredNetworkConfiguration.
        /// </summary>
        /// <returns>The MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSWiredNetworkConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSWiredNetworkConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSWiredNetworkConfigurationToUpdate">The MacOSWiredNetworkConfiguration to update.</param>
        /// <returns>The updated MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> UpdateAsync(MacOSWiredNetworkConfiguration macOSWiredNetworkConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSWiredNetworkConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSWiredNetworkConfigurationToUpdate">The MacOSWiredNetworkConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSWiredNetworkConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiredNetworkConfiguration> UpdateAsync(MacOSWiredNetworkConfiguration macOSWiredNetworkConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiredNetworkConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiredNetworkConfigurationRequest Expand(Expression<Func<MacOSWiredNetworkConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiredNetworkConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiredNetworkConfigurationRequest Select(Expression<Func<MacOSWiredNetworkConfiguration, object>> selectExpression);

    }
}