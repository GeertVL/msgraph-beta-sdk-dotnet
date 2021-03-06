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
    /// The type DeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsDeviceStartupHistoryCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsDeviceStartupHistoryRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsDeviceStartupHistory.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsDeviceStartupHistory.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsDeviceStartupHistoryRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsDeviceStartupHistoryRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
