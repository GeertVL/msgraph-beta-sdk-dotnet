// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequestBuilder.
    /// </summary>
    public partial class AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequestBuilder : BaseRequestBuilder, IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new AndroidDeviceOwnerCertificateProfileBaseWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the androidDeviceOwnerCertificateProfileBase.
        /// </summary>
        /// <returns>The <see cref="IAndroidDeviceOwnerCertificateProfileBaseReferenceRequestBuilder"/>.</returns>
        public IAndroidDeviceOwnerCertificateProfileBaseReferenceRequestBuilder Reference
        {
            get
            {
                return new AndroidDeviceOwnerCertificateProfileBaseReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
