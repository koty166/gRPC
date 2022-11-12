// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Billing {
  public static partial class Billing
  {
    static readonly string __ServiceName = "billing.Billing";

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
    static readonly grpc::Marshaller<global::Billing.None> __Marshaller_billing_None = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.None.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Billing.UserProfile> __Marshaller_billing_UserProfile = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.UserProfile.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Billing.EmissionAmount> __Marshaller_billing_EmissionAmount = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.EmissionAmount.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Billing.Response> __Marshaller_billing_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.Response.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Billing.MoveCoinsTransaction> __Marshaller_billing_MoveCoinsTransaction = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.MoveCoinsTransaction.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Billing.Coin> __Marshaller_billing_Coin = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Billing.Coin.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Billing.None, global::Billing.UserProfile> __Method_ListUsers = new grpc::Method<global::Billing.None, global::Billing.UserProfile>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListUsers",
        __Marshaller_billing_None,
        __Marshaller_billing_UserProfile);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Billing.EmissionAmount, global::Billing.Response> __Method_CoinsEmission = new grpc::Method<global::Billing.EmissionAmount, global::Billing.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CoinsEmission",
        __Marshaller_billing_EmissionAmount,
        __Marshaller_billing_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Billing.MoveCoinsTransaction, global::Billing.Response> __Method_MoveCoins = new grpc::Method<global::Billing.MoveCoinsTransaction, global::Billing.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MoveCoins",
        __Marshaller_billing_MoveCoinsTransaction,
        __Marshaller_billing_Response);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Billing.None, global::Billing.Coin> __Method_LongestHistoryCoin = new grpc::Method<global::Billing.None, global::Billing.Coin>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LongestHistoryCoin",
        __Marshaller_billing_None,
        __Marshaller_billing_Coin);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Billing.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Billing</summary>
    [grpc::BindServiceMethod(typeof(Billing), "BindService")]
    public abstract partial class BillingBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListUsers(global::Billing.None request, grpc::IServerStreamWriter<global::Billing.UserProfile> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Billing.Response> CoinsEmission(global::Billing.EmissionAmount request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Billing.Response> MoveCoins(global::Billing.MoveCoinsTransaction request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Billing.Coin> LongestHistoryCoin(global::Billing.None request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BillingBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListUsers, serviceImpl.ListUsers)
          .AddMethod(__Method_CoinsEmission, serviceImpl.CoinsEmission)
          .AddMethod(__Method_MoveCoins, serviceImpl.MoveCoins)
          .AddMethod(__Method_LongestHistoryCoin, serviceImpl.LongestHistoryCoin).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BillingBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListUsers, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Billing.None, global::Billing.UserProfile>(serviceImpl.ListUsers));
      serviceBinder.AddMethod(__Method_CoinsEmission, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Billing.EmissionAmount, global::Billing.Response>(serviceImpl.CoinsEmission));
      serviceBinder.AddMethod(__Method_MoveCoins, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Billing.MoveCoinsTransaction, global::Billing.Response>(serviceImpl.MoveCoins));
      serviceBinder.AddMethod(__Method_LongestHistoryCoin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Billing.None, global::Billing.Coin>(serviceImpl.LongestHistoryCoin));
    }

  }
}
#endregion