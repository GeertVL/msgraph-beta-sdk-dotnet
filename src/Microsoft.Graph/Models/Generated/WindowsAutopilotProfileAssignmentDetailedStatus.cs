// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsAutopilotProfileAssignmentDetailedStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsAutopilotProfileAssignmentDetailedStatus
    {
    
        /// <summary>
        /// none
        /// </summary>
        None = 0,
	
        /// <summary>
        /// hardware Requirements Not Met
        /// </summary>
        HardwareRequirementsNotMet = 1,
	
    }
}
