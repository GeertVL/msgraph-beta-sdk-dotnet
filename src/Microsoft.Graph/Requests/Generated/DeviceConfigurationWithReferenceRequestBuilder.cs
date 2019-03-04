// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceConfigurationWithReferenceRequestBuilder.
    /// </summary>
    public partial class DeviceConfigurationWithReferenceRequestBuilder : BaseRequestBuilder, IDeviceConfigurationWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceConfigurationWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceConfigurationWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceConfigurationWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceConfigurationWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new DeviceConfigurationWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the deviceConfiguration.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationReferenceRequestBuilder"/>.</returns>
        public IDeviceConfigurationReferenceRequestBuilder Reference
        {
            get
            {
                return new DeviceConfigurationReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
