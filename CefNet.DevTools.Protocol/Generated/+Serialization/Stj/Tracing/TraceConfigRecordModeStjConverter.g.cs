//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class TraceConfigRecordModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode>
    {
        public override CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode.EchoToConsole => "echoToConsole",
                CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode.RecordAsMuchAsPossible => "recordAsMuchAsPossible",
                CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode.RecordContinuously => "recordContinuously",
                CefNet.DevTools.Protocol.Tracing.TraceConfigRecordMode.RecordUntilFull => "recordUntilFull",
                _ => throw new NotSupportedException("TraceConfigRecordMode" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
