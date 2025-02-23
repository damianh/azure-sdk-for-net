// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The approval stage. </summary>
    public partial class RoleManagementApprovalStage
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

        /// <summary> Initializes a new instance of <see cref="RoleManagementApprovalStage"/>. </summary>
        public RoleManagementApprovalStage()
        {
            PrimaryApprovers = new ChangeTrackingList<RoleManagementUserInfo>();
            EscalationApprovers = new ChangeTrackingList<RoleManagementUserInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementApprovalStage"/>. </summary>
        /// <param name="approvalStageTimeOutInDays"> The time in days when approval request would be timed out. </param>
        /// <param name="isApproverJustificationRequired"> Determines whether approver need to provide justification for his decision. </param>
        /// <param name="escalationTimeInMinutes"> The time in minutes when the approval request would be escalated if the primary approver does not approve. </param>
        /// <param name="primaryApprovers"> The primary approver of the request. </param>
        /// <param name="isEscalationEnabled"> The value determine whether escalation feature is enabled. </param>
        /// <param name="escalationApprovers"> The escalation approver of the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleManagementApprovalStage(int? approvalStageTimeOutInDays, bool? isApproverJustificationRequired, int? escalationTimeInMinutes, IList<RoleManagementUserInfo> primaryApprovers, bool? isEscalationEnabled, IList<RoleManagementUserInfo> escalationApprovers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApprovalStageTimeOutInDays = approvalStageTimeOutInDays;
            IsApproverJustificationRequired = isApproverJustificationRequired;
            EscalationTimeInMinutes = escalationTimeInMinutes;
            PrimaryApprovers = primaryApprovers;
            IsEscalationEnabled = isEscalationEnabled;
            EscalationApprovers = escalationApprovers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time in days when approval request would be timed out. </summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary> Determines whether approver need to provide justification for his decision. </summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary> The time in minutes when the approval request would be escalated if the primary approver does not approve. </summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary> The primary approver of the request. </summary>
        public IList<RoleManagementUserInfo> PrimaryApprovers { get; }
        /// <summary> The value determine whether escalation feature is enabled. </summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary> The escalation approver of the request. </summary>
        public IList<RoleManagementUserInfo> EscalationApprovers { get; }
    }
}
