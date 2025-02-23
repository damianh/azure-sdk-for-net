// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Solution result. </summary>
    public partial class SolutionResourceProperties
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

        /// <summary> Initializes a new instance of <see cref="SolutionResourceProperties"/>. </summary>
        public SolutionResourceProperties()
        {
            TriggerCriteria = new ChangeTrackingList<TriggerCriterion>();
            Parameters = new ChangeTrackingDictionary<string, string>();
            Sections = new ChangeTrackingList<SelfHelpSection>();
        }

        /// <summary> Initializes a new instance of <see cref="SolutionResourceProperties"/>. </summary>
        /// <param name="triggerCriteria"> Solution request trigger criteria. </param>
        /// <param name="parameters"> Client input parameters to run Solution. </param>
        /// <param name="solutionId"> Solution Id to identify single solution. </param>
        /// <param name="provisioningState"> Status of solution provisioning. </param>
        /// <param name="title"> The title. </param>
        /// <param name="content"> The HTML content that needs to be rendered and shown to customer. </param>
        /// <param name="replacementMaps"> Solution replacement maps. </param>
        /// <param name="sections"> List of section object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SolutionResourceProperties(IList<TriggerCriterion> triggerCriteria, IDictionary<string, string> parameters, string solutionId, SolutionProvisioningState? provisioningState, string title, string content, ReplacementMaps replacementMaps, IList<SelfHelpSection> sections, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TriggerCriteria = triggerCriteria;
            Parameters = parameters;
            SolutionId = solutionId;
            ProvisioningState = provisioningState;
            Title = title;
            Content = content;
            ReplacementMaps = replacementMaps;
            Sections = sections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Solution request trigger criteria. </summary>
        public IList<TriggerCriterion> TriggerCriteria { get; }
        /// <summary> Client input parameters to run Solution. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Solution Id to identify single solution. </summary>
        public string SolutionId { get; set; }
        /// <summary> Status of solution provisioning. </summary>
        public SolutionProvisioningState? ProvisioningState { get; set; }
        /// <summary> The title. </summary>
        public string Title { get; set; }
        /// <summary> The HTML content that needs to be rendered and shown to customer. </summary>
        public string Content { get; set; }
        /// <summary> Solution replacement maps. </summary>
        public ReplacementMaps ReplacementMaps { get; set; }
        /// <summary> List of section object. </summary>
        public IList<SelfHelpSection> Sections { get; }
    }
}
