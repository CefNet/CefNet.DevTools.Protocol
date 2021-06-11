//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class TracingBackendStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.TracingBackend>
    {
        public override CefNet.DevTools.Protocol.Tracing.TracingBackend Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.TracingBackend value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.TracingBackend.Auto => "auto",
                CefNet.DevTools.Protocol.Tracing.TracingBackend.Chrome => "chrome",
                CefNet.DevTools.Protocol.Tracing.TracingBackend.System => "system",
                _ => throw new NotSupportedException("TracingBackend" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
