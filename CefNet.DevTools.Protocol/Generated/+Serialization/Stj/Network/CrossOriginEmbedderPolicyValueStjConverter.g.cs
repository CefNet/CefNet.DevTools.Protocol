//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CrossOriginEmbedderPolicyValueStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue>
    {
        public override CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Credentialless" => CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue.Credentialless,
                "None" => CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue.None,
                "RequireCorp" => CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue.RequireCorp,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CrossOriginEmbedderPolicyValue value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
