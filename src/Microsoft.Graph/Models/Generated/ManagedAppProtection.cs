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
    /// The type Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAppProtection : ManagedAppPolicy
    {
    
		///<summary>
		/// The internal ManagedAppProtection constructor
		///</summary>
        protected internal ManagedAppProtection()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets period offline before access check.
        /// The period after which access is checked when the device is not connected to the internet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "periodOfflineBeforeAccessCheck", Required = Newtonsoft.Json.Required.Default)]
        public Duration PeriodOfflineBeforeAccessCheck { get; set; }
    
        /// <summary>
        /// Gets or sets period online before access check.
        /// The period after which access is checked when the device is connected to the internet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "periodOnlineBeforeAccessCheck", Required = Newtonsoft.Json.Required.Default)]
        public Duration PeriodOnlineBeforeAccessCheck { get; set; }
    
        /// <summary>
        /// Gets or sets allowed inbound data transfer sources.
        /// Sources from which data is allowed to be transferred. Possible values are: allApps, managedApps, none.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedInboundDataTransferSources", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }
    
        /// <summary>
        /// Gets or sets allowed outbound data transfer destinations.
        /// Destinations to which data is allowed to be transferred. Possible values are: allApps, managedApps, none.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedOutboundDataTransferDestinations", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }
    
        /// <summary>
        /// Gets or sets organizational credentials required.
        /// Indicates whether organizational credentials are required for app use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizationalCredentialsRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? OrganizationalCredentialsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets allowed outbound clipboard sharing level.
        /// The level to which the clipboard may be shared between apps on the managed device. Possible values are: allApps, managedAppsWithPasteIn, managedApps, blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedOutboundClipboardSharingLevel", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }
    
        /// <summary>
        /// Gets or sets data backup blocked.
        /// Indicates whether the backup of a managed app's data is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataBackupBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? DataBackupBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance required.
        /// Indicates whether device compliance is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceComplianceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceComplianceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets managed browser to open links required.
        /// Indicates whether internet links should be opened in the managed browser app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedBrowserToOpenLinksRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }
    
        /// <summary>
        /// Gets or sets save as blocked.
        /// Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "saveAsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? SaveAsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets period offline before wipe is enforced.
        /// The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "periodOfflineBeforeWipeIsEnforced", Required = Newtonsoft.Json.Required.Default)]
        public Duration PeriodOfflineBeforeWipeIsEnforced { get; set; }
    
        /// <summary>
        /// Gets or sets pin required.
        /// Indicates whether an app-level pin is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PinRequired { get; set; }
    
        /// <summary>
        /// Gets or sets maximum pin retries.
        /// Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumPinRetries", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumPinRetries { get; set; }
    
        /// <summary>
        /// Gets or sets simple pin blocked.
        /// Indicates whether simplePin is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "simplePinBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? SimplePinBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets minimum pin length.
        /// Minimum pin length required for an app-level pin if PinRequired is set to True
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumPinLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinimumPinLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin character set.
        /// Character set which may be used for an app-level pin if PinRequired is set to True. Possible values are: numeric, alphanumericAndSymbol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinCharacterSet", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPinCharacterSet? PinCharacterSet { get; set; }
    
        /// <summary>
        /// Gets or sets period before pin reset.
        /// TimePeriod before the all-level pin must be reset if PinRequired is set to True.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "periodBeforePinReset", Required = Newtonsoft.Json.Required.Default)]
        public Duration PeriodBeforePinReset { get; set; }
    
        /// <summary>
        /// Gets or sets allowed data storage locations.
        /// Data storage locations where a user may store managed data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedDataStorageLocations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ManagedAppDataStorageLocation> AllowedDataStorageLocations { get; set; }
    
        /// <summary>
        /// Gets or sets contact sync blocked.
        /// Indicates whether contacts can be synced to the user's device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactSyncBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContactSyncBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets print blocked.
        /// Indicates whether printing is allowed from managed apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? PrintBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets fingerprint blocked.
        /// Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fingerprintBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FingerprintBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets disable app pin if device pin is set.
        /// Indicates whether use of the app pin is required if the device pin is set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableAppPinIfDevicePinIsSet", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required os version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredOsVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning os version.
        /// Versions less than the specified version will result in warning message on the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningOsVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required app version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredAppVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning app version.
        /// Versions less than the specified version will result in warning message on the managed app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningAppVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe os version.
        /// Versions less than or equal to the specified version will wipe the managed app and the associated company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeOsVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe app version.
        /// Versions less than or equal to the specified version will wipe the managed app and the associated company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeAppVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets app action if device compliance required.
        /// Defines a managed app behavior, either block or wipe, when the device is either rooted or jailbroken, if DeviceComplianceRequired is set to true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfDeviceComplianceRequired", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets app action if maximum pin retries exceeded.
        /// Defines a managed app behavior, either block or wipe, based on maximum number of incorrect pin retry attempts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfMaximumPinRetriesExceeded", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded { get; set; }
    
        /// <summary>
        /// Gets or sets pin required instead of biometric timeout.
        /// Timeout in minutes for an app pin instead of non biometrics passcode
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinRequiredInsteadOfBiometricTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Duration PinRequiredInsteadOfBiometricTimeout { get; set; }
    
    }
}

