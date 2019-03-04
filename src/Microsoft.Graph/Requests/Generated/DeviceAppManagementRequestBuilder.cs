// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceAppManagementRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementRequestBuilder : EntityRequestBuilder, IDeviceAppManagementRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceAppManagementRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceAppManagementRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceAppManagementRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WindowsManagementApp.
        /// </summary>
        /// <returns>The <see cref="IWindowsManagementAppWithReferenceRequestBuilder"/>.</returns>
        public IWindowsManagementAppWithReferenceRequestBuilder WindowsManagementApp
        {
            get
            {
                return new WindowsManagementAppWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("windowsManagementApp"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MobileApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementMobileAppsCollectionRequestBuilder MobileApps
        {
            get
            {
                return new DeviceAppManagementMobileAppsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mobileApps"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MobileAppCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder MobileAppCategories
        {
            get
            {
                return new DeviceAppManagementMobileAppCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mobileAppCategories"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EnterpriseCodeSigningCertificates.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionRequestBuilder EnterpriseCodeSigningCertificates
        {
            get
            {
                return new DeviceAppManagementEnterpriseCodeSigningCertificatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("enterpriseCodeSigningCertificates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IosLobAppProvisioningConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionRequestBuilder IosLobAppProvisioningConfigurations
        {
            get
            {
                return new DeviceAppManagementIosLobAppProvisioningConfigurationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("iosLobAppProvisioningConfigurations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SymantecCodeSigningCertificate.
        /// </summary>
        /// <returns>The <see cref="ISymantecCodeSigningCertificateRequestBuilder"/>.</returns>
        public ISymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate
        {
            get
            {
                return new SymantecCodeSigningCertificateRequestBuilder(this.AppendSegmentToRequestUrl("symantecCodeSigningCertificate"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MobileAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder MobileAppConfigurations
        {
            get
            {
                return new DeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mobileAppConfigurations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SideLoadingKeys.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementSideLoadingKeysCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementSideLoadingKeysCollectionRequestBuilder SideLoadingKeys
        {
            get
            {
                return new DeviceAppManagementSideLoadingKeysCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sideLoadingKeys"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for VppTokens.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementVppTokensCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementVppTokensCollectionRequestBuilder VppTokens
        {
            get
            {
                return new DeviceAppManagementVppTokensCollectionRequestBuilder(this.AppendSegmentToRequestUrl("vppTokens"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder ManagedAppPolicies
        {
            get
            {
                return new DeviceAppManagementManagedAppPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedAppPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IosManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder IosManagedAppProtections
        {
            get
            {
                return new DeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("iosManagedAppProtections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AndroidManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder AndroidManagedAppProtections
        {
            get
            {
                return new DeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("androidManagedAppProtections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DefaultManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder DefaultManagedAppProtections
        {
            get
            {
                return new DeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("defaultManagedAppProtections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TargetedManagedAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder TargetedManagedAppConfigurations
        {
            get
            {
                return new DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("targetedManagedAppConfigurations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MdmWindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder MdmWindowsInformationProtectionPolicies
        {
            get
            {
                return new DeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mdmWindowsInformationProtectionPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder WindowsInformationProtectionPolicies
        {
            get
            {
                return new DeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("windowsInformationProtectionPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder ManagedAppRegistrations
        {
            get
            {
                return new DeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedAppRegistrations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedAppStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder ManagedAppStatuses
        {
            get
            {
                return new DeviceAppManagementManagedAppStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedAppStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionDeviceRegistrations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionRequestBuilder WindowsInformationProtectionDeviceRegistrations
        {
            get
            {
                return new DeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("windowsInformationProtectionDeviceRegistrations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionWipeActions.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder WindowsInformationProtectionWipeActions
        {
            get
            {
                return new DeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("windowsInformationProtectionWipeActions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedEBooks.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedEBooksCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementManagedEBooksCollectionRequestBuilder ManagedEBooks
        {
            get
            {
                return new DeviceAppManagementManagedEBooksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedEBooks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedEBookCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder"/>.</returns>
        public IDeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder ManagedEBookCategories
        {
            get
            {
                return new DeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedEBookCategories"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceAppManagementSyncMicrosoftStoreForBusinessApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder"/>.</returns>
        public IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps()
        {
            return new DeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.syncMicrosoftStoreForBusinessApps"),
                this.Client);
        }
    
    }
}
