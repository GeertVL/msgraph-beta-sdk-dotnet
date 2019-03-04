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
    /// The type DeviceManagementDeviceConfigurationConflictSummaryCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceConfigurationConflictSummaryCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceConfigurationConflictSummaryCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceConfigurationConflictSummaryCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceConfigurationConflictSummaryCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationConflictSummaryCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationConflictSummaryCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceConfigurationConflictSummaryCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationConflictSummaryRequestBuilder"/> for the specified DeviceManagementDeviceConfigurationConflictSummary.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceConfigurationConflictSummary.</param>
        /// <returns>The <see cref="IDeviceConfigurationConflictSummaryRequestBuilder"/>.</returns>
        public IDeviceConfigurationConflictSummaryRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationConflictSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
