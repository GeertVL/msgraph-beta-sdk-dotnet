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
    /// The type MacOsVppAppRequest.
    /// </summary>
    public partial class MacOsVppAppRequest : BaseRequest, IMacOsVppAppRequest
    {
        /// <summary>
        /// Constructs a new MacOsVppAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOsVppAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOsVppApp using POST.
        /// </summary>
        /// <param name="macOsVppAppToCreate">The MacOsVppApp to create.</param>
        /// <returns>The created MacOsVppApp.</returns>
        public System.Threading.Tasks.Task<MacOsVppApp> CreateAsync(MacOsVppApp macOsVppAppToCreate)
        {
            return this.CreateAsync(macOsVppAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOsVppApp using POST.
        /// </summary>
        /// <param name="macOsVppAppToCreate">The MacOsVppApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOsVppApp.</returns>
        public async System.Threading.Tasks.Task<MacOsVppApp> CreateAsync(MacOsVppApp macOsVppAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOsVppApp>(macOsVppAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MacOsVppApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOsVppApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOsVppApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOsVppApp.
        /// </summary>
        /// <returns>The MacOsVppApp.</returns>
        public System.Threading.Tasks.Task<MacOsVppApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOsVppApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOsVppApp.</returns>
        public async System.Threading.Tasks.Task<MacOsVppApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOsVppApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MacOsVppApp using PATCH.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp to update.</param>
        /// <returns>The updated MacOsVppApp.</returns>
        public System.Threading.Tasks.Task<MacOsVppApp> UpdateAsync(MacOsVppApp macOsVppAppToUpdate)
        {
            return this.UpdateAsync(macOsVppAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOsVppApp using PATCH.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MacOsVppApp.</returns>
        public async System.Threading.Tasks.Task<MacOsVppApp> UpdateAsync(MacOsVppApp macOsVppAppToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOsVppApp>(macOsVppAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOsVppAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOsVppAppRequest Expand(Expression<Func<MacOsVppApp, object>> expandExpression)
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
        public IMacOsVppAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOsVppAppRequest Select(Expression<Func<MacOsVppApp, object>> selectExpression)
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
        /// <param name="macOsVppAppToInitialize">The <see cref="MacOsVppApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOsVppApp macOsVppAppToInitialize)
        {

            if (macOsVppAppToInitialize != null && macOsVppAppToInitialize.AdditionalData != null)
            {

                if (macOsVppAppToInitialize.AssignedLicenses != null && macOsVppAppToInitialize.AssignedLicenses.CurrentPage != null)
                {
                    macOsVppAppToInitialize.AssignedLicenses.AdditionalData = macOsVppAppToInitialize.AdditionalData;

                    object nextPageLink;
                    macOsVppAppToInitialize.AdditionalData.TryGetValue("assignedLicenses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        macOsVppAppToInitialize.AssignedLicenses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
