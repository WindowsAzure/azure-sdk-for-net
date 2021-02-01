﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Communication.Identity;
using Azure.Communication;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.Core;

namespace Azure.Communication.Chat.Tests.samples
{
    public partial class Sample3_MemberOperations : SamplesBase<ChatTestEnvironment>
    {
        // This sample demonstrates the operations that can be performed on a thread for members: add, get and remove members
        [Test]
        public async Task GetAddRemoveMembersAsync()
        {
            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(TestEnvironment.ConnectionString);
            Response<CommunicationUserIdentifier> threadMember1 = await communicationIdentityClient.CreateUserAsync();
            Response<CommunicationUserIdentifier> threadMember2 = await communicationIdentityClient.CreateUserAsync();
            Response<CommunicationUserIdentifier> threadMember3 = await communicationIdentityClient.CreateUserAsync();

            AccessToken communicationUserToken1 = await communicationIdentityClient.IssueTokenAsync(threadMember1.Value, new[] { CommunicationTokenScope.Chat });
            AccessToken communicationUserToken2 = await communicationIdentityClient.IssueTokenAsync(threadMember2.Value, new[] { CommunicationTokenScope.Chat });
            AccessToken communicationUserToken3 = await communicationIdentityClient.IssueTokenAsync(threadMember3.Value, new[] { CommunicationTokenScope.Chat });
            string userToken = communicationUserToken1.Token;
            string endpoint = TestEnvironment.ChatApiUrl();
            string theadCreatorMemberId = threadMember1.Value.Id;

            ChatClient chatClient = new ChatClient(
                new Uri(endpoint),
                new CommunicationTokenCredential(userToken));

            var chatThreadMember = new ChatThreadMember(new CommunicationUserIdentifier(theadCreatorMemberId))
            {
                DisplayName = "UserDisplayName",
                ShareHistoryTime = DateTime.MinValue
            };
            ChatThreadClient chatThreadClient = await chatClient.CreateChatThreadAsync(topic: "Hello world!", members: new[] { chatThreadMember });
            string threadId = chatThreadClient.Id;

            #region Snippet:Azure_Communication_Chat_Tests_Samples_GetMembers
            AsyncPageable<ChatThreadMember> allMembers = chatThreadClient.GetMembersAsync();
            await foreach (ChatThreadMember member in allMembers)
            {
                Console.WriteLine($"{member.User.Id}:{member.DisplayName}:{member.ShareHistoryTime}");
            }
            #endregion Snippet:Azure_Communication_Chat_Tests_GetMembers

            var memberId1 = theadCreatorMemberId;
            var memberId2 = threadMember2.Value.Id;
            var memberId3 = threadMember3.Value.Id;

            #region Snippet:Azure_Communication_Chat_Tests_Samples_AddMembers
            var members = new[]
            {
                new ChatThreadMember(new CommunicationUserIdentifier(memberId1)) { DisplayName ="display name member 1"},
                new ChatThreadMember(new CommunicationUserIdentifier(memberId2)) { DisplayName ="display name member 2"},
                new ChatThreadMember(new CommunicationUserIdentifier(memberId3)) { DisplayName ="display name member 3"}
            };
            await chatThreadClient.AddMembersAsync(members);
            #endregion Snippet:Azure_Communication_Chat_Tests_Samples_AddMembers

            var memberId = memberId2;
            #region Snippet:Azure_Communication_Chat_Tests_Samples_RemoveMember
            await chatThreadClient.RemoveMemberAsync(new CommunicationUserIdentifier(memberId));
            #endregion Snippet:Azure_Communication_Chat_Tests_Samples_RemoveMember

            await chatClient.DeleteChatThreadAsync(threadId);
        }
    }
}
