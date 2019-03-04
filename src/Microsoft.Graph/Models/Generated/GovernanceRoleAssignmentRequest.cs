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
    /// The type Governance Role Assignment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GovernanceRoleAssignmentRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets resource id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitionId", Required = Newtonsoft.Json.Required.Default)]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets subject id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectId", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectId { get; set; }
    
        /// <summary>
        /// Gets or sets linked eligible role assignment id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "linkedEligibleRoleAssignmentId", Required = Newtonsoft.Json.Required.Default)]
        public string LinkedEligibleRoleAssignmentId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets assignment state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentState", Required = Newtonsoft.Json.Required.Default)]
        public string AssignmentState { get; set; }
    
        /// <summary>
        /// Gets or sets requested date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RequestedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason", Required = Newtonsoft.Json.Required.Default)]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceRoleAssignmentRequestStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schedule", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceResource Resource { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinition", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceRoleDefinition RoleDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceSubject Subject { get; set; }
    
    }
}

