//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class InitiatorTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.InitiatorType>
    {
        public override CefNet.DevTools.Protocol.Network.InitiatorType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "other" => CefNet.DevTools.Protocol.Network.InitiatorType.Other,
                "parser" => CefNet.DevTools.Protocol.Network.InitiatorType.Parser,
                "preflight" => CefNet.DevTools.Protocol.Network.InitiatorType.Preflight,
                "preload" => CefNet.DevTools.Protocol.Network.InitiatorType.Preload,
                "script" => CefNet.DevTools.Protocol.Network.InitiatorType.Script,
                "SignedExchange" => CefNet.DevTools.Protocol.Network.InitiatorType.SignedExchange,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.InitiatorType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
