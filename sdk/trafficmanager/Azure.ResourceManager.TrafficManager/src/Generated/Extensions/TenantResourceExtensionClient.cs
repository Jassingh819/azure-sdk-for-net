// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _profileClientDiagnostics;
        private ProfilesRestOperations _profileRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ProfileClientDiagnostics => _profileClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.TrafficManager", ProfileResource.ResourceType.Namespace, Diagnostics);
        private ProfilesRestOperations ProfileRestClient => _profileRestClient ??= new ProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a TrafficManagerGeographicHierarchyResource along with the instance operations that can be performed on it in the TenantResource. </summary>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource" /> object. </returns>
        public virtual TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchy()
        {
            return new TrafficManagerGeographicHierarchyResource(Client, new ResourceIdentifier(Id.ToString() + "/providers/Microsoft.Network/trafficManagerGeographicHierarchies/default"));
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// Request Path: /providers/Microsoft.Network/checkTrafficManagerNameAvailability
        /// Operation Id: Profiles_CheckTrafficManagerRelativeDnsNameAvailability
        /// </summary>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TrafficManagerNameAvailability>> CheckTrafficManagerRelativeDnsNameAvailabilityProfileAsync(CheckTrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ProfileClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckTrafficManagerRelativeDnsNameAvailabilityProfile");
            scope.Start();
            try
            {
                var response = await ProfileRestClient.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// Request Path: /providers/Microsoft.Network/checkTrafficManagerNameAvailability
        /// Operation Id: Profiles_CheckTrafficManagerRelativeDnsNameAvailability
        /// </summary>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TrafficManagerNameAvailability> CheckTrafficManagerRelativeDnsNameAvailabilityProfile(CheckTrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ProfileClientDiagnostics.CreateScope("TenantResourceExtensionClient.CheckTrafficManagerRelativeDnsNameAvailabilityProfile");
            scope.Start();
            try
            {
                var response = ProfileRestClient.CheckTrafficManagerRelativeDnsNameAvailability(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
