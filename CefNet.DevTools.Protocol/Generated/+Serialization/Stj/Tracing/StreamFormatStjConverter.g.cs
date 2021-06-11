//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class StreamFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.StreamFormat>
    {
        public override CefNet.DevTools.Protocol.Tracing.StreamFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "json" => CefNet.DevTools.Protocol.Tracing.StreamFormat.Json,
                "proto" => CefNet.DevTools.Protocol.Tracing.StreamFormat.Proto,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.StreamFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.StreamFormat.Json => "json",
                CefNet.DevTools.Protocol.Tracing.StreamFormat.Proto => "proto",
                _ => throw new NotSupportedException("StreamFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
