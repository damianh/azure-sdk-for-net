// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class VaultPropertiesRedundancySettings : IUtf8JsonSerializable, IJsonModel<VaultPropertiesRedundancySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultPropertiesRedundancySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VaultPropertiesRedundancySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesRedundancySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultPropertiesRedundancySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StandardTierStorageRedundancy))
            {
                writer.WritePropertyName("standardTierStorageRedundancy"u8);
                writer.WriteStringValue(StandardTierStorageRedundancy.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CrossRegionRestore))
            {
                writer.WritePropertyName("crossRegionRestore"u8);
                writer.WriteStringValue(CrossRegionRestore.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VaultPropertiesRedundancySettings IJsonModel<VaultPropertiesRedundancySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesRedundancySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultPropertiesRedundancySettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultPropertiesRedundancySettings(document.RootElement, options);
        }

        internal static VaultPropertiesRedundancySettings DeserializeVaultPropertiesRedundancySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StandardTierStorageRedundancy? standardTierStorageRedundancy = default;
            CrossRegionRestore? crossRegionRestore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("standardTierStorageRedundancy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standardTierStorageRedundancy = new StandardTierStorageRedundancy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("crossRegionRestore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossRegionRestore = new CrossRegionRestore(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultPropertiesRedundancySettings(standardTierStorageRedundancy, crossRegionRestore, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VaultPropertiesRedundancySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesRedundancySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VaultPropertiesRedundancySettings)} does not support '{options.Format}' format.");
            }
        }

        VaultPropertiesRedundancySettings IPersistableModel<VaultPropertiesRedundancySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesRedundancySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultPropertiesRedundancySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VaultPropertiesRedundancySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultPropertiesRedundancySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
