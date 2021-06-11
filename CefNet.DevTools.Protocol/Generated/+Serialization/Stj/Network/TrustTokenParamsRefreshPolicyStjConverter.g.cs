//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class TrustTokenParamsRefreshPolicyStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy>
    {
        public override CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Refresh" => CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy.Refresh,
                "UseCached" => CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy.UseCached,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.TrustTokenParamsRefreshPolicy value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
