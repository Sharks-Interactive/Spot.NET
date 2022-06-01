// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/network_compute_bridge_service.proto
// </auto-generated>
// Original file comments:
// Copyright (c) 2021 Boston Dynamics, Inc.  All rights reserved.
//
// Downloading, reproducing, distributing or otherwise using the SDK Software
// is subject to the terms and conditions of the Boston Dynamics Software
// Development Kit License (20191101-BDSDK-SL).
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Bosdyn.Api {
  /// <summary>
  /// RPCs for sending images or other data to networked server for computation.
  /// </summary>
  public static partial class NetworkComputeBridge
  {
    static readonly string __ServiceName = "bosdyn.api.NetworkComputeBridge";

    static readonly grpc::Marshaller<global::Bosdyn.Api.NetworkComputeRequest> __Marshaller_bosdyn_api_NetworkComputeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.NetworkComputeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.NetworkComputeResponse> __Marshaller_bosdyn_api_NetworkComputeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.NetworkComputeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListAvailableModelsRequest> __Marshaller_bosdyn_api_ListAvailableModelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListAvailableModelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListAvailableModelsResponse> __Marshaller_bosdyn_api_ListAvailableModelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListAvailableModelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse> __Method_NetworkCompute = new grpc::Method<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NetworkCompute",
        __Marshaller_bosdyn_api_NetworkComputeRequest,
        __Marshaller_bosdyn_api_NetworkComputeResponse);

    static readonly grpc::Method<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse> __Method_ListAvailableModels = new grpc::Method<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAvailableModels",
        __Marshaller_bosdyn_api_ListAvailableModelsRequest,
        __Marshaller_bosdyn_api_ListAvailableModelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.NetworkComputeBridgeServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NetworkComputeBridge</summary>
    [grpc::BindServiceMethod(typeof(NetworkComputeBridge), "BindService")]
    public abstract partial class NetworkComputeBridgeBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.NetworkComputeResponse> NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NetworkComputeBridge</summary>
    public partial class NetworkComputeBridgeClient : grpc::ClientBase<NetworkComputeBridgeClient>
    {
      /// <summary>Creates a new client for NetworkComputeBridge</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NetworkComputeBridgeClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NetworkComputeBridge that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NetworkComputeBridgeClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NetworkComputeBridgeClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NetworkComputeBridgeClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Bosdyn.Api.NetworkComputeResponse NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NetworkCompute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.NetworkComputeResponse NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NetworkCompute, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.NetworkComputeResponse> NetworkComputeAsync(global::Bosdyn.Api.NetworkComputeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NetworkComputeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.NetworkComputeResponse> NetworkComputeAsync(global::Bosdyn.Api.NetworkComputeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NetworkCompute, null, options, request);
      }
      public virtual global::Bosdyn.Api.ListAvailableModelsResponse ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAvailableModels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.ListAvailableModelsResponse ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAvailableModels, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModelsAsync(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAvailableModelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModelsAsync(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAvailableModels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NetworkComputeBridgeClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NetworkComputeBridgeClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NetworkComputeBridgeBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_NetworkCompute, serviceImpl.NetworkCompute)
          .AddMethod(__Method_ListAvailableModels, serviceImpl.ListAvailableModels).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NetworkComputeBridgeBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_NetworkCompute, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse>(serviceImpl.NetworkCompute));
      serviceBinder.AddMethod(__Method_ListAvailableModels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse>(serviceImpl.ListAvailableModels));
    }

  }
  /// <summary>
  /// Set of RPCs for workers of the network compute bridge.  This is seperate from the RPCs for the
  /// on-robot network compute bridge so that if they need to diverge in the future it is possible
  /// to do so.
  /// </summary>
  public static partial class NetworkComputeBridgeWorker
  {
    static readonly string __ServiceName = "bosdyn.api.NetworkComputeBridgeWorker";

    static readonly grpc::Marshaller<global::Bosdyn.Api.NetworkComputeRequest> __Marshaller_bosdyn_api_NetworkComputeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.NetworkComputeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.NetworkComputeResponse> __Marshaller_bosdyn_api_NetworkComputeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.NetworkComputeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListAvailableModelsRequest> __Marshaller_bosdyn_api_ListAvailableModelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListAvailableModelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListAvailableModelsResponse> __Marshaller_bosdyn_api_ListAvailableModelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListAvailableModelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse> __Method_NetworkCompute = new grpc::Method<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NetworkCompute",
        __Marshaller_bosdyn_api_NetworkComputeRequest,
        __Marshaller_bosdyn_api_NetworkComputeResponse);

    static readonly grpc::Method<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse> __Method_ListAvailableModels = new grpc::Method<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAvailableModels",
        __Marshaller_bosdyn_api_ListAvailableModelsRequest,
        __Marshaller_bosdyn_api_ListAvailableModelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.NetworkComputeBridgeServiceReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of NetworkComputeBridgeWorker</summary>
    [grpc::BindServiceMethod(typeof(NetworkComputeBridgeWorker), "BindService")]
    public abstract partial class NetworkComputeBridgeWorkerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.NetworkComputeResponse> NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NetworkComputeBridgeWorker</summary>
    public partial class NetworkComputeBridgeWorkerClient : grpc::ClientBase<NetworkComputeBridgeWorkerClient>
    {
      /// <summary>Creates a new client for NetworkComputeBridgeWorker</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NetworkComputeBridgeWorkerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NetworkComputeBridgeWorker that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NetworkComputeBridgeWorkerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NetworkComputeBridgeWorkerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NetworkComputeBridgeWorkerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Bosdyn.Api.NetworkComputeResponse NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NetworkCompute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.NetworkComputeResponse NetworkCompute(global::Bosdyn.Api.NetworkComputeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NetworkCompute, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.NetworkComputeResponse> NetworkComputeAsync(global::Bosdyn.Api.NetworkComputeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NetworkComputeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.NetworkComputeResponse> NetworkComputeAsync(global::Bosdyn.Api.NetworkComputeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NetworkCompute, null, options, request);
      }
      public virtual global::Bosdyn.Api.ListAvailableModelsResponse ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAvailableModels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.ListAvailableModelsResponse ListAvailableModels(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAvailableModels, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModelsAsync(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAvailableModelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListAvailableModelsResponse> ListAvailableModelsAsync(global::Bosdyn.Api.ListAvailableModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAvailableModels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NetworkComputeBridgeWorkerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NetworkComputeBridgeWorkerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NetworkComputeBridgeWorkerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_NetworkCompute, serviceImpl.NetworkCompute)
          .AddMethod(__Method_ListAvailableModels, serviceImpl.ListAvailableModels).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NetworkComputeBridgeWorkerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_NetworkCompute, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.NetworkComputeRequest, global::Bosdyn.Api.NetworkComputeResponse>(serviceImpl.NetworkCompute));
      serviceBinder.AddMethod(__Method_ListAvailableModels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.ListAvailableModelsRequest, global::Bosdyn.Api.ListAvailableModelsResponse>(serviceImpl.ListAvailableModels));
    }

  }
}
#endregion
