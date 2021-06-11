//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class TrustTokenOperationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.TrustTokenOperationType>
    {
        public override CefNet.DevTools.Protocol.Network.TrustTokenOperationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Issuance" => CefNet.DevTools.Protocol.Network.TrustTokenOperationType.Issuance,
                "Redemption" => CefNet.DevTools.Protocol.Network.TrustTokenOperationType.Redemption,
                "Signing" => CefNet.DevTools.Protocol.Network.TrustTokenOperationType.Signing,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.TrustTokenOperationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
