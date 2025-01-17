// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary>
    /// Description of a NotificationHub WnsCredential.
    /// Serialized Name: WnsCredential
    /// </summary>
    public partial class NotificationHubWnsCredential
    {
        /// <summary> Initializes a new instance of NotificationHubWnsCredential. </summary>
        public NotificationHubWnsCredential()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubWnsCredential. </summary>
        /// <param name="packageSid">
        /// The package ID for this credential.
        /// Serialized Name: WnsCredential.properties.packageSid
        /// </param>
        /// <param name="secretKey">
        /// The secret key.
        /// Serialized Name: WnsCredential.properties.secretKey
        /// </param>
        /// <param name="windowsLiveEndpoint">
        /// The Windows Live endpoint.
        /// Serialized Name: WnsCredential.properties.windowsLiveEndpoint
        /// </param>
        internal NotificationHubWnsCredential(string packageSid, string secretKey, Uri windowsLiveEndpoint)
        {
            PackageSid = packageSid;
            SecretKey = secretKey;
            WindowsLiveEndpoint = windowsLiveEndpoint;
        }

        /// <summary>
        /// The package ID for this credential.
        /// Serialized Name: WnsCredential.properties.packageSid
        /// </summary>
        public string PackageSid { get; set; }
        /// <summary>
        /// The secret key.
        /// Serialized Name: WnsCredential.properties.secretKey
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// The Windows Live endpoint.
        /// Serialized Name: WnsCredential.properties.windowsLiveEndpoint
        /// </summary>
        public Uri WindowsLiveEndpoint { get; set; }
    }
}
