// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RedisEnterprise;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Specifies configuration of a redis module. </summary>
    public partial class RedisEnterpriseModule
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

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseModule"/>. </summary>
        /// <param name="name"> The name of the module, e.g. 'RedisBloom', 'RediSearch', 'RedisTimeSeries'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RedisEnterpriseModule(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseModule"/>. </summary>
        /// <param name="name"> The name of the module, e.g. 'RedisBloom', 'RediSearch', 'RedisTimeSeries'. </param>
        /// <param name="args"> Configuration options for the module, e.g. 'ERROR_RATE 0.01 INITIAL_SIZE 400'. </param>
        /// <param name="version"> The version of the module, e.g. '1.0'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseModule(string name, string args, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Args = args;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseModule"/> for deserialization. </summary>
        internal RedisEnterpriseModule()
        {
        }

        /// <summary> The name of the module, e.g. 'RedisBloom', 'RediSearch', 'RedisTimeSeries'. </summary>
        public string Name { get; set; }
        /// <summary> Configuration options for the module, e.g. 'ERROR_RATE 0.01 INITIAL_SIZE 400'. </summary>
        public string Args { get; set; }
        /// <summary> The version of the module, e.g. '1.0'. </summary>
        public string Version { get; }
    }
}
