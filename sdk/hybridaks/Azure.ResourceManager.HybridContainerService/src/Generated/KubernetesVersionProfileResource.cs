// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A Class representing a KubernetesVersionProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="KubernetesVersionProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetKubernetesVersionProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetKubernetesVersionProfile method.
    /// </summary>
    public partial class KubernetesVersionProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="KubernetesVersionProfileResource"/> instance. </summary>
        /// <param name="customLocationResourceUri"> The customLocationResourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string customLocationResourceUri)
        {
            var resourceId = $"{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _kubernetesVersionProfileClientDiagnostics;
        private readonly HybridContainerServiceRestOperations _kubernetesVersionProfileRestClient;
        private readonly KubernetesVersionProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridContainerService/kubernetesVersions";

        /// <summary> Initializes a new instance of the <see cref="KubernetesVersionProfileResource"/> class for mocking. </summary>
        protected KubernetesVersionProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KubernetesVersionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal KubernetesVersionProfileResource(ArmClient client, KubernetesVersionProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="KubernetesVersionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KubernetesVersionProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kubernetesVersionProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string kubernetesVersionProfileApiVersion);
            _kubernetesVersionProfileRestClient = new HybridContainerServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kubernetesVersionProfileApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual KubernetesVersionProfileData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Lists the supported kubernetes versions for the specified custom location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KubernetesVersionProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _kubernetesVersionProfileRestClient.GetKubernetesVersionsAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesVersionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the supported kubernetes versions for the specified custom location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KubernetesVersionProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.Get");
            scope.Start();
            try
            {
                var response = _kubernetesVersionProfileRestClient.GetKubernetesVersions(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesVersionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the default kubernetes versions resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeleteKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.Delete");
            scope.Start();
            try
            {
                var response = await _kubernetesVersionProfileRestClient.DeleteKubernetesVersionsAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation(_kubernetesVersionProfileClientDiagnostics, Pipeline, _kubernetesVersionProfileRestClient.CreateDeleteKubernetesVersionsRequest(Id.Parent).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the default kubernetes versions resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeleteKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.Delete");
            scope.Start();
            try
            {
                var response = _kubernetesVersionProfileRestClient.DeleteKubernetesVersions(Id.Parent, cancellationToken);
                var operation = new HybridContainerServiceArmOperation(_kubernetesVersionProfileClientDiagnostics, Pipeline, _kubernetesVersionProfileRestClient.CreateDeleteKubernetesVersionsRequest(Id.Parent).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Puts the default kubernetes version resource type (one time operation, before listing the kubernetes versions)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PutKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Kubernetes Versions resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KubernetesVersionProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, KubernetesVersionProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kubernetesVersionProfileRestClient.PutKubernetesVersionsAsync(Id.Parent, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<KubernetesVersionProfileResource>(new KubernetesVersionProfileOperationSource(Client), _kubernetesVersionProfileClientDiagnostics, Pipeline, _kubernetesVersionProfileRestClient.CreatePutKubernetesVersionsRequest(Id.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Puts the default kubernetes version resource type (one time operation, before listing the kubernetes versions)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/kubernetesVersions/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PutKubernetesVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesVersionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Kubernetes Versions resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KubernetesVersionProfileResource> CreateOrUpdate(WaitUntil waitUntil, KubernetesVersionProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubernetesVersionProfileClientDiagnostics.CreateScope("KubernetesVersionProfileResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kubernetesVersionProfileRestClient.PutKubernetesVersions(Id.Parent, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<KubernetesVersionProfileResource>(new KubernetesVersionProfileOperationSource(Client), _kubernetesVersionProfileClientDiagnostics, Pipeline, _kubernetesVersionProfileRestClient.CreatePutKubernetesVersionsRequest(Id.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
