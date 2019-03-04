// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceAdministrativeUnitsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceAdministrativeUnitsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceAdministrativeUnitsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceAdministrativeUnitsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAdministrativeUnitRequestBuilder"/> for the specified AdministrativeUnit.
        /// </summary>
        /// <param name="id">The ID for the AdministrativeUnit.</param>
        /// <returns>The <see cref="IAdministrativeUnitRequestBuilder"/>.</returns>
        IAdministrativeUnitRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AdministrativeUnitDelta.
        /// </summary>
        /// <returns>The <see cref="IAdministrativeUnitDeltaRequestBuilder"/>.</returns>
        IAdministrativeUnitDeltaRequestBuilder Delta();
    }
}
