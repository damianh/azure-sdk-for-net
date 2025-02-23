// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryExampleTextItem : IUtf8JsonSerializable, IJsonModel<DictionaryExampleTextItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DictionaryExampleTextItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DictionaryExampleTextItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleTextItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExampleTextItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("translation"u8);
            writer.WriteStringValue(Translation);
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
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

        DictionaryExampleTextItem IJsonModel<DictionaryExampleTextItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleTextItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExampleTextItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryExampleTextItem(document.RootElement, options);
        }

        internal static DictionaryExampleTextItem DeserializeDictionaryExampleTextItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string translation = default;
            string text = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("translation"u8))
                {
                    translation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DictionaryExampleTextItem(text, serializedAdditionalRawData, translation);
        }

        BinaryData IPersistableModel<DictionaryExampleTextItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleTextItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DictionaryExampleTextItem)} does not support '{options.Format}' format.");
            }
        }

        DictionaryExampleTextItem IPersistableModel<DictionaryExampleTextItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleTextItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDictionaryExampleTextItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DictionaryExampleTextItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DictionaryExampleTextItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DictionaryExampleTextItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDictionaryExampleTextItem(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
