// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserTeamworkSendActivityNotificationRequestBuilder.
    /// </summary>
    public partial class UserTeamworkSendActivityNotificationRequestBuilder : BaseActionMethodRequestBuilder<IUserTeamworkSendActivityNotificationRequest>, IUserTeamworkSendActivityNotificationRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UserTeamworkSendActivityNotificationRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="topic">A topic parameter for the OData method call.</param>
        /// <param name="activityType">A activityType parameter for the OData method call.</param>
        /// <param name="chainId">A chainId parameter for the OData method call.</param>
        /// <param name="previewText">A previewText parameter for the OData method call.</param>
        /// <param name="templateParameters">A templateParameters parameter for the OData method call.</param>
        public UserTeamworkSendActivityNotificationRequestBuilder(
            string requestUrl,
            IBaseClient client,
            TeamworkActivityTopic topic,
            string activityType,
            Int64? chainId,
            ItemBody previewText,
            IEnumerable<KeyValuePair> templateParameters)
            : base(requestUrl, client)
        {
            this.SetParameter("topic", topic, true);
            this.SetParameter("activityType", activityType, true);
            this.SetParameter("chainId", chainId, true);
            this.SetParameter("previewText", previewText, true);
            this.SetParameter("templateParameters", templateParameters, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUserTeamworkSendActivityNotificationRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new UserTeamworkSendActivityNotificationRequest(functionUrl, this.Client, options);

            if (this.HasParameter("topic"))
            {
                request.RequestBody.Topic = this.GetParameter<TeamworkActivityTopic>("topic");
            }

            if (this.HasParameter("activityType"))
            {
                request.RequestBody.ActivityType = this.GetParameter<string>("activityType");
            }

            if (this.HasParameter("chainId"))
            {
                request.RequestBody.ChainId = this.GetParameter<Int64?>("chainId");
            }

            if (this.HasParameter("previewText"))
            {
                request.RequestBody.PreviewText = this.GetParameter<ItemBody>("previewText");
            }

            if (this.HasParameter("templateParameters"))
            {
                request.RequestBody.TemplateParameters = this.GetParameter<IEnumerable<KeyValuePair>>("templateParameters");
            }

            return request;
        }
    }
}