// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary>
    /// Description of a NotificationHub GcmCredential.
    /// Serialized Name: GcmCredential
    /// </summary>
    public partial class NotificationHubGcmCredential
    {
        /// <summary> Initializes a new instance of NotificationHubGcmCredential. </summary>
        public NotificationHubGcmCredential()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubGcmCredential. </summary>
        /// <param name="gcmEndpoint">
        /// The FCM legacy endpoint. Default value is &apos;https://fcm.googleapis.com/fcm/send&apos;
        /// Serialized Name: GcmCredential.properties.gcmEndpoint
        /// </param>
        /// <param name="googleApiKey">
        /// The Google API key.
        /// Serialized Name: GcmCredential.properties.googleApiKey
        /// </param>
        internal NotificationHubGcmCredential(Uri gcmEndpoint, string googleApiKey)
        {
            GcmEndpoint = gcmEndpoint;
            GoogleApiKey = googleApiKey;
        }

        /// <summary>
        /// The FCM legacy endpoint. Default value is &apos;https://fcm.googleapis.com/fcm/send&apos;
        /// Serialized Name: GcmCredential.properties.gcmEndpoint
        /// </summary>
        public Uri GcmEndpoint { get; set; }
        /// <summary>
        /// The Google API key.
        /// Serialized Name: GcmCredential.properties.googleApiKey
        /// </summary>
        public string GoogleApiKey { get; set; }
    }
}
