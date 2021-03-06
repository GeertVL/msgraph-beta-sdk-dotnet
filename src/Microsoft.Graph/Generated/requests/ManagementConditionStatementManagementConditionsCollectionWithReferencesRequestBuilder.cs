// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagementConditionStatementManagementConditionsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagementConditionStatementManagementConditionsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagementConditionStatementManagementConditionsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ManagementConditionStatementManagementConditionsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagementConditionWithReferenceRequestBuilder"/> for the specified ManagementConditionStatementManagementCondition.
        /// </summary>
        /// <param name="id">The ID for the ManagementConditionStatementManagementCondition.</param>
        /// <returns>The <see cref="IManagementConditionWithReferenceRequestBuilder"/>.</returns>
        public IManagementConditionWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagementConditionWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IManagementConditionStatementManagementConditionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagementConditionStatementManagementConditionsCollectionReferencesRequestBuilder"/>.</returns>
        public IManagementConditionStatementManagementConditionsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ManagementConditionStatementManagementConditionsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
