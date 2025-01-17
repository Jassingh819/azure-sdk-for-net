// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary>
    /// Description of a NotificationHub BaiduCredential.
    /// Serialized Name: BaiduCredential
    /// </summary>
    public partial class NotificationHubBaiduCredential
    {
        /// <summary> Initializes a new instance of NotificationHubBaiduCredential. </summary>
        public NotificationHubBaiduCredential()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubBaiduCredential. </summary>
        /// <param name="baiduApiKey">
        /// Baidu Api Key.
        /// Serialized Name: BaiduCredential.properties.baiduApiKey
        /// </param>
        /// <param name="baiduEndpoint">
        /// Baidu Endpoint.
        /// Serialized Name: BaiduCredential.properties.baiduEndPoint
        /// </param>
        /// <param name="baiduSecretKey">
        /// Baidu Secret Key
        /// Serialized Name: BaiduCredential.properties.baiduSecretKey
        /// </param>
        internal NotificationHubBaiduCredential(string baiduApiKey, Uri baiduEndpoint, string baiduSecretKey)
        {
            BaiduApiKey = baiduApiKey;
            BaiduEndpoint = baiduEndpoint;
            BaiduSecretKey = baiduSecretKey;
        }

        /// <summary>
        /// Baidu Api Key.
        /// Serialized Name: BaiduCredential.properties.baiduApiKey
        /// </summary>
        public string BaiduApiKey { get; set; }
        /// <summary>
        /// Baidu Endpoint.
        /// Serialized Name: BaiduCredential.properties.baiduEndPoint
        /// </summary>
        public Uri BaiduEndpoint { get; set; }
        /// <summary>
        /// Baidu Secret Key
        /// Serialized Name: BaiduCredential.properties.baiduSecretKey
        /// </summary>
        public string BaiduSecretKey { get; set; }
    }
}
