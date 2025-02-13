// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Quantum.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Quantum
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Quantum. </summary>
    public static partial class QuantumExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets the list of Workspaces within a Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuantumWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<QuantumWorkspaceResource> GetQuantumWorkspacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetQuantumWorkspacesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the list of Workspaces within a Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuantumWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<QuantumWorkspaceResource> GetQuantumWorkspaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetQuantumWorkspaces(cancellationToken);
        }

        /// <summary>
        /// Returns the list of all provider offerings available for the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/offerings
        /// Operation Id: Offerings_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProviderDescription" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ProviderDescription> GetOfferingsAsync(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).GetOfferingsAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// Returns the list of all provider offerings available for the given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/offerings
        /// Operation Id: Offerings_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="ProviderDescription" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ProviderDescription> GetOfferings(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).GetOfferings(locationName, cancellationToken);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/checkNameAvailability
        /// Operation Id: Workspace_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityWorkspaceAsync(this SubscriptionResource subscriptionResource, string locationName, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityWorkspaceAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Quantum/locations/{locationName}/checkNameAvailability
        /// Operation Id: Workspace_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Location. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckNameAvailabilityWorkspace(this SubscriptionResource subscriptionResource, string locationName, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityWorkspace(locationName, content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of QuantumWorkspaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of QuantumWorkspaceResources and their operations over a QuantumWorkspaceResource. </returns>
        public static QuantumWorkspaceCollection GetQuantumWorkspaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetQuantumWorkspaces();
        }

        /// <summary>
        /// Returns the Workspace resource associated with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Quantum/workspaces/{workspaceName}
        /// Operation Id: Workspaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the quantum workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<QuantumWorkspaceResource>> GetQuantumWorkspaceAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetQuantumWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the Workspace resource associated with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Quantum/workspaces/{workspaceName}
        /// Operation Id: Workspaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the quantum workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<QuantumWorkspaceResource> GetQuantumWorkspace(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetQuantumWorkspaces().Get(workspaceName, cancellationToken);
        }

        #region QuantumWorkspaceResource
        /// <summary>
        /// Gets an object representing a <see cref="QuantumWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuantumWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="QuantumWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QuantumWorkspaceResource" /> object. </returns>
        public static QuantumWorkspaceResource GetQuantumWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                QuantumWorkspaceResource.ValidateResourceId(id);
                return new QuantumWorkspaceResource(client, id);
            }
            );
        }
        #endregion
    }
}
