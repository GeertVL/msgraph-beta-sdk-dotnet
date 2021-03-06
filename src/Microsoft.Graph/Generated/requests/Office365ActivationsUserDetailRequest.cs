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
    /// The type Office365ActivationsUserDetailRequest.
    /// </summary>
    public partial class Office365ActivationsUserDetailRequest : BaseRequest, IOffice365ActivationsUserDetailRequest
    {
        /// <summary>
        /// Constructs a new Office365ActivationsUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Office365ActivationsUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserDetail using POST.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToCreate">The Office365ActivationsUserDetail to create.</param>
        /// <returns>The created Office365ActivationsUserDetail.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserDetail> CreateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToCreate)
        {
            return this.CreateAsync(office365ActivationsUserDetailToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Office365ActivationsUserDetail using POST.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToCreate">The Office365ActivationsUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365ActivationsUserDetail.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserDetail> CreateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Office365ActivationsUserDetail>(office365ActivationsUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Office365ActivationsUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <returns>The Office365ActivationsUserDetail.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserDetail> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365ActivationsUserDetail.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserDetail> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Office365ActivationsUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToUpdate">The Office365ActivationsUserDetail to update.</param>
        /// <returns>The updated Office365ActivationsUserDetail.</returns>
        public System.Threading.Tasks.Task<Office365ActivationsUserDetail> UpdateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToUpdate)
        {
            return this.UpdateAsync(office365ActivationsUserDetailToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Office365ActivationsUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToUpdate">The Office365ActivationsUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365ActivationsUserDetail.</returns>
        public async System.Threading.Tasks.Task<Office365ActivationsUserDetail> UpdateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToUpdate, CancellationToken cancellationToken)
        {
			if (office365ActivationsUserDetailToUpdate.AdditionalData != null)
			{
				if (office365ActivationsUserDetailToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					office365ActivationsUserDetailToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserDetailToUpdate.GetType().Name)
						});
				}
			}
            if (office365ActivationsUserDetailToUpdate.AdditionalData != null)
            {
                if (office365ActivationsUserDetailToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    office365ActivationsUserDetailToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, office365ActivationsUserDetailToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Office365ActivationsUserDetail>(office365ActivationsUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserDetailRequest Expand(Expression<Func<Office365ActivationsUserDetail, object>> expandExpression)
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
        public IOffice365ActivationsUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOffice365ActivationsUserDetailRequest Select(Expression<Func<Office365ActivationsUserDetail, object>> selectExpression)
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
        /// <param name="office365ActivationsUserDetailToInitialize">The <see cref="Office365ActivationsUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Office365ActivationsUserDetail office365ActivationsUserDetailToInitialize)
        {

        }
    }
}
