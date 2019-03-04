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
    /// The type OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder.
    /// </summary>
    public partial class OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder : BaseRequestBuilder, IOutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOutlookTaskFolderMultiValueExtendedPropertiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOutlookTaskFolderMultiValueExtendedPropertiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/> for the specified OutlookTaskFolderMultiValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="id">The ID for the OutlookTaskFolderMultiValueLegacyExtendedProperty.</param>
        /// <returns>The <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/>.</returns>
        public IMultiValueLegacyExtendedPropertyRequestBuilder this[string id]
        {
            get
            {
                return new MultiValueLegacyExtendedPropertyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
