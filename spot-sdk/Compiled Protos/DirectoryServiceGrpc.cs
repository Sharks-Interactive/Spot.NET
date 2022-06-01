// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/directory_service.proto
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
  /// DirectoryService lets clients discover which API services are available on a robot.
  /// </summary>
  public static partial class DirectoryService
  {
    static readonly string __ServiceName = "bosdyn.api.DirectoryService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.GetServiceEntryRequest> __Marshaller_bosdyn_api_GetServiceEntryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetServiceEntryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetServiceEntryResponse> __Marshaller_bosdyn_api_GetServiceEntryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetServiceEntryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListServiceEntriesRequest> __Marshaller_bosdyn_api_ListServiceEntriesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListServiceEntriesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ListServiceEntriesResponse> __Marshaller_bosdyn_api_ListServiceEntriesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ListServiceEntriesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.GetServiceEntryRequest, global::Bosdyn.Api.GetServiceEntryResponse> __Method_GetServiceEntry = new grpc::Method<global::Bosdyn.Api.GetServiceEntryRequest, global::Bosdyn.Api.GetServiceEntryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetServiceEntry",
        __Marshaller_bosdyn_api_GetServiceEntryRequest,
        __Marshaller_bosdyn_api_GetServiceEntryResponse);

    static readonly grpc::Method<global::Bosdyn.Api.ListServiceEntriesRequest, global::Bosdyn.Api.ListServiceEntriesResponse> __Method_ListServiceEntries = new grpc::Method<global::Bosdyn.Api.ListServiceEntriesRequest, global::Bosdyn.Api.ListServiceEntriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListServiceEntries",
        __Marshaller_bosdyn_api_ListServiceEntriesRequest,
        __Marshaller_bosdyn_api_ListServiceEntriesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.DirectoryServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DirectoryService</summary>
    [grpc::BindServiceMethod(typeof(DirectoryService), "BindService")]
    public abstract partial class DirectoryServiceBase
    {
      /// <summary>
      /// Get information about a specific service.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.GetServiceEntryResponse> GetServiceEntry(global::Bosdyn.Api.GetServiceEntryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// List all known services at time of call.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.ListServiceEntriesResponse> ListServiceEntries(global::Bosdyn.Api.ListServiceEntriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DirectoryService</summary>
    public partial class DirectoryServiceClient : grpc::ClientBase<DirectoryServiceClient>
    {
      /// <summary>Creates a new client for DirectoryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DirectoryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DirectoryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DirectoryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DirectoryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DirectoryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get information about a specific service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetServiceEntryResponse GetServiceEntry(global::Bosdyn.Api.GetServiceEntryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServiceEntry(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get information about a specific service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetServiceEntryResponse GetServiceEntry(global::Bosdyn.Api.GetServiceEntryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetServiceEntry, null, options, request);
      }
      /// <summary>
      /// Get information about a specific service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetServiceEntryResponse> GetServiceEntryAsync(global::Bosdyn.Api.GetServiceEntryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServiceEntryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get information about a specific service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetServiceEntryResponse> GetServiceEntryAsync(global::Bosdyn.Api.GetServiceEntryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetServiceEntry, null, options, request);
      }
      /// <summary>
      /// List all known services at time of call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.ListServiceEntriesResponse ListServiceEntries(global::Bosdyn.Api.ListServiceEntriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListServiceEntries(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List all known services at time of call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.ListServiceEntriesResponse ListServiceEntries(global::Bosdyn.Api.ListServiceEntriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListServiceEntries, null, options, request);
      }
      /// <summary>
      /// List all known services at time of call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListServiceEntriesResponse> ListServiceEntriesAsync(global::Bosdyn.Api.ListServiceEntriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListServiceEntriesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List all known services at time of call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ListServiceEntriesResponse> ListServiceEntriesAsync(global::Bosdyn.Api.ListServiceEntriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListServiceEntries, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DirectoryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DirectoryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DirectoryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetServiceEntry, serviceImpl.GetServiceEntry)
          .AddMethod(__Method_ListServiceEntries, serviceImpl.ListServiceEntries).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DirectoryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetServiceEntry, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.GetServiceEntryRequest, global::Bosdyn.Api.GetServiceEntryResponse>(serviceImpl.GetServiceEntry));
      serviceBinder.AddMethod(__Method_ListServiceEntries, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.ListServiceEntriesRequest, global::Bosdyn.Api.ListServiceEntriesResponse>(serviceImpl.ListServiceEntries));
    }

  }
}
#endregion
