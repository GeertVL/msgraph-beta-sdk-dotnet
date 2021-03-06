// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementConfigurationSimpleSettingCollectionInstance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementConfigurationSimpleSettingCollectionInstance : DeviceManagementConfigurationSettingInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationSimpleSettingCollectionInstance"/> class.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingCollectionInstance()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstance";
        }

        /// <summary>
        /// Gets or sets simpleSettingCollectionValue.
        /// Simple setting collection instance value
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "simpleSettingCollectionValue", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementConfigurationSimpleSettingValue> SimpleSettingCollectionValue { get; set; }
    
    }
}
