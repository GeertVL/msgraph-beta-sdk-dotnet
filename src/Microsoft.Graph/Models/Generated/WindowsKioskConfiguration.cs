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
    /// The type Windows Kiosk Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsKioskConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets kiosk profiles.
        /// This policy setting allows to define a list of Kiosk profiles for a Kiosk configuration. This collection can contain a maximum of 3 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsKioskProfile> KioskProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser default url.
        /// Specify the default URL the browser should navigate to on launch.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserDefaultUrl", Required = Newtonsoft.Json.Required.Default)]
        public string KioskBrowserDefaultUrl { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable home button.
        /// Enable the kiosk browser's home button. By default, the home button is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserEnableHomeButton", Required = Newtonsoft.Json.Required.Default)]
        public bool? KioskBrowserEnableHomeButton { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable navigation buttons.
        /// Enable the kiosk browser's navigation buttons(forward/back). By default, the navigation buttons are disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserEnableNavigationButtons", Required = Newtonsoft.Json.Required.Default)]
        public bool? KioskBrowserEnableNavigationButtons { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser enable end session button.
        /// Enable the kiosk browser's end session button. By default, the end session button is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserEnableEndSessionButton", Required = Newtonsoft.Json.Required.Default)]
        public bool? KioskBrowserEnableEndSessionButton { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser restart on idle time in minutes.
        /// Specify the number of minutes the session is idle until the kiosk browser restarts in a fresh state.  Valid values are 1-1440. Valid values 1 to 1440
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserRestartOnIdleTimeInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? KioskBrowserRestartOnIdleTimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser blocked urls.
        /// Specify URLs that the kiosk browsers should not navigate to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserBlockedURLs", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> KioskBrowserBlockedURLs { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk browser blocked url exceptions.
        /// Specify URLs that the kiosk browser is allowed to navigate to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskBrowserBlockedUrlExceptions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> KioskBrowserBlockedUrlExceptions { get; set; }
    
        /// <summary>
        /// Gets or sets edge kiosk enable public browsing.
        /// Enable public browsing kiosk mode for the Microsoft Edge browser. The Default is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "edgeKioskEnablePublicBrowsing", Required = Newtonsoft.Json.Required.Default)]
        public bool? EdgeKioskEnablePublicBrowsing { get; set; }
    
        /// <summary>
        /// Gets or sets edge kiosk reset after idle time in minutes.
        /// Specifies the time in minutes from the last user activity before Microsoft Edge kiosk resets.  Valid values are 0-1440. The default is 5. 0 indicates no reset. Valid values 0 to 1440
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "edgeKioskResetAfterIdleTimeInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EdgeKioskResetAfterIdleTimeInMinutes { get; set; }
    
    }
}

