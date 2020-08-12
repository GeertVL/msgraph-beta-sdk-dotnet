// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ExternalConnectionRequest.
    /// </summary>
    public partial class ExternalConnectionRequest : BaseRequest, IExternalConnectionRequest
    {
        /// <summary>
        /// Constructs a new ExternalConnectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ExternalConnectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ExternalConnection using POST.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <returns>The created ExternalConnection.</returns>
        public System.Threading.Tasks.Task<ExternalConnection> CreateAsync(ExternalConnection externalConnectionToCreate)
        {
            return this.CreateAsync(externalConnectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ExternalConnection using POST.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> CreateAsync(ExternalConnection externalConnectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ExternalConnection>(externalConnectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ExternalConnection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ExternalConnection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ExternalConnection.
        /// </summary>
        /// <returns>The ExternalConnection.</returns>
        public System.Threading.Tasks.Task<ExternalConnection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ExternalConnection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <returns>The updated ExternalConnection.</returns>
        public System.Threading.Tasks.Task<ExternalConnection> UpdateAsync(ExternalConnection externalConnectionToUpdate)
        {
            return this.UpdateAsync(externalConnectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> UpdateAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken)
        {
			if (externalConnectionToUpdate.AdditionalData != null)
			{
				if (externalConnectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					externalConnectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, externalConnectionToUpdate.GetType().Name)
						});
				}
			}
            if (externalConnectionToUpdate.AdditionalData != null)
            {
                if (externalConnectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    externalConnectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, externalConnectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ExternalConnection>(externalConnectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Expand(Expression<Func<ExternalConnection, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Select(Expression<Func<ExternalConnection, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="externalConnectionToInitialize">The <see cref="ExternalConnection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ExternalConnection externalConnectionToInitialize)
        {

            if (externalConnectionToInitialize != null && externalConnectionToInitialize.AdditionalData != null)
            {

                if (externalConnectionToInitialize.Items != null && externalConnectionToInitialize.Items.CurrentPage != null)
                {
                    externalConnectionToInitialize.Items.AdditionalData = externalConnectionToInitialize.AdditionalData;

                    object nextPageLink;
                    externalConnectionToInitialize.AdditionalData.TryGetValue("items@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        externalConnectionToInitialize.Items.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (externalConnectionToInitialize.Operations != null && externalConnectionToInitialize.Operations.CurrentPage != null)
                {
                    externalConnectionToInitialize.Operations.AdditionalData = externalConnectionToInitialize.AdditionalData;

                    object nextPageLink;
                    externalConnectionToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        externalConnectionToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (externalConnectionToInitialize.Groups != null && externalConnectionToInitialize.Groups.CurrentPage != null)
                {
                    externalConnectionToInitialize.Groups.AdditionalData = externalConnectionToInitialize.AdditionalData;

                    object nextPageLink;
                    externalConnectionToInitialize.AdditionalData.TryGetValue("groups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        externalConnectionToInitialize.Groups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
