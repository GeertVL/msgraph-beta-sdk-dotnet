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
    /// The type MdmWindowsInformationProtectionPolicyPolicySetItemRequest.
    /// </summary>
    public partial class MdmWindowsInformationProtectionPolicyPolicySetItemRequest : BaseRequest, IMdmWindowsInformationProtectionPolicyPolicySetItemRequest
    {
        /// <summary>
        /// Constructs a new MdmWindowsInformationProtectionPolicyPolicySetItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MdmWindowsInformationProtectionPolicyPolicySetItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicyPolicySetItem using POST.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyPolicySetItemToCreate">The MdmWindowsInformationProtectionPolicyPolicySetItem to create.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> CreateAsync(MdmWindowsInformationProtectionPolicyPolicySetItem mdmWindowsInformationProtectionPolicyPolicySetItemToCreate)
        {
            return this.CreateAsync(mdmWindowsInformationProtectionPolicyPolicySetItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicyPolicySetItem using POST.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyPolicySetItemToCreate">The MdmWindowsInformationProtectionPolicyPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> CreateAsync(MdmWindowsInformationProtectionPolicyPolicySetItem mdmWindowsInformationProtectionPolicyPolicySetItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicyPolicySetItem>(mdmWindowsInformationProtectionPolicyPolicySetItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicyPolicySetItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicyPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MdmWindowsInformationProtectionPolicyPolicySetItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicyPolicySetItem.
        /// </summary>
        /// <returns>The MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicyPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicyPolicySetItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicyPolicySetItem using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate">The MdmWindowsInformationProtectionPolicyPolicySetItem to update.</param>
        /// <returns>The updated MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> UpdateAsync(MdmWindowsInformationProtectionPolicyPolicySetItem mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate)
        {
            return this.UpdateAsync(mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicyPolicySetItem using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate">The MdmWindowsInformationProtectionPolicyPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MdmWindowsInformationProtectionPolicyPolicySetItem.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicyPolicySetItem> UpdateAsync(MdmWindowsInformationProtectionPolicyPolicySetItem mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate, CancellationToken cancellationToken)
        {
			if (mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData != null)
			{
				if (mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.GetType().Name)
						});
				}
			}
            if (mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData != null)
            {
                if (mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicyPolicySetItem>(mdmWindowsInformationProtectionPolicyPolicySetItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyPolicySetItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyPolicySetItemRequest Expand(Expression<Func<MdmWindowsInformationProtectionPolicyPolicySetItem, object>> expandExpression)
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
        public IMdmWindowsInformationProtectionPolicyPolicySetItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyPolicySetItemRequest Select(Expression<Func<MdmWindowsInformationProtectionPolicyPolicySetItem, object>> selectExpression)
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
        /// <param name="mdmWindowsInformationProtectionPolicyPolicySetItemToInitialize">The <see cref="MdmWindowsInformationProtectionPolicyPolicySetItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MdmWindowsInformationProtectionPolicyPolicySetItem mdmWindowsInformationProtectionPolicyPolicySetItemToInitialize)
        {

        }
    }
}
