// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IProfilePublicationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IProfilePublicationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IProfilePublicationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IProfilePublicationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IItemPublicationRequestBuilder"/> for the specified ItemPublication.
        /// </summary>
        /// <param name="id">The ID for the ItemPublication.</param>
        /// <returns>The <see cref="IItemPublicationRequestBuilder"/>.</returns>
        IItemPublicationRequestBuilder this[string id] { get; }

        
    }
}