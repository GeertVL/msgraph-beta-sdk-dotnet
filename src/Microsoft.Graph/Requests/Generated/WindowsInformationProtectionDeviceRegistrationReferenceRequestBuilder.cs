// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder.
    /// </summary>
    public partial class WindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder : BaseRequestBuilder, IWindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionDeviceRegistrationReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionDeviceRegistrationReferenceRequest Request(IEnumerable<Option> options)
        {
            return new WindowsInformationProtectionDeviceRegistrationReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
