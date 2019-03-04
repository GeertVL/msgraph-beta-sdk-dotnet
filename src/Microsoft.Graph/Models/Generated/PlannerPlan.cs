// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Planner Plan.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerPlan : Entity
    {
    
        /// <summary>
        /// Gets or sets created by.
        /// Read-only. The user who created the plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// ID of the Group that owns the plan. A valid group must exist before this field can be set. Once set, this can only be updated by the owner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Required. Title of the plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets contexts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contexts", Required = Newtonsoft.Json.Required.Default)]
        public PlannerPlanContextCollection Contexts { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Collection of tasks in the plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerPlanTasksCollectionPage Tasks { get; set; }
    
        /// <summary>
        /// Gets or sets buckets.
        /// Read-only. Nullable. Collection of buckets in the plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "buckets", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerPlanBucketsCollectionPage Buckets { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// Read-only. Nullable. Additional details about the plan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "details", Required = Newtonsoft.Json.Required.Default)]
        public PlannerPlanDetails Details { get; set; }
    
    }
}

