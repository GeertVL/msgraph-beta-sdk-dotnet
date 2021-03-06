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
    /// The type ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder : BaseActionMethodRequestBuilder<IServicePrincipalUpdatePasswordSingleSignOnCredentialsRequest>, IServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="id">A id parameter for the OData method call.</param>
        /// <param name="credentials">A credentials parameter for the OData method call.</param>
        public ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string id,
            IEnumerable<Credential> credentials)
            : base(requestUrl, client)
        {
            this.SetParameter("id", id, false);
            this.SetParameter("credentials", credentials, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IServicePrincipalUpdatePasswordSingleSignOnCredentialsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ServicePrincipalUpdatePasswordSingleSignOnCredentialsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("id"))
            {
                request.RequestBody.Id = this.GetParameter<string>("id");
            }

            if (this.HasParameter("credentials"))
            {
                request.RequestBody.Credentials = this.GetParameter<IEnumerable<Credential>>("credentials");
            }

            return request;
        }
    }
}
