// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceProgramsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceProgramsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceProgramsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceProgramsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceProgramsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceProgramsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceProgramsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceProgramsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IProgramRequestBuilder"/> for the specified GraphServiceProgram.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceProgram.</param>
        /// <returns>The <see cref="IProgramRequestBuilder"/>.</returns>
        public IProgramRequestBuilder this[string id]
        {
            get
            {
                return new ProgramRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}