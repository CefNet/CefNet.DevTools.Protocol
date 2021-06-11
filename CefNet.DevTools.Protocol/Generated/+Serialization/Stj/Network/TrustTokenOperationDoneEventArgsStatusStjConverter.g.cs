//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class TrustTokenOperationDoneEventArgsStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus>
    {
        public override CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "AlreadyExists" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.AlreadyExists,
                "BadResponse" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.BadResponse,
                "FailedPrecondition" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.FailedPrecondition,
                "FulfilledLocally" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.FulfilledLocally,
                "InternalError" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.InternalError,
                "InvalidArgument" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.InvalidArgument,
                "Ok" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.Ok,
                "ResourceExhausted" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.ResourceExhausted,
                "Unavailable" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.Unavailable,
                "UnknownError" => CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus.UnknownError,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgsStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
