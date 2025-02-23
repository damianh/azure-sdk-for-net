// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Communication;
using Azure.ResourceManager.Communication.Models;

namespace Azure.ResourceManager.Communication.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableCommunicationSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _communicationServiceResourceCommunicationServicesClientDiagnostics;
        private CommunicationServicesRestOperations _communicationServiceResourceCommunicationServicesRestClient;
        private ClientDiagnostics _emailServiceResourceEmailServicesClientDiagnostics;
        private EmailServicesRestOperations _emailServiceResourceEmailServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableCommunicationSubscriptionResource"/> class for mocking. </summary>
        protected MockableCommunicationSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCommunicationSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCommunicationSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CommunicationServiceResourceCommunicationServicesClientDiagnostics => _communicationServiceResourceCommunicationServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Communication", CommunicationServiceResource.ResourceType.Namespace, Diagnostics);
        private CommunicationServicesRestOperations CommunicationServiceResourceCommunicationServicesRestClient => _communicationServiceResourceCommunicationServicesRestClient ??= new CommunicationServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CommunicationServiceResource.ResourceType));
        private ClientDiagnostics EmailServiceResourceEmailServicesClientDiagnostics => _emailServiceResourceEmailServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Communication", EmailServiceResource.ResourceType.Namespace, Diagnostics);
        private EmailServicesRestOperations EmailServiceResourceEmailServicesRestClient => _emailServiceResourceEmailServicesRestClient ??= new EmailServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EmailServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunicationServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CommunicationNameAvailabilityResult>> CheckCommunicationNameAvailabilityAsync(CommunicationServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CommunicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("MockableCommunicationSubscriptionResource.CheckCommunicationNameAvailability");
            scope.Start();
            try
            {
                var response = await CommunicationServiceResourceCommunicationServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the CommunicationService name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunicationServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CommunicationNameAvailabilityResult> CheckCommunicationNameAvailability(CommunicationServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = CommunicationServiceResourceCommunicationServicesClientDiagnostics.CreateScope("MockableCommunicationSubscriptionResource.CheckCommunicationNameAvailability");
            scope.Start();
            try
            {
                var response = CommunicationServiceResourceCommunicationServicesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunicationServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommunicationServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommunicationServiceResource> GetCommunicationServiceResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CommunicationServiceResourceCommunicationServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CommunicationServiceResourceCommunicationServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CommunicationServiceResource(Client, CommunicationServiceResourceData.DeserializeCommunicationServiceResourceData(e)), CommunicationServiceResourceCommunicationServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetCommunicationServiceResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/communicationServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommunicationServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommunicationServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommunicationServiceResource> GetCommunicationServiceResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CommunicationServiceResourceCommunicationServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CommunicationServiceResourceCommunicationServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CommunicationServiceResource(Client, CommunicationServiceResourceData.DeserializeCommunicationServiceResourceData(e)), CommunicationServiceResourceCommunicationServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetCommunicationServiceResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EmailServiceResource> GetEmailServiceResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EmailServiceResourceEmailServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EmailServiceResourceEmailServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EmailServiceResource(Client, EmailServiceResourceData.DeserializeEmailServiceResourceData(e)), EmailServiceResourceEmailServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetEmailServiceResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/emailServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EmailServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EmailServiceResource> GetEmailServiceResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EmailServiceResourceEmailServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EmailServiceResourceEmailServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EmailServiceResource(Client, EmailServiceResourceData.DeserializeEmailServiceResourceData(e)), EmailServiceResourceEmailServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetEmailServiceResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of domains that are fully verified in Exchange Online.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/listVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<string> GetVerifiedExchangeOnlineDomainsEmailServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EmailServiceResourceEmailServicesRestClient.CreateListVerifiedExchangeOnlineDomainsRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => e.GetString(), EmailServiceResourceEmailServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetVerifiedExchangeOnlineDomainsEmailServices", "", null, cancellationToken);
        }

        /// <summary>
        /// Get a list of domains that are fully verified in Exchange Online.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Communication/listVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailServices_ListVerifiedExchangeOnlineDomains</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EmailServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="string"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<string> GetVerifiedExchangeOnlineDomainsEmailServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EmailServiceResourceEmailServicesRestClient.CreateListVerifiedExchangeOnlineDomainsRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => e.GetString(), EmailServiceResourceEmailServicesClientDiagnostics, Pipeline, "MockableCommunicationSubscriptionResource.GetVerifiedExchangeOnlineDomainsEmailServices", "", null, cancellationToken);
        }
    }
}
