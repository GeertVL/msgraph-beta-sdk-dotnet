// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementComplexSettingInstanceRequestBuilder.
    /// </summary>
    public partial class DeviceManagementComplexSettingInstanceRequestBuilder : DeviceManagementSettingInstanceRequestBuilder, IDeviceManagementComplexSettingInstanceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementComplexSettingInstanceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementComplexSettingInstanceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceManagementComplexSettingInstanceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceManagementComplexSettingInstanceRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementComplexSettingInstanceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Value.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementComplexSettingInstanceValueCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementComplexSettingInstanceValueCollectionRequestBuilder Value
        {
            get
            {
                return new DeviceManagementComplexSettingInstanceValueCollectionRequestBuilder(this.AppendSegmentToRequestUrl("value"), this.Client);
            }
        }
    
    }
}
