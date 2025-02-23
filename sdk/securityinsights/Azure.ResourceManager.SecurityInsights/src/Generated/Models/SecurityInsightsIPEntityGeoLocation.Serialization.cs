// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIPEntityGeoLocation : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIPEntityGeoLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIPEntityGeoLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIPEntityGeoLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIPEntityGeoLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIPEntityGeoLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (options.Format != "W" && Optional.IsDefined(CountryCode))
            {
                writer.WritePropertyName("countryCode"u8);
                writer.WriteStringValue(CountryCode);
            }
            if (options.Format != "W" && Optional.IsDefined(CountryName))
            {
                writer.WritePropertyName("countryName"u8);
                writer.WriteStringValue(CountryName);
            }
            if (options.Format != "W" && Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteNumberValue(Latitude.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteNumberValue(Longitude.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        SecurityInsightsIPEntityGeoLocation IJsonModel<SecurityInsightsIPEntityGeoLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIPEntityGeoLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIPEntityGeoLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIPEntityGeoLocation(document.RootElement, options);
        }

        internal static SecurityInsightsIPEntityGeoLocation DeserializeSecurityInsightsIPEntityGeoLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? asn = default;
            string city = default;
            string countryCode = default;
            string countryName = default;
            double? latitude = default;
            double? longitude = default;
            string state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryName"u8))
                {
                    countryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIPEntityGeoLocation(
                asn,
                city,
                countryCode,
                countryName,
                latitude,
                longitude,
                state,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIPEntityGeoLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIPEntityGeoLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIPEntityGeoLocation)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsIPEntityGeoLocation IPersistableModel<SecurityInsightsIPEntityGeoLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIPEntityGeoLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIPEntityGeoLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIPEntityGeoLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIPEntityGeoLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
