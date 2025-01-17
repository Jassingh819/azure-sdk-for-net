// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The private link configuration. </summary>
    public partial class HDInsightPrivateLinkConfiguration
    {
        /// <summary> Initializes a new instance of HDInsightPrivateLinkConfiguration. </summary>
        /// <param name="name"> The name of private link configuration. </param>
        /// <param name="groupId"> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, &apos;headnode&apos;, &apos;gateway&apos;, &apos;edgenode&apos;. </param>
        /// <param name="ipConfigurations"> The IP configurations for the private link service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="groupId"/> or <paramref name="ipConfigurations"/> is null. </exception>
        public HDInsightPrivateLinkConfiguration(string name, string groupId, IEnumerable<HDInsightIPConfiguration> ipConfigurations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }
            if (ipConfigurations == null)
            {
                throw new ArgumentNullException(nameof(ipConfigurations));
            }

            Name = name;
            GroupId = groupId;
            IPConfigurations = ipConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of HDInsightPrivateLinkConfiguration. </summary>
        /// <param name="id"> The private link configuration id. </param>
        /// <param name="name"> The name of private link configuration. </param>
        /// <param name="resourceType"> The type of the private link configuration. </param>
        /// <param name="groupId"> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, &apos;headnode&apos;, &apos;gateway&apos;, &apos;edgenode&apos;. </param>
        /// <param name="provisioningState"> The private link configuration provisioning state, which only appears in the response. </param>
        /// <param name="ipConfigurations"> The IP configurations for the private link service. </param>
        internal HDInsightPrivateLinkConfiguration(string id, string name, string resourceType, string groupId, HDInsightPrivateLinkConfigurationProvisioningState? provisioningState, IList<HDInsightIPConfiguration> ipConfigurations)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            IPConfigurations = ipConfigurations;
        }

        /// <summary> The private link configuration id. </summary>
        public string Id { get; }
        /// <summary> The name of private link configuration. </summary>
        public string Name { get; set; }
        /// <summary> The type of the private link configuration. </summary>
        public string ResourceType { get; }
        /// <summary> The HDInsight private linkable sub-resource name to apply the private link configuration to. For example, &apos;headnode&apos;, &apos;gateway&apos;, &apos;edgenode&apos;. </summary>
        public string GroupId { get; set; }
        /// <summary> The private link configuration provisioning state, which only appears in the response. </summary>
        public HDInsightPrivateLinkConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> The IP configurations for the private link service. </summary>
        public IList<HDInsightIPConfiguration> IPConfigurations { get; }
    }
}
