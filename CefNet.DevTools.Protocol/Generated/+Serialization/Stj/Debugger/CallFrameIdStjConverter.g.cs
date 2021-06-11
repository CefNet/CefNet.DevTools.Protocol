//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class CallFrameIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.CallFrameId>
    {
        public override CefNet.DevTools.Protocol.Debugger.CallFrameId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.Debugger.CallFrameId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.CallFrameId value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
