// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput))]
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateOracleAzureDBPostgreSqlSyncTaskOutput IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutput(document.RootElement, options);
        }

        internal static MigrateOracleAzureDBPostgreSqlSyncTaskOutput DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError.DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(element, options);
                    case "DatabaseLevelOutput": return MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel.DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(element, options);
                    case "ErrorOutput": return MigrateOracleAzureDBPostgreSqlSyncTaskOutputError.DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputError(element, options);
                    case "MigrationLevelOutput": return MigrateOracleAzureDBPostgreSqlSyncTaskOutputMigrationLevel.DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputMigrationLevel(element, options);
                    case "TableLevelOutput": return MigrateOracleAzureDBPostgreSqlSyncTaskOutputTableLevel.DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputTableLevel(element, options);
                }
            }
            return UnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput.DeserializeUnknownMigrateOracleAzureDBPostgreSqlSyncTaskOutput(element, options);
        }

        BinaryData IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutput IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
