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
    /// The type GovernanceRoleDefinitionRequestBuilder.
    /// </summary>
    public partial class GovernanceRoleDefinitionRequestBuilder : EntityRequestBuilder, IGovernanceRoleDefinitionRequestBuilder
    {

        /// <summary>
        /// Constructs a new GovernanceRoleDefinitionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GovernanceRoleDefinitionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleDefinitionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleDefinitionRequest Request(IEnumerable<Option> options)
        {
            return new GovernanceRoleDefinitionRequest(this.RequestUrl, this.Client, options);
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

        /// <summary>
        /// Gets the request builder for RoleSetting.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleSettingRequestBuilder"/>.</returns>
        public IGovernanceRoleSettingRequestBuilder RoleSetting
        {
            get
            {
                return new GovernanceRoleSettingRequestBuilder(this.AppendSegmentToRequestUrl("roleSetting"), this.Client);
            }
        }
    
    }
}
