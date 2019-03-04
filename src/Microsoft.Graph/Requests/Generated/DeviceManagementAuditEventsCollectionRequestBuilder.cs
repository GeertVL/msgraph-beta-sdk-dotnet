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
    /// The type DeviceManagementAuditEventsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementAuditEventsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementAuditEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementAuditEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementAuditEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementAuditEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementAuditEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementAuditEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAuditEventRequestBuilder"/> for the specified DeviceManagementAuditEvent.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementAuditEvent.</param>
        /// <returns>The <see cref="IAuditEventRequestBuilder"/>.</returns>
        public IAuditEventRequestBuilder this[string id]
        {
            get
            {
                return new AuditEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AuditEventGetAuditCategories.
        /// </summary>
        /// <returns>The <see cref="IAuditEventGetAuditCategoriesRequestBuilder"/>.</returns>
        public IAuditEventGetAuditCategoriesRequestBuilder GetAuditCategories()
        {
            return new AuditEventGetAuditCategoriesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getAuditCategories"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AuditEventGetAuditActivityTypes.
        /// </summary>
        /// <returns>The <see cref="IAuditEventGetAuditActivityTypesRequestBuilder"/>.</returns>
        public IAuditEventGetAuditActivityTypesRequestBuilder GetAuditActivityTypes(
            string category = null)
        {
            return new AuditEventGetAuditActivityTypesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getAuditActivityTypes"),
                this.Client,
                category);
        }
    }
}
