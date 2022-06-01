// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/directory_registration_service.proto
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
  /// DirectoryRegistrationService is a private class that lets services be
  /// discovered by clients by adding them to a discovery database.  Services
  /// can live on robot, payload, or other accessible cloud-based locations.
  /// Each service is responsible for registering itself with this service.
  /// </summary>
  public static partial class DirectoryRegistrationService
  {
    static readonly string __ServiceName = "bosdyn.api.DirectoryRegistrationService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.RegisterServiceRequest> __Marshaller_bosdyn_api_RegisterServiceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.RegisterServiceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.RegisterServiceResponse> __Marshaller_bosdyn_api_RegisterServiceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.RegisterServiceResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.UnregisterServiceRequest> __Marshaller_bosdyn_api_UnregisterServiceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.UnregisterServiceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.UnregisterServiceResponse> __Marshaller_bosdyn_api_UnregisterServiceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.UnregisterServiceResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.UpdateServiceRequest> __Marshaller_bosdyn_api_UpdateServiceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.UpdateServiceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.UpdateServiceResponse> __Marshaller_bosdyn_api_UpdateServiceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.UpdateServiceResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.RegisterServiceRequest, global::Bosdyn.Api.RegisterServiceResponse> __Method_RegisterService = new grpc::Method<global::Bosdyn.Api.RegisterServiceRequest, global::Bosdyn.Api.RegisterServiceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterService",
        __Marshaller_bosdyn_api_RegisterServiceRequest,
        __Marshaller_bosdyn_api_RegisterServiceResponse);

    static readonly grpc::Method<global::Bosdyn.Api.UnregisterServiceRequest, global::Bosdyn.Api.UnregisterServiceResponse> __Method_UnregisterService = new grpc::Method<global::Bosdyn.Api.UnregisterServiceRequest, global::Bosdyn.Api.UnregisterServiceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnregisterService",
        __Marshaller_bosdyn_api_UnregisterServiceRequest,
        __Marshaller_bosdyn_api_UnregisterServiceResponse);

    static readonly grpc::Method<global::Bosdyn.Api.UpdateServiceRequest, global::Bosdyn.Api.UpdateServiceResponse> __Method_UpdateService = new grpc::Method<global::Bosdyn.Api.UpdateServiceRequest, global::Bosdyn.Api.UpdateServiceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateService",
        __Marshaller_bosdyn_api_UpdateServiceRequest,
        __Marshaller_bosdyn_api_UpdateServiceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.DirectoryRegistrationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DirectoryRegistrationService</summary>
    [grpc::BindServiceMethod(typeof(DirectoryRegistrationService), "BindService")]
    public abstract partial class DirectoryRegistrationServiceBase
    {
      /// <summary>
      /// Called by a producer to register as a provider with the application.  Returns the
      /// record for that provider.  Requires unique name and correctly filled out service
      /// record in request.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.RegisterServiceResponse> RegisterService(global::Bosdyn.Api.RegisterServiceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Called by a producer to remove its registration from the DirectoryManager.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.UnregisterServiceResponse> UnregisterService(global::Bosdyn.Api.UnregisterServiceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update the ServiceEntry for a producer on the server.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.UpdateServiceResponse> UpdateService(global::Bosdyn.Api.UpdateServiceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DirectoryRegistrationService</summary>
    public partial class DirectoryRegistrationServiceClient : grpc::ClientBase<DirectoryRegistrationServiceClient>
    {
      /// <summary>Creates a new client for DirectoryRegistrationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DirectoryRegistrationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DirectoryRegistrationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DirectoryRegistrationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DirectoryRegistrationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DirectoryRegistrationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Called by a producer to register as a provider with the application.  Returns the
      /// record for that provider.  Requires unique name and correctly filled out service
      /// record in request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.RegisterServiceResponse RegisterService(global::Bosdyn.Api.RegisterServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterService(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Called by a producer to register as a provider with the application.  Returns the
      /// record for that provider.  Requires unique name and correctly filled out service
      /// record in request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.RegisterServiceResponse RegisterService(global::Bosdyn.Api.RegisterServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterService, null, options, request);
      }
      /// <summary>
      /// Called by a producer to register as a provider with the application.  Returns the
      /// record for that provider.  Requires unique name and correctly filled out service
      /// record in request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.RegisterServiceResponse> RegisterServiceAsync(global::Bosdyn.Api.RegisterServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterServiceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Called by a producer to register as a provider with the application.  Returns the
      /// record for that provider.  Requires unique name and correctly filled out service
      /// record in request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.RegisterServiceResponse> RegisterServiceAsync(global::Bosdyn.Api.RegisterServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterService, null, options, request);
      }
      /// <summary>
      /// Called by a producer to remove its registration from the DirectoryManager.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.UnregisterServiceResponse UnregisterService(global::Bosdyn.Api.UnregisterServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnregisterService(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Called by a producer to remove its registration from the DirectoryManager.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.UnregisterServiceResponse UnregisterService(global::Bosdyn.Api.UnregisterServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UnregisterService, null, options, request);
      }
      /// <summary>
      /// Called by a producer to remove its registration from the DirectoryManager.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.UnregisterServiceResponse> UnregisterServiceAsync(global::Bosdyn.Api.UnregisterServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnregisterServiceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Called by a producer to remove its registration from the DirectoryManager.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.UnregisterServiceResponse> UnregisterServiceAsync(global::Bosdyn.Api.UnregisterServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UnregisterService, null, options, request);
      }
      /// <summary>
      /// Update the ServiceEntry for a producer on the server.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.UpdateServiceResponse UpdateService(global::Bosdyn.Api.UpdateServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateService(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update the ServiceEntry for a producer on the server.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.UpdateServiceResponse UpdateService(global::Bosdyn.Api.UpdateServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateService, null, options, request);
      }
      /// <summary>
      /// Update the ServiceEntry for a producer on the server.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.UpdateServiceResponse> UpdateServiceAsync(global::Bosdyn.Api.UpdateServiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateServiceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update the ServiceEntry for a producer on the server.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.UpdateServiceResponse> UpdateServiceAsync(global::Bosdyn.Api.UpdateServiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateService, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DirectoryRegistrationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DirectoryRegistrationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DirectoryRegistrationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterService, serviceImpl.RegisterService)
          .AddMethod(__Method_UnregisterService, serviceImpl.UnregisterService)
          .AddMethod(__Method_UpdateService, serviceImpl.UpdateService).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DirectoryRegistrationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterService, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.RegisterServiceRequest, global::Bosdyn.Api.RegisterServiceResponse>(serviceImpl.RegisterService));
      serviceBinder.AddMethod(__Method_UnregisterService, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.UnregisterServiceRequest, global::Bosdyn.Api.UnregisterServiceResponse>(serviceImpl.UnregisterService));
      serviceBinder.AddMethod(__Method_UpdateService, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.UpdateServiceRequest, global::Bosdyn.Api.UpdateServiceResponse>(serviceImpl.UpdateService));
    }

  }
}
#endregion
