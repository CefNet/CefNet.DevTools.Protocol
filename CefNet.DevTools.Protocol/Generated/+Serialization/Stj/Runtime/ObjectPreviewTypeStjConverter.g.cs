//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class ObjectPreviewTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.ObjectPreviewType>
    {
        public override CefNet.DevTools.Protocol.Runtime.ObjectPreviewType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "bigint" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Bigint,
                "boolean" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Boolean,
                "function" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Function,
                "number" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Number,
                "object" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Object,
                "string" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.String,
                "symbol" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Symbol,
                "undefined" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewType.Undefined,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.ObjectPreviewType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
