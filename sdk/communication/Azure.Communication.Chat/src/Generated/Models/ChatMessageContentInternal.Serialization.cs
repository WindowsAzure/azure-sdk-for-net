// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatMessageContentInternal
    {
        internal static ChatMessageContentInternal DeserializeChatMessageContentInternal(JsonElement element)
        {
            Optional<string> message = default;
            Optional<string> topic = default;
            Optional<IReadOnlyList<ChatParticipantInternal>> participants = default;
            Optional<CommunicationIdentifierModel> initiatorCommunicationIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("participants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ChatParticipantInternal> array = new List<ChatParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatParticipantInternal.DeserializeChatParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("initiatorCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initiatorCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
            }
            return new ChatMessageContentInternal(message.Value, topic.Value, Optional.ToList(participants), initiatorCommunicationIdentifier.Value);
        }
    }
}
