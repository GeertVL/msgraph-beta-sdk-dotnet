// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChannelChatThreadsCollectionRequestBuilder.
    /// </summary>
    public partial class ChannelChatThreadsCollectionRequestBuilder : BaseRequestBuilder, IChannelChatThreadsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChannelChatThreadsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChannelChatThreadsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChannelChatThreadsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChannelChatThreadsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChannelChatThreadsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IChatThreadRequestBuilder"/> for the specified ChannelChatThread.
        /// </summary>
        /// <param name="id">The ID for the ChannelChatThread.</param>
        /// <returns>The <see cref="IChatThreadRequestBuilder"/>.</returns>
        public IChatThreadRequestBuilder this[string id]
        {
            get
            {
                return new ChatThreadRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
