// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest.
    /// </summary>
    public partial interface IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Expand(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Select(Expression<Func<WindowsInformationProtectionDeviceRegistration, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserWindowsInformationProtectionDeviceRegistrationsCollectionWithReferencesRequest OrderBy(string value);
    }
}
