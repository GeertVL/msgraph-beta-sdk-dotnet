// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type IosCertificateProfileBaseWithReferenceRequest.
    /// </summary>
    public partial class IosCertificateProfileBaseWithReferenceRequest : BaseRequest, IIosCertificateProfileBaseWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new IosCertificateProfileBaseWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosCertificateProfileBaseWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified IosCertificateProfileBase.
        /// </summary>
        /// <returns>The IosCertificateProfileBase.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfileBase> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfileBase> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified IosCertificateProfileBase using POST.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToCreate">The IosCertificateProfileBase to create.</param>
        /// <returns>The created IosCertificateProfileBase.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfileBase> CreateAsync(IosCertificateProfileBase iosCertificateProfileBaseToCreate)
        {
            return this.CreateAsync(iosCertificateProfileBaseToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosCertificateProfileBase using POST.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToCreate">The IosCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfileBase> CreateAsync(IosCertificateProfileBase iosCertificateProfileBaseToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosCertificateProfileBase>(iosCertificateProfileBaseToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified IosCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToUpdate">The IosCertificateProfileBase to update.</param>
        /// <returns>The updated IosCertificateProfileBase.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfileBase> UpdateAsync(IosCertificateProfileBase iosCertificateProfileBaseToUpdate)
        {
            return this.UpdateAsync(iosCertificateProfileBaseToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToUpdate">The IosCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfileBase> UpdateAsync(IosCertificateProfileBase iosCertificateProfileBaseToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosCertificateProfileBase>(iosCertificateProfileBaseToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified IosCertificateProfileBase.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileBaseWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileBaseWithReferenceRequest Expand(Expression<Func<IosCertificateProfileBase, object>> expandExpression)
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
        public IIosCertificateProfileBaseWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileBaseWithReferenceRequest Select(Expression<Func<IosCertificateProfileBase, object>> selectExpression)
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

    }
}
