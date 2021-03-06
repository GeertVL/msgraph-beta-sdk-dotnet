// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceGovernanceRoleSettingsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceGovernanceRoleSettingsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceGovernanceRoleSettingsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceGovernanceRoleSettingsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceGovernanceRoleSettingsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceGovernanceRoleSettingsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceGovernanceRoleSettingsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceGovernanceRoleSettingsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGovernanceRoleSettingRequestBuilder"/> for the specified GraphServiceGovernanceRoleSetting.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceGovernanceRoleSetting.</param>
        /// <returns>The <see cref="IGovernanceRoleSettingRequestBuilder"/>.</returns>
        public IGovernanceRoleSettingRequestBuilder this[string id]
        {
            get
            {
                return new GovernanceRoleSettingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
