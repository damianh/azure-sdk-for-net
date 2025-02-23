// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Error details. </summary>
    internal partial class ErrorDetail
    {
        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        /// <param name="code"> The error's code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorDetail(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetail"/>. </summary>
        /// <param name="code"> The error's code. </param>
        /// <param name="message"> A human readable error message. </param>
        /// <param name="target"> Indicates which property in the request is responsible for the error. </param>
        /// <param name="value"> Indicates which value in 'target' is responsible for the error. </param>
        /// <param name="resources"> Indicates resources which were responsible for the error. </param>
        /// <param name="additionalProperties"> Additional properties that can be provided on the error details object. </param>
        internal ErrorDetail(string code, string message, string target, string value, IReadOnlyList<string> resources, object additionalProperties)
        {
            Code = code;
            Message = message;
            Target = target;
            Value = value;
            Resources = resources;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The error's code. </summary>
        public string Code { get; }
        /// <summary> A human readable error message. </summary>
        public string Message { get; }
        /// <summary> Indicates which property in the request is responsible for the error. </summary>
        public string Target { get; }
        /// <summary> Indicates which value in 'target' is responsible for the error. </summary>
        public string Value { get; }
        /// <summary> Indicates resources which were responsible for the error. </summary>
        public IReadOnlyList<string> Resources { get; }
        /// <summary> Additional properties that can be provided on the error details object. </summary>
        public object AdditionalProperties { get; }
    }
}
