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
    /// The interface IWindowsInformationProtectionWipeActionRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionWipeActionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsInformationProtectionWipeAction using PUT.
        /// </summary>
        /// <param name="windowsInformationProtectionWipeActionToCreate">The WindowsInformationProtectionWipeAction to create.</param>
        /// <returns>The created WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> CreateAsync(WindowsInformationProtectionWipeAction windowsInformationProtectionWipeActionToCreate);        /// <summary>
        /// Creates the specified WindowsInformationProtectionWipeAction using PUT.
        /// </summary>
        /// <param name="windowsInformationProtectionWipeActionToCreate">The WindowsInformationProtectionWipeAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> CreateAsync(WindowsInformationProtectionWipeAction windowsInformationProtectionWipeActionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionWipeAction.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionWipeAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsInformationProtectionWipeAction.
        /// </summary>
        /// <returns>The WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> GetAsync();

        /// <summary>
        /// Gets the specified WindowsInformationProtectionWipeAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionWipeAction using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionWipeActionToUpdate">The WindowsInformationProtectionWipeAction to update.</param>
        /// <returns>The updated WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> UpdateAsync(WindowsInformationProtectionWipeAction windowsInformationProtectionWipeActionToUpdate);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionWipeAction using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionWipeActionToUpdate">The WindowsInformationProtectionWipeAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsInformationProtectionWipeAction.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionWipeAction> UpdateAsync(WindowsInformationProtectionWipeAction windowsInformationProtectionWipeActionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionWipeActionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionWipeActionRequest Expand(Expression<Func<WindowsInformationProtectionWipeAction, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionWipeActionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionWipeActionRequest Select(Expression<Func<WindowsInformationProtectionWipeAction, object>> selectExpression);

    }
}
