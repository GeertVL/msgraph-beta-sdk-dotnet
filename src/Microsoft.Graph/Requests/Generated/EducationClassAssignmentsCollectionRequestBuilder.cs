// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationClassAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class EducationClassAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IEducationClassAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EducationClassAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationClassAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationClassAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationClassAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EducationClassAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationAssignmentRequestBuilder"/> for the specified EducationClassEducationAssignment.
        /// </summary>
        /// <param name="id">The ID for the EducationClassEducationAssignment.</param>
        /// <returns>The <see cref="IEducationAssignmentRequestBuilder"/>.</returns>
        public IEducationAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new EducationAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
