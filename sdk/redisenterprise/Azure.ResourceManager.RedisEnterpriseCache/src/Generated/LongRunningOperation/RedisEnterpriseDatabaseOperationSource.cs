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
    internal class RedisEnterpriseDatabaseOperationSource : IOperationSource<RedisEnterpriseDatabaseResource>
    {
        private readonly ArmClient _client;

        internal RedisEnterpriseDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        RedisEnterpriseDatabaseResource IOperationSource<RedisEnterpriseDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RedisEnterpriseDatabaseData.DeserializeRedisEnterpriseDatabaseData(document.RootElement);
            return new RedisEnterpriseDatabaseResource(_client, data);
        }

        async ValueTask<RedisEnterpriseDatabaseResource> IOperationSource<RedisEnterpriseDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RedisEnterpriseDatabaseData.DeserializeRedisEnterpriseDatabaseData(document.RootElement);
            return new RedisEnterpriseDatabaseResource(_client, data);
        }
    }
}
