// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerStreaming.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServerStream {
  public static partial class ServerStreamingService
  {
    static readonly string __ServiceName = "ServerStream.ServerStreamingService";

    static readonly grpc::Marshaller<global::ServerStream.ServerStreamingRequest> __Marshaller_ServerStream_ServerStreamingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServerStream.ServerStreamingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ServerStream.ServerStreamingResponse> __Marshaller_ServerStream_ServerStreamingResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServerStream.ServerStreamingResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ServerStream.ServerStreamingRequest, global::ServerStream.ServerStreamingResponse> __Method_ServerStream = new grpc::Method<global::ServerStream.ServerStreamingRequest, global::ServerStream.ServerStreamingResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ServerStream",
        __Marshaller_ServerStream_ServerStreamingRequest,
        __Marshaller_ServerStream_ServerStreamingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServerStream.ServerStreamingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServerStreamingService</summary>
    [grpc::BindServiceMethod(typeof(ServerStreamingService), "BindService")]
    public abstract partial class ServerStreamingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ServerStream.ServerStreamingResponse> ServerStream(global::ServerStream.ServerStreamingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServerStreamingService</summary>
    public partial class ServerStreamingServiceClient : grpc::ClientBase<ServerStreamingServiceClient>
    {
      /// <summary>Creates a new client for ServerStreamingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServerStreamingServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServerStreamingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServerStreamingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServerStreamingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServerStreamingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ServerStream.ServerStreamingResponse ServerStream(global::ServerStream.ServerStreamingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServerStream.ServerStreamingResponse ServerStream(global::ServerStream.ServerStreamingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ServerStream, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServerStream.ServerStreamingResponse> ServerStreamAsync(global::ServerStream.ServerStreamingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerStreamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServerStream.ServerStreamingResponse> ServerStreamAsync(global::ServerStream.ServerStreamingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ServerStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ServerStreamingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServerStreamingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ServerStreamingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ServerStream, serviceImpl.ServerStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServerStreamingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ServerStream, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerStream.ServerStreamingRequest, global::ServerStream.ServerStreamingResponse>(serviceImpl.ServerStream));
    }

  }
}
#endregion
