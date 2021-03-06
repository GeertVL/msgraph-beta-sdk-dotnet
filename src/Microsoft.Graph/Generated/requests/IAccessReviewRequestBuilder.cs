// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAccessReviewRequestBuilder.
    /// </summary>
    public partial interface IAccessReviewRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessReviewRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessReviewRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Decisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewDecisionsCollectionRequestBuilder"/>.</returns>
        IAccessReviewDecisionsCollectionRequestBuilder Decisions { get; }

        /// <summary>
        /// Gets the request builder for Instances.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstancesCollectionRequestBuilder"/>.</returns>
        IAccessReviewInstancesCollectionRequestBuilder Instances { get; }

        /// <summary>
        /// Gets the request builder for MyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewMyDecisionsCollectionRequestBuilder"/>.</returns>
        IAccessReviewMyDecisionsCollectionRequestBuilder MyDecisions { get; }

        /// <summary>
        /// Gets the request builder for Reviewers.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewReviewersCollectionRequestBuilder"/>.</returns>
        IAccessReviewReviewersCollectionRequestBuilder Reviewers { get; }
    
        /// <summary>
        /// Gets the request builder for AccessReviewStop.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewStopRequestBuilder"/>.</returns>
        IAccessReviewStopRequestBuilder Stop();

        /// <summary>
        /// Gets the request builder for AccessReviewApplyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewApplyDecisionsRequestBuilder"/>.</returns>
        IAccessReviewApplyDecisionsRequestBuilder ApplyDecisions();

        /// <summary>
        /// Gets the request builder for AccessReviewResetDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewResetDecisionsRequestBuilder"/>.</returns>
        IAccessReviewResetDecisionsRequestBuilder ResetDecisions();

        /// <summary>
        /// Gets the request builder for AccessReviewSendReminder.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewSendReminderRequestBuilder"/>.</returns>
        IAccessReviewSendReminderRequestBuilder SendReminder();
    
    }
}
