// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A selection mark object representing check boxes, radio buttons, and other elements indicating a selection. </summary>
    public partial class DocumentSelectionMark
    {
        /// <summary> Initializes a new instance of DocumentSelectionMark. </summary>
        /// <param name="statePrivate"> State of the selection mark. </param>
        /// <param name="span"> Location of the selection mark in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the selection mark. </param>
        internal DocumentSelectionMark(V3SelectionMarkState statePrivate, DocumentSpan span, float confidence)
        {
            StatePrivate = statePrivate;
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of DocumentSelectionMark. </summary>
        /// <param name="statePrivate"> State of the selection mark. </param>
        /// <param name="polygon"> Bounding polygon of the selection mark. </param>
        /// <param name="span"> Location of the selection mark in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the selection mark. </param>
        internal DocumentSelectionMark(V3SelectionMarkState statePrivate, IReadOnlyList<float> polygon, DocumentSpan span, float confidence)
        {
            StatePrivate = statePrivate;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
        }
        /// <summary> Location of the selection mark in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the selection mark. </summary>
        public float Confidence { get; }
    }
}
