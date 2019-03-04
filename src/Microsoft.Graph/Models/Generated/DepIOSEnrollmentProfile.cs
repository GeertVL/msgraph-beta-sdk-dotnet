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
    /// The type Dep IOSEnrollment Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DepIOSEnrollmentProfile : DepEnrollmentBaseProfile
    {
    
        /// <summary>
        /// Gets or sets i tunes pairing mode.
        /// Indicates the iTunes pairing mode
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iTunesPairingMode", Required = Newtonsoft.Json.Required.Default)]
        public ITunesPairingMode? ITunesPairingMode { get; set; }
    
        /// <summary>
        /// Gets or sets management certificates.
        /// Management certificates for Apple Configurator
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementCertificates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ManagementCertificateWithThumbprint> ManagementCertificates { get; set; }
    
        /// <summary>
        /// Gets or sets restore from android disabled.
        /// Indicates if Restore from Android is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restoreFromAndroidDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RestoreFromAndroidDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets await device configured confirmation.
        /// Indicates if the device will need to wait for configured confirmation
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "awaitDeviceConfiguredConfirmation", Required = Newtonsoft.Json.Required.Default)]
        public bool? AwaitDeviceConfiguredConfirmation { get; set; }
    
        /// <summary>
        /// Gets or sets shared ipad maximum user count.
        /// This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedIPadMaximumUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SharedIPadMaximumUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets enable shared ipad.
        /// This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSharedIPad", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSharedIPad { get; set; }
    
        /// <summary>
        /// Gets or sets company portal vpp token id.
        /// If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. 'enableAuthenticationViaCompanyPortal' must be set in order for this property to be set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyPortalVppTokenId", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyPortalVppTokenId { get; set; }
    
        /// <summary>
        /// Gets or sets enable single app enrollment mode.
        /// Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. 'enableAuthenticationViaCompanyPortal' and 'companyPortalVppTokenId' must be set for this property to be set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSingleAppEnrollmentMode", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSingleAppEnrollmentMode { get; set; }
    
        /// <summary>
        /// Gets or sets home button screen disabled.
        /// Indicates if home button sensitivity screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeButtonScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? HomeButtonScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets i message and face time screen disabled.
        /// Indicates if iMessage and FaceTime screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iMessageAndFaceTimeScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IMessageAndFaceTimeScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets on boarding screen disabled.
        /// Indicates if onboarding setup screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onBoardingScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnBoardingScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets screen time screen disabled.
        /// Indicates if screen timeout setup is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenTimeScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenTimeScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets sim setup screen disabled.
        /// Indicates if the SIMSetup screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "simSetupScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SimSetupScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets software update screen disabled.
        /// Indicates if the mandatory sofware update screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdateScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SoftwareUpdateScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets watch migration screen disabled.
        /// Indicates if the watch migration screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "watchMigrationScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? WatchMigrationScreenDisabled { get; set; }
    
    }
}

