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
    /// The type DeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementAndroidForWorkEnrollmentProfilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAndroidForWorkEnrollmentProfileRequestBuilder"/> for the specified DeviceManagementAndroidForWorkEnrollmentProfile.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementAndroidForWorkEnrollmentProfile.</param>
        /// <returns>The <see cref="IAndroidForWorkEnrollmentProfileRequestBuilder"/>.</returns>
        public IAndroidForWorkEnrollmentProfileRequestBuilder this[string id]
        {
            get
            {
                return new AndroidForWorkEnrollmentProfileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
