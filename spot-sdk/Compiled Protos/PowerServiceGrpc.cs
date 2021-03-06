// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/power_service.proto
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
  /// The power service for the robot that can power on/off the robot's motors.
  /// </summary>
  public static partial class PowerService
  {
    static readonly string __ServiceName = "bosdyn.api.PowerService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.PowerCommandRequest> __Marshaller_bosdyn_api_PowerCommandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.PowerCommandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.PowerCommandResponse> __Marshaller_bosdyn_api_PowerCommandResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.PowerCommandResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.PowerCommandFeedbackRequest> __Marshaller_bosdyn_api_PowerCommandFeedbackRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.PowerCommandFeedbackRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.PowerCommandFeedbackResponse> __Marshaller_bosdyn_api_PowerCommandFeedbackResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.PowerCommandFeedbackResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.PowerCommandRequest, global::Bosdyn.Api.PowerCommandResponse> __Method_PowerCommand = new grpc::Method<global::Bosdyn.Api.PowerCommandRequest, global::Bosdyn.Api.PowerCommandResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PowerCommand",
        __Marshaller_bosdyn_api_PowerCommandRequest,
        __Marshaller_bosdyn_api_PowerCommandResponse);

    static readonly grpc::Method<global::Bosdyn.Api.PowerCommandFeedbackRequest, global::Bosdyn.Api.PowerCommandFeedbackResponse> __Method_PowerCommandFeedback = new grpc::Method<global::Bosdyn.Api.PowerCommandFeedbackRequest, global::Bosdyn.Api.PowerCommandFeedbackResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PowerCommandFeedback",
        __Marshaller_bosdyn_api_PowerCommandFeedbackRequest,
        __Marshaller_bosdyn_api_PowerCommandFeedbackResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.PowerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PowerService</summary>
    [grpc::BindServiceMethod(typeof(PowerService), "BindService")]
    public abstract partial class PowerServiceBase
    {
      /// <summary>
      /// Starts a power command on the robot. A robot can only accept one power command at once.
      /// Power commands, are not interruptible. Once a command is issued, it must complete before
      /// another command can be issued.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.PowerCommandResponse> PowerCommand(global::Bosdyn.Api.PowerCommandRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Check the status of a power command.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.PowerCommandFeedbackResponse> PowerCommandFeedback(global::Bosdyn.Api.PowerCommandFeedbackRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PowerService</summary>
    public partial class PowerServiceClient : grpc::ClientBase<PowerServiceClient>
    {
      /// <summary>Creates a new client for PowerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PowerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PowerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PowerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PowerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PowerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Starts a power command on the robot. A robot can only accept one power command at once.
      /// Power commands, are not interruptible. Once a command is issued, it must complete before
      /// another command can be issued.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.PowerCommandResponse PowerCommand(global::Bosdyn.Api.PowerCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PowerCommand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Starts a power command on the robot. A robot can only accept one power command at once.
      /// Power commands, are not interruptible. Once a command is issued, it must complete before
      /// another command can be issued.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.PowerCommandResponse PowerCommand(global::Bosdyn.Api.PowerCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PowerCommand, null, options, request);
      }
      /// <summary>
      /// Starts a power command on the robot. A robot can only accept one power command at once.
      /// Power commands, are not interruptible. Once a command is issued, it must complete before
      /// another command can be issued.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.PowerCommandResponse> PowerCommandAsync(global::Bosdyn.Api.PowerCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PowerCommandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Starts a power command on the robot. A robot can only accept one power command at once.
      /// Power commands, are not interruptible. Once a command is issued, it must complete before
      /// another command can be issued.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.PowerCommandResponse> PowerCommandAsync(global::Bosdyn.Api.PowerCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PowerCommand, null, options, request);
      }
      /// <summary>
      /// Check the status of a power command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.PowerCommandFeedbackResponse PowerCommandFeedback(global::Bosdyn.Api.PowerCommandFeedbackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PowerCommandFeedback(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check the status of a power command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.PowerCommandFeedbackResponse PowerCommandFeedback(global::Bosdyn.Api.PowerCommandFeedbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PowerCommandFeedback, null, options, request);
      }
      /// <summary>
      /// Check the status of a power command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.PowerCommandFeedbackResponse> PowerCommandFeedbackAsync(global::Bosdyn.Api.PowerCommandFeedbackRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PowerCommandFeedbackAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check the status of a power command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.PowerCommandFeedbackResponse> PowerCommandFeedbackAsync(global::Bosdyn.Api.PowerCommandFeedbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PowerCommandFeedback, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PowerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PowerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PowerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PowerCommand, serviceImpl.PowerCommand)
          .AddMethod(__Method_PowerCommandFeedback, serviceImpl.PowerCommandFeedback).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PowerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PowerCommand, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.PowerCommandRequest, global::Bosdyn.Api.PowerCommandResponse>(serviceImpl.PowerCommand));
      serviceBinder.AddMethod(__Method_PowerCommandFeedback, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.PowerCommandFeedbackRequest, global::Bosdyn.Api.PowerCommandFeedbackResponse>(serviceImpl.PowerCommandFeedback));
    }

  }
}
#endregion
