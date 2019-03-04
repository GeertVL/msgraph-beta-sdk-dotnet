// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GovernanceRoleSettingRequestBuilder.
    /// </summary>
    public partial class GovernanceRoleSettingRequestBuilder : EntityRequestBuilder, IGovernanceRoleSettingRequestBuilder
    {

        /// <summary>
        /// Constructs a new GovernanceRoleSettingRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GovernanceRoleSettingRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleSettingRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleSettingRequest Request(IEnumerable<Option> options)
        {
            return new GovernanceRoleSettingRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RoleDefinition.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleDefinitionRequestBuilder"/>.</returns>
        public IGovernanceRoleDefinitionRequestBuilder RoleDefinition
        {
            get
            {
                return new GovernanceRoleDefinitionRequestBuilder(this.AppendSegmentToRequestUrl("roleDefinition"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Resource.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        public IGovernanceResourceRequestBuilder Resource
        {
            get
            {
                return new GovernanceResourceRequestBuilder(this.AppendSegmentToRequestUrl("resource"), this.Client);
            }
        }
    
    }
}
