// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

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
    /// The type EmbeddedSIMActivationCodePoolRequest.
    /// </summary>
    public partial class EmbeddedSIMActivationCodePoolRequest : BaseRequest, IEmbeddedSIMActivationCodePoolRequest
    {
        /// <summary>
        /// Constructs a new EmbeddedSIMActivationCodePoolRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmbeddedSIMActivationCodePoolRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EmbeddedSIMActivationCodePool using POST.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToCreate">The EmbeddedSIMActivationCodePool to create.</param>
        /// <returns>The created EmbeddedSIMActivationCodePool.</returns>
        public System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> CreateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToCreate)
        {
            return this.CreateAsync(embeddedSIMActivationCodePoolToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EmbeddedSIMActivationCodePool using POST.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToCreate">The EmbeddedSIMActivationCodePool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> CreateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EmbeddedSIMActivationCodePool>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <returns>The EmbeddedSIMActivationCodePool.</returns>
        public System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified EmbeddedSIMActivationCodePool using PATCH.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToUpdate">The EmbeddedSIMActivationCodePool to update.</param>
        /// <returns>The updated EmbeddedSIMActivationCodePool.</returns>
        public System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> UpdateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToUpdate)
        {
            return this.UpdateAsync(embeddedSIMActivationCodePoolToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EmbeddedSIMActivationCodePool using PATCH.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToUpdate">The EmbeddedSIMActivationCodePool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> UpdateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Expand(Expression<Func<EmbeddedSIMActivationCodePool, object>> expandExpression)
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
        public IEmbeddedSIMActivationCodePoolRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Select(Expression<Func<EmbeddedSIMActivationCodePool, object>> selectExpression)
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
        /// <param name="embeddedSIMActivationCodePoolToInitialize">The <see cref="EmbeddedSIMActivationCodePool"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToInitialize)
        {

            if (embeddedSIMActivationCodePoolToInitialize != null && embeddedSIMActivationCodePoolToInitialize.AdditionalData != null)
            {

                if (embeddedSIMActivationCodePoolToInitialize.Assignments != null && embeddedSIMActivationCodePoolToInitialize.Assignments.CurrentPage != null)
                {
                    embeddedSIMActivationCodePoolToInitialize.Assignments.AdditionalData = embeddedSIMActivationCodePoolToInitialize.AdditionalData;

                    object nextPageLink;
                    embeddedSIMActivationCodePoolToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        embeddedSIMActivationCodePoolToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (embeddedSIMActivationCodePoolToInitialize.DeviceStates != null && embeddedSIMActivationCodePoolToInitialize.DeviceStates.CurrentPage != null)
                {
                    embeddedSIMActivationCodePoolToInitialize.DeviceStates.AdditionalData = embeddedSIMActivationCodePoolToInitialize.AdditionalData;

                    object nextPageLink;
                    embeddedSIMActivationCodePoolToInitialize.AdditionalData.TryGetValue("deviceStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        embeddedSIMActivationCodePoolToInitialize.DeviceStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
