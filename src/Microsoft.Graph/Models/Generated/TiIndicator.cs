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
    /// The type Ti Indicator.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TiIndicator : Entity
    {
    
        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public TiAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets activity group names.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityGroupNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ActivityGroupNames { get; set; }
    
        /// <summary>
        /// Gets or sets additional information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additionalInformation", Required = Newtonsoft.Json.Required.Default)]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "confidence", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets diamond model.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diamondModel", Required = Newtonsoft.Json.Required.Default)]
        public DiamondModel? DiamondModel { get; set; }
    
        /// <summary>
        /// Gets or sets email encoding.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailEncoding", Required = Newtonsoft.Json.Required.Default)]
        public string EmailEncoding { get; set; }
    
        /// <summary>
        /// Gets or sets email language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string EmailLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets email recipient.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailRecipient", Required = Newtonsoft.Json.Required.Default)]
        public string EmailRecipient { get; set; }
    
        /// <summary>
        /// Gets or sets email sender address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSenderAddress", Required = Newtonsoft.Json.Required.Default)]
        public string EmailSenderAddress { get; set; }
    
        /// <summary>
        /// Gets or sets email sender name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSenderName", Required = Newtonsoft.Json.Required.Default)]
        public string EmailSenderName { get; set; }
    
        /// <summary>
        /// Gets or sets email source domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSourceDomain", Required = Newtonsoft.Json.Required.Default)]
        public string EmailSourceDomain { get; set; }
    
        /// <summary>
        /// Gets or sets email source ip address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSourceIpAddress", Required = Newtonsoft.Json.Required.Default)]
        public string EmailSourceIpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets email subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSubject", Required = Newtonsoft.Json.Required.Default)]
        public string EmailSubject { get; set; }
    
        /// <summary>
        /// Gets or sets email xmailer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailXMailer", Required = Newtonsoft.Json.Required.Default)]
        public string EmailXMailer { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets file compile date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileCompileDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FileCompileDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets file created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileCreatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? FileCreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets file hash type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileHashType", Required = Newtonsoft.Json.Required.Default)]
        public FileHashType? FileHashType { get; set; }
    
        /// <summary>
        /// Gets or sets file hash value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileHashValue", Required = Newtonsoft.Json.Required.Default)]
        public string FileHashValue { get; set; }
    
        /// <summary>
        /// Gets or sets file mutex name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileMutexName", Required = Newtonsoft.Json.Required.Default)]
        public string FileMutexName { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets file packer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filePacker", Required = Newtonsoft.Json.Required.Default)]
        public string FilePacker { get; set; }
    
        /// <summary>
        /// Gets or sets file path.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filePath", Required = Newtonsoft.Json.Required.Default)]
        public string FilePath { get; set; }
    
        /// <summary>
        /// Gets or sets file size.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileSize", Required = Newtonsoft.Json.Required.Default)]
        public Int64? FileSize { get; set; }
    
        /// <summary>
        /// Gets or sets file type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileType", Required = Newtonsoft.Json.Required.Default)]
        public string FileType { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostName", Required = Newtonsoft.Json.Required.Default)]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets ingested date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ingestedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? IngestedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isActive", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets kill chain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "killChain", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> KillChain { get; set; }
    
        /// <summary>
        /// Gets or sets known false positives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "knownFalsePositives", Required = Newtonsoft.Json.Required.Default)]
        public string KnownFalsePositives { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastReportedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets malware family names.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "malwareFamilyNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MalwareFamilyNames { get; set; }
    
        /// <summary>
        /// Gets or sets network cidr block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkCidrBlock", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network destination asn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkDestinationAsn", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkDestinationAsn { get; set; }
    
        /// <summary>
        /// Gets or sets network destination cidr block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkDestinationCidrBlock", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkDestinationCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network destination ipv4.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkDestinationIPv4", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkDestinationIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network destination ipv6.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkDestinationIPv6", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkDestinationIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network destination port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkDestinationPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkDestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets network ipv4.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkIPv4", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network ipv6.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkIPv6", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkPort { get; set; }
    
        /// <summary>
        /// Gets or sets network protocol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkProtocol", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets network source asn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkSourceAsn", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkSourceAsn { get; set; }
    
        /// <summary>
        /// Gets or sets network source cidr block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkSourceCidrBlock", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkSourceCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets network source ipv4.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkSourceIPv4", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkSourceIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets network source ipv6.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkSourceIPv6", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkSourceIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets network source port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkSourcePort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NetworkSourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets passive only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passiveOnly", Required = Newtonsoft.Json.Required.Default)]
        public bool? PassiveOnly { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "severity", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets target product.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetProduct", Required = Newtonsoft.Json.Required.Default)]
        public string TargetProduct { get; set; }
    
        /// <summary>
        /// Gets or sets threat type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threatType", Required = Newtonsoft.Json.Required.Default)]
        public string ThreatType { get; set; }
    
        /// <summary>
        /// Gets or sets tlp level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tlpLevel", Required = Newtonsoft.Json.Required.Default)]
        public TlpLevel? TlpLevel { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Newtonsoft.Json.Required.Default)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAgent", Required = Newtonsoft.Json.Required.Default)]
        public string UserAgent { get; set; }
    
    }
}

