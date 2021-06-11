//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.IO
{
    internal sealed class StreamHandleStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.IO.StreamHandle>
    {
        public override CefNet.DevTools.Protocol.IO.StreamHandle Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.IO.StreamHandle(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.IO.StreamHandle value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
