// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/door_service.proto
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

namespace Bosdyn.Api.Spot {
  public static partial class DoorService
  {
    static readonly string __ServiceName = "bosdyn.api.spot.DoorService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.Spot.OpenDoorCommandRequest> __Marshaller_bosdyn_api_spot_OpenDoorCommandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.Spot.OpenDoorCommandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.Spot.OpenDoorCommandResponse> __Marshaller_bosdyn_api_spot_OpenDoorCommandResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.Spot.OpenDoorCommandResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest> __Marshaller_bosdyn_api_spot_OpenDoorFeedbackRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse> __Marshaller_bosdyn_api_spot_OpenDoorFeedbackResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.Spot.OpenDoorCommandRequest, global::Bosdyn.Api.Spot.OpenDoorCommandResponse> __Method_OpenDoor = new grpc::Method<global::Bosdyn.Api.Spot.OpenDoorCommandRequest, global::Bosdyn.Api.Spot.OpenDoorCommandResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OpenDoor",
        __Marshaller_bosdyn_api_spot_OpenDoorCommandRequest,
        __Marshaller_bosdyn_api_spot_OpenDoorCommandResponse);

    static readonly grpc::Method<global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest, global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse> __Method_OpenDoorFeedback = new grpc::Method<global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest, global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OpenDoorFeedback",
        __Marshaller_bosdyn_api_spot_OpenDoorFeedbackRequest,
        __Marshaller_bosdyn_api_spot_OpenDoorFeedbackResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.Spot.DoorServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DoorService</summary>
    [grpc::BindServiceMethod(typeof(DoorService), "BindService")]
    public abstract partial class DoorServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.Spot.OpenDoorCommandResponse> OpenDoor(global::Bosdyn.Api.Spot.OpenDoorCommandRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse> OpenDoorFeedback(global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DoorService</summary>
    public partial class DoorServiceClient : grpc::ClientBase<DoorServiceClient>
    {
      /// <summary>Creates a new client for DoorService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DoorServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DoorService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DoorServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DoorServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DoorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Bosdyn.Api.Spot.OpenDoorCommandResponse OpenDoor(global::Bosdyn.Api.Spot.OpenDoorCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OpenDoor(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.Spot.OpenDoorCommandResponse OpenDoor(global::Bosdyn.Api.Spot.OpenDoorCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OpenDoor, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.Spot.OpenDoorCommandResponse> OpenDoorAsync(global::Bosdyn.Api.Spot.OpenDoorCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OpenDoorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.Spot.OpenDoorCommandResponse> OpenDoorAsync(global::Bosdyn.Api.Spot.OpenDoorCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OpenDoor, null, options, request);
      }
      public virtual global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse OpenDoorFeedback(global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OpenDoorFeedback(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse OpenDoorFeedback(global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OpenDoorFeedback, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse> OpenDoorFeedbackAsync(global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OpenDoorFeedbackAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse> OpenDoorFeedbackAsync(global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OpenDoorFeedback, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DoorServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DoorServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DoorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OpenDoor, serviceImpl.OpenDoor)
          .AddMethod(__Method_OpenDoorFeedback, serviceImpl.OpenDoorFeedback).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DoorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OpenDoor, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.Spot.OpenDoorCommandRequest, global::Bosdyn.Api.Spot.OpenDoorCommandResponse>(serviceImpl.OpenDoor));
      serviceBinder.AddMethod(__Method_OpenDoorFeedback, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.Spot.OpenDoorFeedbackRequest, global::Bosdyn.Api.Spot.OpenDoorFeedbackResponse>(serviceImpl.OpenDoorFeedback));
    }

  }
}
#endregion
