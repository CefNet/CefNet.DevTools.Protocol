//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class StartRequestTransferModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode>
    {
        public override CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode.ReportEvents => "ReportEvents",
                CefNet.DevTools.Protocol.Tracing.StartRequestTransferMode.ReturnAsStream => "ReturnAsStream",
                _ => throw new NotSupportedException("StartRequestTransferMode" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
