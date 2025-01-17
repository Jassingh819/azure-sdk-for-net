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

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformServiceResourceOperationSource : IOperationSource<AppPlatformServiceResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformServiceResource IOperationSource<AppPlatformServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppPlatformServiceResourceData.DeserializeAppPlatformServiceResourceData(document.RootElement);
            return new AppPlatformServiceResource(_client, data);
        }

        async ValueTask<AppPlatformServiceResource> IOperationSource<AppPlatformServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppPlatformServiceResourceData.DeserializeAppPlatformServiceResourceData(document.RootElement);
            return new AppPlatformServiceResource(_client, data);
        }
    }
}
