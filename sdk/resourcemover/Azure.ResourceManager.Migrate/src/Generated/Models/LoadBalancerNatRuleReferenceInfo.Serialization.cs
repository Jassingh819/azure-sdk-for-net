// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class LoadBalancerNatRuleReferenceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("sourceArmResourceId");
            writer.WriteStringValue(SourceArmResourceId);
            writer.WriteEndObject();
        }

        internal static LoadBalancerNatRuleReferenceInfo DeserializeLoadBalancerNatRuleReferenceInfo(JsonElement element)
        {
            Optional<string> name = default;
            ResourceIdentifier sourceArmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceArmResourceId"))
                {
                    sourceArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new LoadBalancerNatRuleReferenceInfo(sourceArmResourceId, name.Value);
        }
    }
}
