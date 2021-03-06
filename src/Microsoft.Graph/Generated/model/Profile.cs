// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Profile : Entity
    {
    
		///<summary>
		/// The Profile constructor
		///</summary>
        public Profile()
        {
            this.ODataType = "microsoft.graph.profile";
        }
	
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account", Required = Newtonsoft.Json.Required.Default)]
        public IProfileAccountCollectionPage Account { get; set; }
    
        /// <summary>
        /// Gets or sets addresses.
        /// Represents details of addresses associated with the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addresses", Required = Newtonsoft.Json.Required.Default)]
        public IProfileAddressesCollectionPage Addresses { get; set; }
    
        /// <summary>
        /// Gets or sets anniversaries.
        /// Represents the details of meaningful dates associated with a person.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "anniversaries", Required = Newtonsoft.Json.Required.Default)]
        public IProfileAnniversariesCollectionPage Anniversaries { get; set; }
    
        /// <summary>
        /// Gets or sets awards.
        /// Represents the details of awards or honors associated with a person.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "awards", Required = Newtonsoft.Json.Required.Default)]
        public IProfileAwardsCollectionPage Awards { get; set; }
    
        /// <summary>
        /// Gets or sets certifications.
        /// Represents the details of certifications associated with a person.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certifications", Required = Newtonsoft.Json.Required.Default)]
        public IProfileCertificationsCollectionPage Certifications { get; set; }
    
        /// <summary>
        /// Gets or sets educational activities.
        /// Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "educationalActivities", Required = Newtonsoft.Json.Required.Default)]
        public IProfileEducationalActivitiesCollectionPage EducationalActivities { get; set; }
    
        /// <summary>
        /// Gets or sets emails.
        /// Represents detailed information about email addresses associated with the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emails", Required = Newtonsoft.Json.Required.Default)]
        public IProfileEmailsCollectionPage Emails { get; set; }
    
        /// <summary>
        /// Gets or sets interests.
        /// Provides detailed information about interests the user has associated with themselves in various services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interests", Required = Newtonsoft.Json.Required.Default)]
        public IProfileInterestsCollectionPage Interests { get; set; }
    
        /// <summary>
        /// Gets or sets languages.
        /// Represents detailed information about languages that a user has added to their profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "languages", Required = Newtonsoft.Json.Required.Default)]
        public IProfileLanguagesCollectionPage Languages { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// Represents the names a user has added to their profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "names", Required = Newtonsoft.Json.Required.Default)]
        public IProfileNamesCollectionPage Names { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Represents notes that a user has added to their profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notes", Required = Newtonsoft.Json.Required.Default)]
        public IProfileNotesCollectionPage Notes { get; set; }
    
        /// <summary>
        /// Gets or sets patents.
        /// Represents patents that a user has added to their profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "patents", Required = Newtonsoft.Json.Required.Default)]
        public IProfilePatentsCollectionPage Patents { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// Represents detailed information about phone numbers associated with a user in various services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phones", Required = Newtonsoft.Json.Required.Default)]
        public IProfilePhonesCollectionPage Phones { get; set; }
    
        /// <summary>
        /// Gets or sets positions.
        /// Represents detailed information about work positions associated with a user's profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "positions", Required = Newtonsoft.Json.Required.Default)]
        public IProfilePositionsCollectionPage Positions { get; set; }
    
        /// <summary>
        /// Gets or sets projects.
        /// Represents detailed information about projects associated with a user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "projects", Required = Newtonsoft.Json.Required.Default)]
        public IProfileProjectsCollectionPage Projects { get; set; }
    
        /// <summary>
        /// Gets or sets publications.
        /// Represents details of any publications a user has added to their profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publications", Required = Newtonsoft.Json.Required.Default)]
        public IProfilePublicationsCollectionPage Publications { get; set; }
    
        /// <summary>
        /// Gets or sets skills.
        /// Represents detailed information about skills associated with a user in various services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skills", Required = Newtonsoft.Json.Required.Default)]
        public IProfileSkillsCollectionPage Skills { get; set; }
    
        /// <summary>
        /// Gets or sets web accounts.
        /// Represents web accounts the user has indicated they use or has added to their user profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webAccounts", Required = Newtonsoft.Json.Required.Default)]
        public IProfileWebAccountsCollectionPage WebAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets websites.
        /// Represents detailed information about websites associated with a user in various services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "websites", Required = Newtonsoft.Json.Required.Default)]
        public IProfileWebsitesCollectionPage Websites { get; set; }
    
    }
}

