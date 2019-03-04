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
    /// The type Managed Device Mobile App Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceMobileAppConfiguration : Entity
    {
    
		///<summary>
		/// The internal ManagedDeviceMobileAppConfiguration constructor
		///</summary>
        protected internal ManagedDeviceMobileAppConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets targeted mobile apps.
        /// the associated app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedMobileApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TargetedMobileApps { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this App configuration entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Admin provided description of the Device Configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided name of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignemenets for app configration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceMobileAppConfigurationAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// List of ManagedDeviceMobileAppConfigurationDeviceStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceMobileAppConfigurationDeviceStatusesCollectionPage DeviceStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets user statuses.
        /// List of ManagedDeviceMobileAppConfigurationUserStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceMobileAppConfigurationUserStatusesCollectionPage UserStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets device status summary.
        /// App configuration device status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceMobileAppConfigurationDeviceSummary DeviceStatusSummary { get; set; }
    
        /// <summary>
        /// Gets or sets user status summary.
        /// App configuration user status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceMobileAppConfigurationUserSummary UserStatusSummary { get; set; }
    
    }
}

