// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/onlineBanking.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCOnlineBankingClient.Protos {
  /// <summary>
  /// The online banking  service definition.
  /// </summary>
  public static partial class OnlineBanking
  {
    static readonly string __ServiceName = "onlineBanking.OnlineBanking";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest> __Marshaller_onlineBanking_CreateCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse> __Marshaller_onlineBanking_CreateCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest> __Marshaller_onlineBanking_ReadCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse> __Marshaller_onlineBanking_ReadCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest> __Marshaller_onlineBanking_GetAllCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse> __Marshaller_onlineBanking_GetAllCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest> __Marshaller_onlineBanking_UpdateCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse> __Marshaller_onlineBanking_UpdateCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest> __Marshaller_onlineBanking_DeleteCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse> __Marshaller_onlineBanking_DeleteCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest, global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse> __Method_CreateCustomer = new grpc::Method<global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest, global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCustomer",
        __Marshaller_onlineBanking_CreateCustomerRequest,
        __Marshaller_onlineBanking_CreateCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest, global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse> __Method_ReadCustomer = new grpc::Method<global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest, global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadCustomer",
        __Marshaller_onlineBanking_ReadCustomerRequest,
        __Marshaller_onlineBanking_ReadCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest, global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse> __Method_GetAllCustomers = new grpc::Method<global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest, global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllCustomers",
        __Marshaller_onlineBanking_GetAllCustomerRequest,
        __Marshaller_onlineBanking_GetAllCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest, global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse> __Method_UpdateCustomer = new grpc::Method<global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest, global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCustomer",
        __Marshaller_onlineBanking_UpdateCustomerRequest,
        __Marshaller_onlineBanking_UpdateCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest, global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse> __Method_DeleteCustomer = new grpc::Method<global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest, global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCustomer",
        __Marshaller_onlineBanking_DeleteCustomerRequest,
        __Marshaller_onlineBanking_DeleteCustomerResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCOnlineBankingClient.Protos.OnlineBankingReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OnlineBanking</summary>
    public partial class OnlineBankingClient : grpc::ClientBase<OnlineBankingClient>
    {
      /// <summary>Creates a new client for OnlineBanking</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OnlineBankingClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OnlineBanking that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OnlineBankingClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OnlineBankingClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OnlineBankingClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse CreateCustomer(global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse CreateCustomer(global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateCustomer, null, options, request);
      }
      /// <summary>
      /// Create
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse> CreateCustomerAsync(global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.CreateCustomerResponse> CreateCustomerAsync(global::gRPCOnlineBankingClient.Protos.CreateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateCustomer, null, options, request);
      }
      /// <summary>
      /// Read single
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse ReadCustomer(global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Read single
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse ReadCustomer(global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadCustomer, null, options, request);
      }
      /// <summary>
      /// Read single
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse> ReadCustomerAsync(global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Read single
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.ReadCustomerResponse> ReadCustomerAsync(global::gRPCOnlineBankingClient.Protos.ReadCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadCustomer, null, options, request);
      }
      /// <summary>
      /// Read list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse GetAllCustomers(global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllCustomers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Read list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse GetAllCustomers(global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllCustomers, null, options, request);
      }
      /// <summary>
      /// Read list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse> GetAllCustomersAsync(global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllCustomersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Read list
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.GetAllCustomerResponse> GetAllCustomersAsync(global::gRPCOnlineBankingClient.Protos.GetAllCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllCustomers, null, options, request);
      }
      /// <summary>
      /// Update
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse UpdateCustomer(global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse UpdateCustomer(global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateCustomer, null, options, request);
      }
      /// <summary>
      /// Update
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse> UpdateCustomerAsync(global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.UpdateCustomerResponse> UpdateCustomerAsync(global::gRPCOnlineBankingClient.Protos.UpdateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateCustomer, null, options, request);
      }
      /// <summary>
      /// Delete
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse DeleteCustomer(global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse DeleteCustomer(global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      /// <summary>
      /// Delete
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse> DeleteCustomerAsync(global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::gRPCOnlineBankingClient.Protos.DeleteCustomerResponse> DeleteCustomerAsync(global::gRPCOnlineBankingClient.Protos.DeleteCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override OnlineBankingClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OnlineBankingClient(configuration);
      }
    }

  }
}
#endregion
