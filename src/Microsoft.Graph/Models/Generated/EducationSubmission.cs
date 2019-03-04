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
    /// The type Education Submission.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationSubmission : Entity
    {
    
        /// <summary>
        /// Gets or sets recipient.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient", Required = Newtonsoft.Json.Required.Default)]
        public EducationSubmissionRecipient Recipient { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public EducationSubmissionStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets submitted by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet SubmittedBy { get; set; }
    
        /// <summary>
        /// Gets or sets submitted date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SubmittedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets unsubmitted by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unsubmittedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet UnsubmittedBy { get; set; }
    
        /// <summary>
        /// Gets or sets unsubmitted date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unsubmittedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? UnsubmittedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets released by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "releasedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet ReleasedBy { get; set; }
    
        /// <summary>
        /// Gets or sets released date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "releasedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReleasedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets returned by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "returnedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet ReturnedBy { get; set; }
    
        /// <summary>
        /// Gets or sets returned date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "returnedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReturnedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets grade.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grade", Required = Newtonsoft.Json.Required.Default)]
        public EducationAssignmentGrade Grade { get; set; }
    
        /// <summary>
        /// Gets or sets feedback.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedback", Required = Newtonsoft.Json.Required.Default)]
        public EducationFeedback Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets resources folder url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourcesFolderUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ResourcesFolderUrl { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resources", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSubmissionResourcesCollectionPage Resources { get; set; }
    
        /// <summary>
        /// Gets or sets submitted resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedResources", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSubmissionSubmittedResourcesCollectionPage SubmittedResources { get; set; }
    
    }
}

