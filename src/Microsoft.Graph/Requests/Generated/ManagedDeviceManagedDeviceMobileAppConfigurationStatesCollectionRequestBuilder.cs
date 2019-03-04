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
    /// The type ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder : BaseRequestBuilder, IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceMobileAppConfigurationStateRequestBuilder"/> for the specified ManagedDeviceManagedDeviceMobileAppConfigurationState.
        /// </summary>
        /// <param name="id">The ID for the ManagedDeviceManagedDeviceMobileAppConfigurationState.</param>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationStateRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationStateRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
