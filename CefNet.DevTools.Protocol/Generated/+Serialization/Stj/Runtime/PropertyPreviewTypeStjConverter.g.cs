//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class PropertyPreviewTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.PropertyPreviewType>
    {
        public override CefNet.DevTools.Protocol.Runtime.PropertyPreviewType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "accessor" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Accessor,
                "bigint" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Bigint,
                "boolean" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Boolean,
                "function" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Function,
                "number" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Number,
                "object" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Object,
                "string" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.String,
                "symbol" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Symbol,
                "undefined" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewType.Undefined,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.PropertyPreviewType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
