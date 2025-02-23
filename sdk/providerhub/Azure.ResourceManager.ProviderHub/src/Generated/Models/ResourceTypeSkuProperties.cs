// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuProperties. </summary>
    public partial class ResourceTypeSkuProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/>. </summary>
        /// <param name="skuSettings"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="skuSettings"/> is null. </exception>
        public ResourceTypeSkuProperties(IEnumerable<ResourceTypeSkuSetting> skuSettings)
        {
            Argument.AssertNotNull(skuSettings, nameof(skuSettings));

            SkuSettings = skuSettings.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/>. </summary>
        /// <param name="skuSettings"></param>
        /// <param name="provisioningState"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeSkuProperties(IList<ResourceTypeSkuSetting> skuSettings, ProviderHubProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SkuSettings = skuSettings;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuProperties"/> for deserialization. </summary>
        internal ResourceTypeSkuProperties()
        {
        }

        /// <summary> Gets the sku settings. </summary>
        public IList<ResourceTypeSkuSetting> SkuSettings { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
    }
}
