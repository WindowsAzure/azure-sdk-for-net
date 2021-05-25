// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    /// <summary> The Groups service client. </summary>
    public partial class GroupsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GroupsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of GroupsOperations for mocking. </summary>
        protected GroupsOperations()
        {
        }

        /// <summary> Initializes a new instance of GroupsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal GroupsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            RestClient = new GroupsRestOperations(clientDiagnostics, pipeline, tenantID, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Checks whether the specified user, group, contact, or service principal is a direct or transitive member of the specified group. </summary>
        /// <param name="parameters"> The check group membership parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckGroupMembershipResult>> IsMemberOfAsync(CheckGroupMembershipParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.IsMemberOf");
            scope.Start();
            try
            {
                return await RestClient.IsMemberOfAsync(parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks whether the specified user, group, contact, or service principal is a direct or transitive member of the specified group. </summary>
        /// <param name="parameters"> The check group membership parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckGroupMembershipResult> IsMemberOf(CheckGroupMembershipParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.IsMemberOf");
            scope.Start();
            try
            {
                return RestClient.IsMemberOf(parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove a member from a group. </summary>
        /// <param name="groupObjectId"> The object ID of the group from which to remove the member. </param>
        /// <param name="memberObjectId"> Member object id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RemoveMemberAsync(string groupObjectId, string memberObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.RemoveMember");
            scope.Start();
            try
            {
                return await RestClient.RemoveMemberAsync(groupObjectId, memberObjectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove a member from a group. </summary>
        /// <param name="groupObjectId"> The object ID of the group from which to remove the member. </param>
        /// <param name="memberObjectId"> Member object id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RemoveMember(string groupObjectId, string memberObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.RemoveMember");
            scope.Start();
            try
            {
                return RestClient.RemoveMember(groupObjectId, memberObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a member to a group. </summary>
        /// <param name="groupObjectId"> The object ID of the group to which to add the member. </param>
        /// <param name="parameters"> The URL of the member object, such as https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AddMemberAsync(string groupObjectId, GroupAddMemberParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.AddMember");
            scope.Start();
            try
            {
                return await RestClient.AddMemberAsync(groupObjectId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a member to a group. </summary>
        /// <param name="groupObjectId"> The object ID of the group to which to add the member. </param>
        /// <param name="parameters"> The URL of the member object, such as https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AddMember(string groupObjectId, GroupAddMemberParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.AddMember");
            scope.Start();
            try
            {
                return RestClient.AddMember(groupObjectId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a group in the directory. </summary>
        /// <param name="parameters"> The parameters for the group to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ADGroup>> CreateAsync(GroupCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a group in the directory. </summary>
        /// <param name="parameters"> The parameters for the group to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ADGroup> Create(GroupCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Create");
            scope.Start();
            try
            {
                return RestClient.Create(parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets group information from the directory. </summary>
        /// <param name="objectId"> The object ID of the user for which to get group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ADGroup>> GetAsync(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(objectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets group information from the directory. </summary>
        /// <param name="objectId"> The object ID of the user for which to get group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ADGroup> Get(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(objectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a group from the directory. </summary>
        /// <param name="objectId"> The object ID of the group to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(objectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a group from the directory. </summary>
        /// <param name="objectId"> The object ID of the group to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(objectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add an owner to a group. </summary>
        /// <param name="objectId"> The object ID of the application to which to add the owner. </param>
        /// <param name="parameters"> The URL of the owner object, such as https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AddOwnerAsync(string objectId, AddOwnerParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.AddOwner");
            scope.Start();
            try
            {
                return await RestClient.AddOwnerAsync(objectId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add an owner to a group. </summary>
        /// <param name="objectId"> The object ID of the application to which to add the owner. </param>
        /// <param name="parameters"> The URL of the owner object, such as https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AddOwner(string objectId, AddOwnerParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.AddOwner");
            scope.Start();
            try
            {
                return RestClient.AddOwner(objectId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove a member from owners. </summary>
        /// <param name="objectId"> The object ID of the group from which to remove the owner. </param>
        /// <param name="ownerObjectId"> Owner object id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RemoveOwnerAsync(string objectId, string ownerObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.RemoveOwner");
            scope.Start();
            try
            {
                return await RestClient.RemoveOwnerAsync(objectId, ownerObjectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove a member from owners. </summary>
        /// <param name="objectId"> The object ID of the group from which to remove the owner. </param>
        /// <param name="ownerObjectId"> Owner object id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RemoveOwner(string objectId, string ownerObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GroupsOperations.RemoveOwner");
            scope.Start();
            try
            {
                return RestClient.RemoveOwner(objectId, ownerObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets list of groups for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ADGroup> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ADGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ADGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets list of groups for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ADGroup> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ADGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ADGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the members of a group. </summary>
        /// <param name="objectId"> The object ID of the group whose members should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual AsyncPageable<DirectoryObject> GetGroupMembersAsync(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            async Task<Page<DirectoryObject>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembers");
                scope.Start();
                try
                {
                    var response = await RestClient.GetGroupMembersAsync(objectId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DirectoryObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembers");
                scope.Start();
                try
                {
                    var response = await RestClient.GetGroupMembersNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the members of a group. </summary>
        /// <param name="objectId"> The object ID of the group whose members should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual Pageable<DirectoryObject> GetGroupMembers(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            Page<DirectoryObject> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembers");
                scope.Start();
                try
                {
                    var response = RestClient.GetGroupMembers(objectId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DirectoryObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembers");
                scope.Start();
                try
                {
                    var response = RestClient.GetGroupMembersNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a collection of object IDs of groups of which the specified group is a member. </summary>
        /// <param name="objectId"> The object ID of the group for which to get group membership. </param>
        /// <param name="parameters"> Group filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AsyncPageable<string> GetMemberGroupsAsync(string objectId, GroupGetMemberGroupsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            async Task<Page<string>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetMemberGroups");
                scope.Start();
                try
                {
                    var response = await RestClient.GetMemberGroupsAsync(objectId, parameters, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a collection of object IDs of groups of which the specified group is a member. </summary>
        /// <param name="objectId"> The object ID of the group for which to get group membership. </param>
        /// <param name="parameters"> Group filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Pageable<string> GetMemberGroups(string objectId, GroupGetMemberGroupsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Page<string> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetMemberGroups");
                scope.Start();
                try
                {
                    var response = RestClient.GetMemberGroups(objectId, parameters, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> The owners are a set of non-admin users who are allowed to modify this object. </summary>
        /// <param name="objectId"> The object ID of the group for which to get owners. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual AsyncPageable<DirectoryObject> ListOwnersAsync(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            async Task<Page<DirectoryObject>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListOwners");
                scope.Start();
                try
                {
                    var response = await RestClient.ListOwnersAsync(objectId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DirectoryObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListOwners");
                scope.Start();
                try
                {
                    var response = await RestClient.ListOwnersNextPageAsync(nextLink, objectId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The owners are a set of non-admin users who are allowed to modify this object. </summary>
        /// <param name="objectId"> The object ID of the group for which to get owners. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectId"/> is null. </exception>
        public virtual Pageable<DirectoryObject> ListOwners(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            Page<DirectoryObject> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListOwners");
                scope.Start();
                try
                {
                    var response = RestClient.ListOwners(objectId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DirectoryObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListOwners");
                scope.Start();
                try
                {
                    var response = RestClient.ListOwnersNextPage(nextLink, objectId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of groups for the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual AsyncPageable<ADGroup> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<ADGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ADGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of groups for the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Pageable<ADGroup> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<ADGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ADGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the members of a group. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual AsyncPageable<DirectoryObject> GetGroupMembersNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<DirectoryObject>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembersNext");
                scope.Start();
                try
                {
                    var response = await RestClient.GetGroupMembersNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DirectoryObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembersNext");
                scope.Start();
                try
                {
                    var response = await RestClient.GetGroupMembersNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the members of a group. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public virtual Pageable<DirectoryObject> GetGroupMembersNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<DirectoryObject> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembersNext");
                scope.Start();
                try
                {
                    var response = RestClient.GetGroupMembersNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DirectoryObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GroupsOperations.GetGroupMembersNext");
                scope.Start();
                try
                {
                    var response = RestClient.GetGroupMembersNextNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
