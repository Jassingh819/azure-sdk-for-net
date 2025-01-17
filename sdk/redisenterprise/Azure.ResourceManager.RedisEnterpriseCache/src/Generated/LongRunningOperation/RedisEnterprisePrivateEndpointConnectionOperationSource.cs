// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RedisEnterpriseCache
{
    internal class RedisEnterprisePrivateEndpointConnectionOperationSource : IOperationSource<RedisEnterprisePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal RedisEnterprisePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        RedisEnterprisePrivateEndpointConnectionResource IOperationSource<RedisEnterprisePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RedisEnterprisePrivateEndpointConnectionData.DeserializeRedisEnterprisePrivateEndpointConnectionData(document.RootElement);
            return new RedisEnterprisePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<RedisEnterprisePrivateEndpointConnectionResource> IOperationSource<RedisEnterprisePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RedisEnterprisePrivateEndpointConnectionData.DeserializeRedisEnterprisePrivateEndpointConnectionData(document.RootElement);
            return new RedisEnterprisePrivateEndpointConnectionResource(_client, data);
        }
    }
}
