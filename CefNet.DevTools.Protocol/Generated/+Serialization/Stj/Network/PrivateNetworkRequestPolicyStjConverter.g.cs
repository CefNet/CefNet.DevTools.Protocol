//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class PrivateNetworkRequestPolicyStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy>
    {
        public override CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Allow" => CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy.Allow,
                "BlockFromInsecureToMorePrivate" => CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy.BlockFromInsecureToMorePrivate,
                "WarnFromInsecureToMorePrivate" => CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy.WarnFromInsecureToMorePrivate,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.PrivateNetworkRequestPolicy value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
