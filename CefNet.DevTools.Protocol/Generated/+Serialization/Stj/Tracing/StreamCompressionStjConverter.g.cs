//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class StreamCompressionStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.StreamCompression>
    {
        public override CefNet.DevTools.Protocol.Tracing.StreamCompression Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "gzip" => CefNet.DevTools.Protocol.Tracing.StreamCompression.Gzip,
                "none" => CefNet.DevTools.Protocol.Tracing.StreamCompression.None,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.StreamCompression value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.StreamCompression.Gzip => "gzip",
                CefNet.DevTools.Protocol.Tracing.StreamCompression.None => "none",
                _ => throw new NotSupportedException("StreamCompression" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
