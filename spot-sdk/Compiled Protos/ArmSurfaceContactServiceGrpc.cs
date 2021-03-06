// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/arm_surface_contact_service.proto
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
  public static partial class ArmSurfaceContactService
  {
    static readonly string __ServiceName = "bosdyn.api.ArmSurfaceContactService";

    static readonly grpc::Marshaller<global::Bosdyn.Api.ArmSurfaceContactCommand> __Marshaller_bosdyn_api_ArmSurfaceContactCommand = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ArmSurfaceContactCommand.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Bosdyn.Api.ArmSurfaceContactResponse> __Marshaller_bosdyn_api_ArmSurfaceContactResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Bosdyn.Api.ArmSurfaceContactResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Bosdyn.Api.ArmSurfaceContactCommand, global::Bosdyn.Api.ArmSurfaceContactResponse> __Method_ArmSurfaceContact = new grpc::Method<global::Bosdyn.Api.ArmSurfaceContactCommand, global::Bosdyn.Api.ArmSurfaceContactResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ArmSurfaceContact",
        __Marshaller_bosdyn_api_ArmSurfaceContactCommand,
        __Marshaller_bosdyn_api_ArmSurfaceContactResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Bosdyn.Api.ArmSurfaceContactServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ArmSurfaceContactService</summary>
    [grpc::BindServiceMethod(typeof(ArmSurfaceContactService), "BindService")]
    public abstract partial class ArmSurfaceContactServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Bosdyn.Api.ArmSurfaceContactResponse> ArmSurfaceContact(global::Bosdyn.Api.ArmSurfaceContactCommand request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ArmSurfaceContactService</summary>
    public partial class ArmSurfaceContactServiceClient : grpc::ClientBase<ArmSurfaceContactServiceClient>
    {
      /// <summary>Creates a new client for ArmSurfaceContactService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ArmSurfaceContactServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ArmSurfaceContactService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ArmSurfaceContactServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ArmSurfaceContactServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ArmSurfaceContactServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Bosdyn.Api.ArmSurfaceContactResponse ArmSurfaceContact(global::Bosdyn.Api.ArmSurfaceContactCommand request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArmSurfaceContact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Bosdyn.Api.ArmSurfaceContactResponse ArmSurfaceContact(global::Bosdyn.Api.ArmSurfaceContactCommand request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ArmSurfaceContact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ArmSurfaceContactResponse> ArmSurfaceContactAsync(global::Bosdyn.Api.ArmSurfaceContactCommand request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ArmSurfaceContactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Bosdyn.Api.ArmSurfaceContactResponse> ArmSurfaceContactAsync(global::Bosdyn.Api.ArmSurfaceContactCommand request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ArmSurfaceContact, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ArmSurfaceContactServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ArmSurfaceContactServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ArmSurfaceContactServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ArmSurfaceContact, serviceImpl.ArmSurfaceContact).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ArmSurfaceContactServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ArmSurfaceContact, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Bosdyn.Api.ArmSurfaceContactCommand, global::Bosdyn.Api.ArmSurfaceContactResponse>(serviceImpl.ArmSurfaceContact));
    }

  }
}
#endregion
