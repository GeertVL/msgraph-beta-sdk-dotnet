// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceCompliancePolicyWithReferenceRequestBuilder.
    /// </summary>
    public partial interface IDeviceCompliancePolicyWithReferenceRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets the request builder for the reference of the deviceCompliancePolicy.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyReferenceRequestBuilder"/>.</returns>
        IDeviceCompliancePolicyReferenceRequestBuilder Reference { get; }

    }
}
