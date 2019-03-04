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
    /// The type ReportRootApplicationSignInDetailedSummaryCollectionRequestBuilder.
    /// </summary>
    public partial class ReportRootApplicationSignInDetailedSummaryCollectionRequestBuilder : BaseRequestBuilder, IReportRootApplicationSignInDetailedSummaryCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ReportRootApplicationSignInDetailedSummaryCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootApplicationSignInDetailedSummaryCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootApplicationSignInDetailedSummaryCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootApplicationSignInDetailedSummaryCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootApplicationSignInDetailedSummaryCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IApplicationSignInDetailedSummaryRequestBuilder"/> for the specified ReportRootApplicationSignInDetailedSummary.
        /// </summary>
        /// <param name="id">The ID for the ReportRootApplicationSignInDetailedSummary.</param>
        /// <returns>The <see cref="IApplicationSignInDetailedSummaryRequestBuilder"/>.</returns>
        public IApplicationSignInDetailedSummaryRequestBuilder this[string id]
        {
            get
            {
                return new ApplicationSignInDetailedSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
