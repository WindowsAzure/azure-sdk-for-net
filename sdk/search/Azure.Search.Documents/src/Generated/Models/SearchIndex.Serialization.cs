// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndex : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Fields != null && Fields.Any())
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ScoringProfiles != null && ScoringProfiles.Any())
            {
                writer.WritePropertyName("scoringProfiles");
                writer.WriteStartArray();
                foreach (var item in ScoringProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultScoringProfile != null)
            {
                writer.WritePropertyName("defaultScoringProfile");
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (CorsOptions != null)
            {
                writer.WritePropertyName("corsOptions");
                writer.WriteObjectValue(CorsOptions);
            }
            if (Suggesters != null && Suggesters.Any())
            {
                writer.WritePropertyName("suggesters");
                writer.WriteStartArray();
                foreach (var item in Suggesters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Analyzers != null && Analyzers.Any())
            {
                writer.WritePropertyName("analyzers");
                writer.WriteStartArray();
                foreach (var item in Analyzers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Tokenizers != null && Tokenizers.Any())
            {
                writer.WritePropertyName("tokenizers");
                writer.WriteStartArray();
                foreach (var item in Tokenizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TokenFilters != null && TokenFilters.Any())
            {
                writer.WritePropertyName("tokenFilters");
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (CharFilters != null && CharFilters.Any())
            {
                writer.WritePropertyName("charFilters");
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EncryptionKey != null)
            {
                writer.WritePropertyName("encryptionKey");
                writer.WriteObjectValue(EncryptionKey);
            }
            if (Similarity != null)
            {
                writer.WritePropertyName("similarity");
                writer.WriteObjectValue(Similarity);
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SearchIndex DeserializeSearchIndex(JsonElement element)
        {
            string name = default;
            IList<SearchField> fields = default;
            IList<ScoringProfile> scoringProfiles = default;
            string defaultScoringProfile = default;
            CorsOptions corsOptions = default;
            IList<SearchSuggester> suggesters = default;
            IList<LexicalAnalyzer> analyzers = default;
            IList<LexicalTokenizer> tokenizers = default;
            IList<TokenFilter> tokenFilters = default;
            IList<CharFilter> charFilters = default;
            SearchResourceEncryptionKey encryptionKey = default;
            SimilarityAlgorithm similarity = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchField> array = new List<SearchField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SearchField.DeserializeSearchField(item));
                        }
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("scoringProfiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringProfile> array = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ScoringProfile.DeserializeScoringProfile(item));
                        }
                    }
                    scoringProfiles = array;
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchSuggester> array = new List<SearchSuggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SearchSuggester.DeserializeSearchSuggester(item));
                        }
                    }
                    suggesters = array;
                    continue;
                }
                if (property.NameEquals("analyzers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalAnalyzer> array = new List<LexicalAnalyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LexicalAnalyzer.DeserializeLexicalAnalyzer(item));
                        }
                    }
                    analyzers = array;
                    continue;
                }
                if (property.NameEquals("tokenizers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LexicalTokenizer> array = new List<LexicalTokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LexicalTokenizer.DeserializeLexicalTokenizer(item));
                        }
                    }
                    tokenizers = array;
                    continue;
                }
                if (property.NameEquals("tokenFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilter> array = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TokenFilter.DeserializeTokenFilter(item));
                        }
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CharFilter> array = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(CharFilter.DeserializeCharFilter(item));
                        }
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("encryptionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("similarity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    similarity = SimilarityAlgorithm.DeserializeSimilarityAlgorithm(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SearchIndex(name, fields, scoringProfiles, defaultScoringProfile, corsOptions, suggesters, analyzers, tokenizers, tokenFilters, charFilters, encryptionKey, similarity, odataEtag);
        }
    }
}
