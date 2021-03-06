// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UnifiedRbacResourceNamespaceRequest.
    /// </summary>
    public partial class UnifiedRbacResourceNamespaceRequest : BaseRequest, IUnifiedRbacResourceNamespaceRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRbacResourceNamespaceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRbacResourceNamespaceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedRbacResourceNamespace using POST.
        /// </summary>
        /// <param name="unifiedRbacResourceNamespaceToCreate">The UnifiedRbacResourceNamespace to create.</param>
        /// <returns>The created UnifiedRbacResourceNamespace.</returns>
        public System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> CreateAsync(UnifiedRbacResourceNamespace unifiedRbacResourceNamespaceToCreate)
        {
            return this.CreateAsync(unifiedRbacResourceNamespaceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnifiedRbacResourceNamespace using POST.
        /// </summary>
        /// <param name="unifiedRbacResourceNamespaceToCreate">The UnifiedRbacResourceNamespace to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRbacResourceNamespace.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> CreateAsync(UnifiedRbacResourceNamespace unifiedRbacResourceNamespaceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UnifiedRbacResourceNamespace>(unifiedRbacResourceNamespaceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceNamespace.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceNamespace.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UnifiedRbacResourceNamespace>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UnifiedRbacResourceNamespace.
        /// </summary>
        /// <returns>The UnifiedRbacResourceNamespace.</returns>
        public System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UnifiedRbacResourceNamespace.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRbacResourceNamespace.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UnifiedRbacResourceNamespace>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRbacResourceNamespace using PATCH.
        /// </summary>
        /// <param name="unifiedRbacResourceNamespaceToUpdate">The UnifiedRbacResourceNamespace to update.</param>
        /// <returns>The updated UnifiedRbacResourceNamespace.</returns>
        public System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> UpdateAsync(UnifiedRbacResourceNamespace unifiedRbacResourceNamespaceToUpdate)
        {
            return this.UpdateAsync(unifiedRbacResourceNamespaceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnifiedRbacResourceNamespace using PATCH.
        /// </summary>
        /// <param name="unifiedRbacResourceNamespaceToUpdate">The UnifiedRbacResourceNamespace to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRbacResourceNamespace.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceNamespace> UpdateAsync(UnifiedRbacResourceNamespace unifiedRbacResourceNamespaceToUpdate, CancellationToken cancellationToken)
        {
			if (unifiedRbacResourceNamespaceToUpdate.AdditionalData != null)
			{
				if (unifiedRbacResourceNamespaceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unifiedRbacResourceNamespaceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRbacResourceNamespaceToUpdate.GetType().Name)
						});
				}
			}
            if (unifiedRbacResourceNamespaceToUpdate.AdditionalData != null)
            {
                if (unifiedRbacResourceNamespaceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unifiedRbacResourceNamespaceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unifiedRbacResourceNamespaceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UnifiedRbacResourceNamespace>(unifiedRbacResourceNamespaceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceNamespaceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceNamespaceRequest Expand(Expression<Func<UnifiedRbacResourceNamespace, object>> expandExpression)
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
        public IUnifiedRbacResourceNamespaceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceNamespaceRequest Select(Expression<Func<UnifiedRbacResourceNamespace, object>> selectExpression)
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
        /// <param name="unifiedRbacResourceNamespaceToInitialize">The <see cref="UnifiedRbacResourceNamespace"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedRbacResourceNamespace unifiedRbacResourceNamespaceToInitialize)
        {

            if (unifiedRbacResourceNamespaceToInitialize != null && unifiedRbacResourceNamespaceToInitialize.AdditionalData != null)
            {

                if (unifiedRbacResourceNamespaceToInitialize.ResourceActions != null && unifiedRbacResourceNamespaceToInitialize.ResourceActions.CurrentPage != null)
                {
                    unifiedRbacResourceNamespaceToInitialize.ResourceActions.AdditionalData = unifiedRbacResourceNamespaceToInitialize.AdditionalData;

                    object nextPageLink;
                    unifiedRbacResourceNamespaceToInitialize.AdditionalData.TryGetValue("resourceActions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        unifiedRbacResourceNamespaceToInitialize.ResourceActions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
