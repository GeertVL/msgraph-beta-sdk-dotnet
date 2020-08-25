// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetSharePointActivityPagesRequest.
    /// </summary>
    public partial interface IReportRootGetSharePointActivityPagesRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> GetAsync();
        
        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> GetAsync(
            CancellationToken cancellationToken);
  


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="sharepointactivitypages">The SharePointActivityPages object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> PatchAsync(SharePointActivityPages sharepointactivitypages);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="sharepointactivitypages">The SharePointActivityPages object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> PatchAsync(SharePointActivityPages sharepointactivitypages, 
            CancellationToken cancellationToken);
          

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="sharepointactivitypages">The SharePointActivityPages object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> PutAsync(SharePointActivityPages sharepointactivitypages);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="sharepointactivitypages">The SharePointActivityPages object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetSharePointActivityPagesCollectionPage> PutAsync(SharePointActivityPages sharepointactivitypages, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetSharePointActivityPagesRequest OrderBy(string value);
    }
}
