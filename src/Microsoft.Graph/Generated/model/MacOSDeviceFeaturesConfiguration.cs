// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mac OSDevice Features Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase
    {
    
		///<summary>
		/// The MacOSDeviceFeaturesConfiguration constructor
		///</summary>
        public MacOSDeviceFeaturesConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSDeviceFeaturesConfiguration";
        }
	
        /// <summary>
        /// Gets or sets auto launch items.
        /// List of applications, files, folders, and other items to launch when the user logs in. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autoLaunchItems", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MacOSLaunchItem> AutoLaunchItems { get; set; }
    
        /// <summary>
        /// Gets or sets admin show host info.
        /// Whether to show admin host information on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adminShowHostInfo", Required = Newtonsoft.Json.Required.Default)]
        public bool? AdminShowHostInfo { get; set; }
    
        /// <summary>
        /// Gets or sets login window text.
        /// Custom text to be displayed on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "loginWindowText", Required = Newtonsoft.Json.Required.Default)]
        public string LoginWindowText { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list hidden.
        /// Whether to show the name and password dialog or a list of users on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListHidden { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list hide local users.
        /// Whether to show only network and system users in the authorized users list on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListHideLocalUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListHideLocalUsers { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list hide mobile accounts.
        /// Whether to hide mobile users in the authorized users list on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListHideMobileAccounts", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListHideMobileAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list include network users.
        /// Whether to show network users in the authorized users list on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListIncludeNetworkUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListIncludeNetworkUsers { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list hide admin users.
        /// Whether to hide admin users in the authorized users list on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListHideAdminUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListHideAdminUsers { get; set; }
    
        /// <summary>
        /// Gets or sets authorized users list show other managed users.
        /// Whether to show other users in the authorized users list on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedUsersListShowOtherManagedUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedUsersListShowOtherManagedUsers { get; set; }
    
        /// <summary>
        /// Gets or sets shut down disabled.
        /// Whether to hide the Shut Down button item on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shutDownDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShutDownDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets restart disabled.
        /// Whether to hide the Restart button item on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restartDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RestartDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets sleep disabled.
        /// Whether to hide the Sleep menu item on the login window.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sleepDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SleepDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets console access disabled.
        /// Whether the Other user will disregard use of the `&amp;gt;console&amp;gt; special user name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consoleAccessDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConsoleAccessDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets shut down disabled while logged in.
        /// Whether the Shut Down menu item on the login window will be disabled while the user is logged in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shutDownDisabledWhileLoggedIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShutDownDisabledWhileLoggedIn { get; set; }
    
        /// <summary>
        /// Gets or sets restart disabled while logged in.
        /// Whether the Restart menu item on the login window will be disabled while the user is logged in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restartDisabledWhileLoggedIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? RestartDisabledWhileLoggedIn { get; set; }
    
        /// <summary>
        /// Gets or sets power off disabled while logged in.
        /// Whether the Power Off menu item on the login window will be disabled while the user is logged in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "powerOffDisabledWhileLoggedIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? PowerOffDisabledWhileLoggedIn { get; set; }
    
        /// <summary>
        /// Gets or sets log out disabled while logged in.
        /// Whether the Log Out menu item on the login window will be disabled while the user is logged in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logOutDisabledWhileLoggedIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? LogOutDisabledWhileLoggedIn { get; set; }
    
        /// <summary>
        /// Gets or sets screen lock disable immediate.
        /// Whether to disable the immediate screen lock functions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenLockDisableImmediate", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenLockDisableImmediate { get; set; }
    
        /// <summary>
        /// Gets or sets associated domains.
        /// Gets or sets a list that maps apps to their associated domains. The key should match the app's ID, and the value should be a string in the form of "service:domain" where domain is a fully qualified hostname (e.g. webcredentials:example.com). This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "associatedDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> AssociatedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on extension.
        /// Gets or sets a single sign-on extension profile. Deprecated: use MacOSSingleSignOnExtension instead.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleSignOnExtension", Required = Newtonsoft.Json.Required.Default)]
        public SingleSignOnExtension SingleSignOnExtension { get; set; }
    
        /// <summary>
        /// Gets or sets mac ossingle sign on extension.
        /// Gets or sets a single sign-on extension profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macOSSingleSignOnExtension", Required = Newtonsoft.Json.Required.Default)]
        public MacOSSingleSignOnExtension MacOSSingleSignOnExtension { get; set; }
    
        /// <summary>
        /// Gets or sets content caching enabled.
        /// Enables content caching and prevents it from being disabled by the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets content caching type.
        /// Determines what type of content is allowed to be cached by Apple's content caching service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingType", Required = Newtonsoft.Json.Required.Default)]
        public MacOSContentCachingType? ContentCachingType { get; set; }
    
        /// <summary>
        /// Gets or sets content caching max size bytes.
        /// The maximum number of bytes of disk space that will be used for the content cache. A value of 0 (default) indicates unlimited disk space. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingMaxSizeBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ContentCachingMaxSizeBytes { get; set; }
    
        /// <summary>
        /// Gets or sets content caching data path.
        /// The path to the directory used to store cached content. The value must be (or end with) /Library/Application Support/Apple/AssetCache/Data
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingDataPath", Required = Newtonsoft.Json.Required.Default)]
        public string ContentCachingDataPath { get; set; }
    
        /// <summary>
        /// Gets or sets content caching disable connection sharing.
        /// Disables internet connection sharing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingDisableConnectionSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingDisableConnectionSharing { get; set; }
    
        /// <summary>
        /// Gets or sets content caching force connection sharing.
        /// Forces internet connection sharing. contentCachingDisableConnectionSharing overrides this setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingForceConnectionSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingForceConnectionSharing { get; set; }
    
        /// <summary>
        /// Gets or sets content caching client policy.
        /// Determines the method in which content caching servers will listen for clients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingClientPolicy", Required = Newtonsoft.Json.Required.Default)]
        public MacOSContentCachingClientPolicy? ContentCachingClientPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets content caching client listen ranges.
        /// A list of custom IP ranges content caches will use to listen for clients. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingClientListenRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IpRange> ContentCachingClientListenRanges { get; set; }
    
        /// <summary>
        /// Gets or sets content caching peer policy.
        /// Determines the method in which content caches peer with other caches.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingPeerPolicy", Required = Newtonsoft.Json.Required.Default)]
        public MacOSContentCachingPeerPolicy? ContentCachingPeerPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets content caching peer listen ranges.
        /// A list of custom IP ranges content caches will use to listen for peer caches. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingPeerListenRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IpRange> ContentCachingPeerListenRanges { get; set; }
    
        /// <summary>
        /// Gets or sets content caching peer filter ranges.
        /// A list of custom IP ranges content caches will use to query for content from peers caches. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingPeerFilterRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IpRange> ContentCachingPeerFilterRanges { get; set; }
    
        /// <summary>
        /// Gets or sets content caching parent selection policy.
        /// Determines the method in which content caching servers will select parents if multiple are present.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingParentSelectionPolicy", Required = Newtonsoft.Json.Required.Default)]
        public MacOSContentCachingParentSelectionPolicy? ContentCachingParentSelectionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets content caching parents.
        /// A list of IP addresses representing parent content caches.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingParents", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ContentCachingParents { get; set; }
    
        /// <summary>
        /// Gets or sets content caching log client identities.
        /// Enables logging of IP addresses and ports of clients that request cached content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingLogClientIdentities", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingLogClientIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets content caching public ranges.
        /// A list of custom IP ranges that Apple's content caching service should use to match clients to content caches. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingPublicRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IpRange> ContentCachingPublicRanges { get; set; }
    
        /// <summary>
        /// Gets or sets content caching block deletion.
        /// Prevents content caches from purging content to free up disk space for other apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingBlockDeletion", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingBlockDeletion { get; set; }
    
        /// <summary>
        /// Gets or sets content caching show alerts.
        /// Display content caching alerts as system notifications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingShowAlerts", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingShowAlerts { get; set; }
    
        /// <summary>
        /// Gets or sets content caching keep awake.
        /// Prevent the device from sleeping if content caching is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingKeepAwake", Required = Newtonsoft.Json.Required.Default)]
        public bool? ContentCachingKeepAwake { get; set; }
    
        /// <summary>
        /// Gets or sets content caching port.
        /// Sets the port used for content caching. If the value is 0, a random available port will be selected. Valid values 0 to 65535
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentCachingPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ContentCachingPort { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on extension pkinit certificate.
        /// PKINIT Certificate for the authentication with single sign-on extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleSignOnExtensionPkinitCertificate", Required = Newtonsoft.Json.Required.Default)]
        public MacOSCertificateProfileBase SingleSignOnExtensionPkinitCertificate { get; set; }
    
    }
}
