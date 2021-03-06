// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SynchronizationJobValidateCredentialsRequestBuilder.
    /// </summary>
    public partial class SynchronizationJobValidateCredentialsRequestBuilder : BaseActionMethodRequestBuilder<ISynchronizationJobValidateCredentialsRequest>, ISynchronizationJobValidateCredentialsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SynchronizationJobValidateCredentialsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="applicationIdentifier">A applicationIdentifier parameter for the OData method call.</param>
        /// <param name="templateId">A templateId parameter for the OData method call.</param>
        /// <param name="useSavedCredentials">A useSavedCredentials parameter for the OData method call.</param>
        /// <param name="credentials">A credentials parameter for the OData method call.</param>
        public SynchronizationJobValidateCredentialsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string applicationIdentifier,
            string templateId,
            bool? useSavedCredentials,
            IEnumerable<SynchronizationSecretKeyStringValuePair> credentials)
            : base(requestUrl, client)
        {
            this.SetParameter("applicationIdentifier", applicationIdentifier, true);
            this.SetParameter("templateId", templateId, true);
            this.SetParameter("useSavedCredentials", useSavedCredentials, true);
            this.SetParameter("credentials", credentials, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISynchronizationJobValidateCredentialsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new SynchronizationJobValidateCredentialsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("applicationIdentifier"))
            {
                request.RequestBody.ApplicationIdentifier = this.GetParameter<string>("applicationIdentifier");
            }

            if (this.HasParameter("templateId"))
            {
                request.RequestBody.TemplateId = this.GetParameter<string>("templateId");
            }

            if (this.HasParameter("useSavedCredentials"))
            {
                request.RequestBody.UseSavedCredentials = this.GetParameter<bool?>("useSavedCredentials");
            }

            if (this.HasParameter("credentials"))
            {
                request.RequestBody.Credentials = this.GetParameter<IEnumerable<SynchronizationSecretKeyStringValuePair>>("credentials");
            }

            return request;
        }
    }
}
