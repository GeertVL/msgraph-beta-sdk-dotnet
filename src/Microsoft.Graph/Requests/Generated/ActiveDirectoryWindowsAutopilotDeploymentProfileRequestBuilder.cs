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
    /// The type ActiveDirectoryWindowsAutopilotDeploymentProfileRequestBuilder.
    /// </summary>
    public partial class ActiveDirectoryWindowsAutopilotDeploymentProfileRequestBuilder : WindowsAutopilotDeploymentProfileRequestBuilder, IActiveDirectoryWindowsAutopilotDeploymentProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new ActiveDirectoryWindowsAutopilotDeploymentProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ActiveDirectoryWindowsAutopilotDeploymentProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Request(IEnumerable<Option> options)
        {
            return new ActiveDirectoryWindowsAutopilotDeploymentProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DomainJoinConfiguration.
        /// </summary>
        /// <returns>The <see cref="IWindowsDomainJoinConfigurationRequestBuilder"/>.</returns>
        public IWindowsDomainJoinConfigurationRequestBuilder DomainJoinConfiguration
        {
            get
            {
                return new WindowsDomainJoinConfigurationRequestBuilder(this.AppendSegmentToRequestUrl("domainJoinConfiguration"), this.Client);
            }
        }
    
    }
}
