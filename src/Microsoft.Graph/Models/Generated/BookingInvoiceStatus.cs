// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum BookingInvoiceStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum BookingInvoiceStatus
    {
    
        /// <summary>
        /// draft
        /// </summary>
        Draft = 0,
	
        /// <summary>
        /// reviewing
        /// </summary>
        Reviewing = 1,
	
        /// <summary>
        /// open
        /// </summary>
        Open = 2,
	
        /// <summary>
        /// canceled
        /// </summary>
        Canceled = 3,
	
        /// <summary>
        /// paid
        /// </summary>
        Paid = 4,
	
        /// <summary>
        /// corrective
        /// </summary>
        Corrective = 5,
	
    }
}
