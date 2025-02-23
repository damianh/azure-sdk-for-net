// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.FluidRelay;

namespace Azure.ResourceManager.FluidRelay.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableFluidRelaySubscriptionResource : ArmResource
    {
        private ClientDiagnostics _fluidRelayServerClientDiagnostics;
        private FluidRelayServersRestOperations _fluidRelayServerRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableFluidRelaySubscriptionResource"/> class for mocking. </summary>
        protected MockableFluidRelaySubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableFluidRelaySubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableFluidRelaySubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FluidRelayServerClientDiagnostics => _fluidRelayServerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.FluidRelay", FluidRelayServerResource.ResourceType.Namespace, Diagnostics);
        private FluidRelayServersRestOperations FluidRelayServerRestClient => _fluidRelayServerRestClient ??= new FluidRelayServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FluidRelayServerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all Fluid Relay servers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.FluidRelay/fluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FluidRelayServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FluidRelayServerResource> GetFluidRelayServersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FluidRelayServerRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FluidRelayServerRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FluidRelayServerResource(Client, FluidRelayServerData.DeserializeFluidRelayServerData(e)), FluidRelayServerClientDiagnostics, Pipeline, "MockableFluidRelaySubscriptionResource.GetFluidRelayServers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Fluid Relay servers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.FluidRelay/fluidRelayServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluidRelayServers_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FluidRelayServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FluidRelayServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FluidRelayServerResource> GetFluidRelayServers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FluidRelayServerRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FluidRelayServerRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FluidRelayServerResource(Client, FluidRelayServerData.DeserializeFluidRelayServerData(e)), FluidRelayServerClientDiagnostics, Pipeline, "MockableFluidRelaySubscriptionResource.GetFluidRelayServers", "value", "nextLink", cancellationToken);
        }
    }
}
