// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted key or value in a key-value pair. </summary>
    internal partial class KeyValueElement
    {
        /// <summary> Initializes a new instance of <see cref="KeyValueElement"/>. </summary>
        /// <param name="text"> The text content of the key or value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal KeyValueElement(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            BoundingBox = new ChangeTrackingList<float>();
            Elements = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyValueElement"/>. </summary>
        /// <param name="type"> Semantic data type of the key value element. </param>
        /// <param name="text"> The text content of the key or value. </param>
        /// <param name="boundingBox"> Bounding box of the key or value. </param>
        /// <param name="elements"> When includeTextDetails is set to true, a list of references to the text elements constituting this key or value. </param>
        internal KeyValueElement(KeyValueType? type, string text, IReadOnlyList<float> boundingBox, IReadOnlyList<string> elements)
        {
            Type = type;
            Text = text;
            BoundingBox = boundingBox;
            Elements = elements;
        }

        /// <summary> Semantic data type of the key value element. </summary>
        public KeyValueType? Type { get; }
        /// <summary> The text content of the key or value. </summary>
        public string Text { get; }
        /// <summary> Bounding box of the key or value. </summary>
        public IReadOnlyList<float> BoundingBox { get; }
        /// <summary> When includeTextDetails is set to true, a list of references to the text elements constituting this key or value. </summary>
        public IReadOnlyList<string> Elements { get; }
    }
}
