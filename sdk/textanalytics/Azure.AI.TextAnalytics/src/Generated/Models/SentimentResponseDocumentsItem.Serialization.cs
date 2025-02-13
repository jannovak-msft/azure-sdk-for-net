// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class SentimentResponseDocumentsItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DetectedLanguage))
            {
                writer.WritePropertyName("detectedLanguage");
                writer.WriteObjectValue(DetectedLanguage.Value);
            }
            writer.WritePropertyName("sentiment");
            writer.WriteStringValue(Sentiment.ToSerialString());
            writer.WritePropertyName("confidenceScores");
            writer.WriteObjectValue(ConfidenceScores);
            writer.WritePropertyName("sentences");
            writer.WriteStartArray();
            foreach (var item in Sentences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings");
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics");
                writer.WriteObjectValue(Statistics.Value);
            }
            writer.WriteEndObject();
        }

        internal static SentimentResponseDocumentsItem DeserializeSentimentResponseDocumentsItem(JsonElement element)
        {
            Optional<DetectedLanguageInternal> detectedLanguage = default;
            TextSentiment sentiment = default;
            SentimentConfidenceScores confidenceScores = default;
            IList<SentenceSentimentInternal> sentences = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("detectedLanguage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detectedLanguage = DetectedLanguageInternal.DeserializeDetectedLanguageInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString().ToTextSentiment();
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = SentimentConfidenceScores.DeserializeSentimentConfidenceScores(property.Value);
                    continue;
                }
                if (property.NameEquals("sentences"))
                {
                    List<SentenceSentimentInternal> array = new List<SentenceSentimentInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceSentimentInternal.DeserializeSentenceSentimentInternal(item));
                    }
                    sentences = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new SentimentResponseDocumentsItem(id, warnings, Optional.ToNullable(statistics), sentiment, confidenceScores, sentences, Optional.ToNullable(detectedLanguage));
        }
    }
}
