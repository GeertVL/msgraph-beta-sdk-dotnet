// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type IntuneBrandingProfileAssignRequestBuilder.
    /// </summary>
    public partial class IntuneBrandingProfileAssignRequestBuilder : BaseActionMethodRequestBuilder<IIntuneBrandingProfileAssignRequest>, IIntuneBrandingProfileAssignRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="IntuneBrandingProfileAssignRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="assignments">A assignments parameter for the OData method call.</param>
        public IntuneBrandingProfileAssignRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<IntuneBrandingProfileAssignment> assignments)
            : base(requestUrl, client)
        {
            this.SetParameter("assignments", assignments, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IIntuneBrandingProfileAssignRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new IntuneBrandingProfileAssignRequest(functionUrl, this.Client, options);

            if (this.HasParameter("assignments"))
            {
                request.RequestBody.Assignments = this.GetParameter<IEnumerable<IntuneBrandingProfileAssignment>>("assignments");
            }

            return request;
        }
    }
}
