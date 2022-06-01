// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/license_service.proto
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
  /// The LicenseService allows clients to query the currently installed license on robot.
  /// </summary>
  public static partial class LicenseService
  {
    static readonly string __ServiceName = "bosdyn.api.LicenseService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLicenseInfoRequest> __Marshaller_bosdyn_api_GetLicenseInfoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLicenseInfoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetLicenseInfoResponse> __Marshaller_bosdyn_api_GetLicenseInfoResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetLicenseInfoResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetFeatureEnabledRequest> __Marshaller_bosdyn_api_GetFeatureEnabledRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetFeatureEnabledRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.GetFeatureEnabledResponse> __Marshaller_bosdyn_api_GetFeatureEnabledResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.GetFeatureEnabledResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.GetLicenseInfoRequest, global::Bosdyn.Api.GetLicenseInfoResponse> __Method_GetLicenseInfo = new grpc::Method<global::Bosdyn.Api.GetLicenseInfoRequest, global::Bosdyn.Api.GetLicenseInfoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLicenseInfo",
        __Marshaller_bosdyn_api_GetLicenseInfoRequest,
        __Marshaller_bosdyn_api_GetLicenseInfoResponse);

    static readonly grpc::Method<global::Bosdyn.Api.GetFeatureEnabledRequest, global::Bosdyn.Api.GetFeatureEnabledResponse> __Method_GetFeatureEnabled = new grpc::Method<global::Bosdyn.Api.GetFeatureEnabledRequest, global::Bosdyn.Api.GetFeatureEnabledResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeatureEnabled",
        __Marshaller_bosdyn_api_GetFeatureEnabledRequest,
        __Marshaller_bosdyn_api_GetFeatureEnabledResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.LicenseServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LicenseService</summary>
    [grpc::BindServiceMethod(typeof(LicenseService), "BindService")]
    public abstract partial class LicenseServiceBase
    {
      /// <summary>
      /// Get information, such as the license number, dates of validity, and features for the license
      /// currently uploaded on the robot.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.GetLicenseInfoResponse> GetLicenseInfo(global::Bosdyn.Api.GetLicenseInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Check if specific features (identified by string names) are enabled under the currently loaded
      /// license for this robot.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.GetFeatureEnabledResponse> GetFeatureEnabled(global::Bosdyn.Api.GetFeatureEnabledRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LicenseService</summary>
    public partial class LicenseServiceClient : grpc::ClientBase<LicenseServiceClient>
    {
      /// <summary>Creates a new client for LicenseService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LicenseServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LicenseService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LicenseServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LicenseServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LicenseServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get information, such as the license number, dates of validity, and features for the license
      /// currently uploaded on the robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLicenseInfoResponse GetLicenseInfo(global::Bosdyn.Api.GetLicenseInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLicenseInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get information, such as the license number, dates of validity, and features for the license
      /// currently uploaded on the robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetLicenseInfoResponse GetLicenseInfo(global::Bosdyn.Api.GetLicenseInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLicenseInfo, null, options, request);
      }
      /// <summary>
      /// Get information, such as the license number, dates of validity, and features for the license
      /// currently uploaded on the robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLicenseInfoResponse> GetLicenseInfoAsync(global::Bosdyn.Api.GetLicenseInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLicenseInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get information, such as the license number, dates of validity, and features for the license
      /// currently uploaded on the robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetLicenseInfoResponse> GetLicenseInfoAsync(global::Bosdyn.Api.GetLicenseInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLicenseInfo, null, options, request);
      }
      /// <summary>
      /// Check if specific features (identified by string names) are enabled under the currently loaded
      /// license for this robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetFeatureEnabledResponse GetFeatureEnabled(global::Bosdyn.Api.GetFeatureEnabledRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeatureEnabled(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check if specific features (identified by string names) are enabled under the currently loaded
      /// license for this robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Bosdyn.Api.GetFeatureEnabledResponse GetFeatureEnabled(global::Bosdyn.Api.GetFeatureEnabledRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeatureEnabled, null, options, request);
      }
      /// <summary>
      /// Check if specific features (identified by string names) are enabled under the currently loaded
      /// license for this robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetFeatureEnabledResponse> GetFeatureEnabledAsync(global::Bosdyn.Api.GetFeatureEnabledRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeatureEnabledAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check if specific features (identified by string names) are enabled under the currently loaded
      /// license for this robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.GetFeatureEnabledResponse> GetFeatureEnabledAsync(global::Bosdyn.Api.GetFeatureEnabledRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeatureEnabled, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LicenseServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LicenseServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LicenseServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetLicenseInfo, serviceImpl.GetLicenseInfo)
          .AddMethod(__Method_GetFeatureEnabled, serviceImpl.GetFeatureEnabled).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LicenseServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetLicenseInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.GetLicenseInfoRequest, global::Bosdyn.Api.GetLicenseInfoResponse>(serviceImpl.GetLicenseInfo));
      serviceBinder.AddMethod(__Method_GetFeatureEnabled, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.GetFeatureEnabledRequest, global::Bosdyn.Api.GetFeatureEnabledResponse>(serviceImpl.GetFeatureEnabled));
    }

  }
}
#endregion
