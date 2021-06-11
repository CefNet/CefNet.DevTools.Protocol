//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class RemoteObjectTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.RemoteObjectType>
    {
        public override CefNet.DevTools.Protocol.Runtime.RemoteObjectType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "bigint" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Bigint,
                "boolean" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Boolean,
                "function" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Function,
                "number" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Number,
                "object" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Object,
                "string" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.String,
                "symbol" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Symbol,
                "undefined" => CefNet.DevTools.Protocol.Runtime.RemoteObjectType.Undefined,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.RemoteObjectType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
