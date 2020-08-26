// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISiteRequestBuilder.
    /// </summary>
    public partial interface ISiteRequestBuilder : IBaseItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISiteRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISiteRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        IItemAnalyticsWithReferenceRequestBuilder Analytics { get; }

        /// <summary>
        /// Gets the request builder for Columns.
        /// </summary>
        /// <returns>The <see cref="ISiteColumnsCollectionRequestBuilder"/>.</returns>
        ISiteColumnsCollectionRequestBuilder Columns { get; }

        /// <summary>
        /// Gets the request builder for ContentTypes.
        /// </summary>
        /// <returns>The <see cref="ISiteContentTypesCollectionRequestBuilder"/>.</returns>
        ISiteContentTypesCollectionRequestBuilder ContentTypes { get; }

        /// <summary>
        /// Gets the request builder for Drive.
        /// </summary>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder Drive { get; }

        /// <summary>
        /// Gets the request builder for Drives.
        /// </summary>
        /// <returns>The <see cref="ISiteDrivesCollectionRequestBuilder"/>.</returns>
        ISiteDrivesCollectionRequestBuilder Drives { get; }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="ISiteItemsCollectionRequestBuilder"/>.</returns>
        ISiteItemsCollectionRequestBuilder Items { get; }

        /// <summary>
        /// Gets the request builder for Lists.
        /// </summary>
        /// <returns>The <see cref="ISiteListsCollectionRequestBuilder"/>.</returns>
        ISiteListsCollectionRequestBuilder Lists { get; }

        /// <summary>
        /// Gets the request builder for Pages.
        /// </summary>
        /// <returns>The <see cref="ISitePagesCollectionRequestBuilder"/>.</returns>
        ISitePagesCollectionRequestBuilder Pages { get; }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="ISiteSitesCollectionRequestBuilder"/>.</returns>
        ISiteSitesCollectionRequestBuilder Sites { get; }

        /// <summary>
        /// Gets the request builder for Onenote.
        /// </summary>
        /// <returns>The <see cref="IOnenoteRequestBuilder"/>.</returns>
        IOnenoteRequestBuilder Onenote { get; }
    
        /// <summary>
        /// Gets the request builder for SiteGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="ISiteGetActivitiesByIntervalRequestBuilder"/>.</returns>
        ISiteGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime = null,
            string endDateTime = null,
            string interval = null);

        /// <summary>
        /// Gets the request builder for SiteGetByPath.
        /// </summary>
        /// <returns>The <see cref="ISiteGetByPathRequestBuilder"/>.</returns>
        ISiteGetByPathRequestBuilder GetByPath(
            string path = null);
    
    }
}