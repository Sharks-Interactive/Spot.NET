// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/local_grid_service.proto
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
  /// The map service provides access multiple kinds of cell-based map data.
  /// It supports querying for the list of available types of local grids provided by the service,
  /// and supports requesting a set of the latest local grids by map type name.
  /// </summary>
  public static partial class LocalGridService
  {
    static readonly string __ServiceName = "bosdyn.api.LocalGridService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLocalGridTypesRequest> __Marshaller_bosdyn_api_GetLocalGridTypesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLocalGridTypesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLocalGridTypesResponse> __Marshaller_bosdyn_api_GetLocalGridTypesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLocalGridTypesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLocalGridsRequest> __Marshaller_bosdyn_api_GetLocalGridsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLocalGridsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLocalGridsResponse> __Marshaller_bosdyn_api_GetLocalGridsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLocalGridsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.GetLocalGridTypesRequest, global::Bosdyn.Api.GetLocalGridTypesResponse> __Method_GetLocalGridTypes = new grpc::Method<global::Bosdyn.Api.GetLocalGridTypesRequest, global::Bosdyn.Api.GetLocalGridTypesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLocalGridTypes",
        __Marshaller_bosdyn_api_GetLocalGridTypesRequest,
        __Marshaller_bosdyn_api_GetLocalGridTypesResponse);

    static readonly grpc::Method<global::Bosdyn.Api.GetLocalGridsRequest, global::Bosdyn.Api.GetLocalGridsResponse> __Method_GetLocalGrids = new grpc::Method<global::Bosdyn.Api.GetLocalGridsRequest, global::Bosdyn.Api.GetLocalGridsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLocalGrids",
        __Marshaller_bosdyn_api_GetLocalGridsRequest,
        __Marshaller_bosdyn_api_GetLocalGridsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.LocalGridServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LocalGridService</summary>
    [grpc::BindServiceMethod(typeof(LocalGridService), "BindService")]
    public abstract partial class LocalGridServiceBase
    {
      /// <summary>
      /// Obtain the list of available map types.
      /// The name field keys access to individual local grids when calling GetLocalGrids.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.GetLocalGridTypesResponse> GetLocalGridTypes(global::Bosdyn.Api.GetLocalGridTypesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Request a set of local grids by type name.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.GetLocalGridsResponse> GetLocalGrids(global::Bosdyn.Api.GetLocalGridsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LocalGridService</summary>
    public partial class LocalGridServiceClient : grpc::ClientBase<LocalGridServiceClient>
    {
      /// <summary>Creates a new client for LocalGridService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LocalGridServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LocalGridService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LocalGridServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LocalGridServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LocalGridServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Obtain the list of available map types.
      /// The name field keys access to individual local grids when calling GetLocalGrids.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLocalGridTypesResponse GetLocalGridTypes(global::Bosdyn.Api.GetLocalGridTypesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocalGridTypes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Obtain the list of available map types.
      /// The name field keys access to individual local grids when calling GetLocalGrids.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLocalGridTypesResponse GetLocalGridTypes(global::Bosdyn.Api.GetLocalGridTypesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLocalGridTypes, null, options, request);
      }
      /// <summary>
      /// Obtain the list of available map types.
      /// The name field keys access to individual local grids when calling GetLocalGrids.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLocalGridTypesResponse> GetLocalGridTypesAsync(global::Bosdyn.Api.GetLocalGridTypesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocalGridTypesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Obtain the list of available map types.
      /// The name field keys access to individual local grids when calling GetLocalGrids.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLocalGridTypesResponse> GetLocalGridTypesAsync(global::Bosdyn.Api.GetLocalGridTypesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLocalGridTypes, null, options, request);
      }
      /// <summary>
      /// Request a set of local grids by type name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLocalGridsResponse GetLocalGrids(global::Bosdyn.Api.GetLocalGridsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocalGrids(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request a set of local grids by type name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLocalGridsResponse GetLocalGrids(global::Bosdyn.Api.GetLocalGridsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLocalGrids, null, options, request);
      }
      /// <summary>
      /// Request a set of local grids by type name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLocalGridsResponse> GetLocalGridsAsync(global::Bosdyn.Api.GetLocalGridsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocalGridsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request a set of local grids by type name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLocalGridsResponse> GetLocalGridsAsync(global::Bosdyn.Api.GetLocalGridsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLocalGrids, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LocalGridServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LocalGridServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LocalGridServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetLocalGridTypes, serviceImpl.GetLocalGridTypes)
          .AddMethod(__Method_GetLocalGrids, serviceImpl.GetLocalGrids).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LocalGridServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetLocalGridTypes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.GetLocalGridTypesRequest, global::Bosdyn.Api.GetLocalGridTypesResponse>(serviceImpl.GetLocalGridTypes));
      serviceBinder.AddMethod(__Method_GetLocalGrids, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.GetLocalGridsRequest, global::Bosdyn.Api.GetLocalGridsResponse>(serviceImpl.GetLocalGrids));
    }

  }
}
#endregion
