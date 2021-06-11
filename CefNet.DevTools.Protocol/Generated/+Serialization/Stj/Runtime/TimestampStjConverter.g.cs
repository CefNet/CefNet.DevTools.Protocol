//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class TimestampStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.Timestamp>
    {
        public override CefNet.DevTools.Protocol.Runtime.Timestamp Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetDouble(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.Runtime.Timestamp(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.Timestamp value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
