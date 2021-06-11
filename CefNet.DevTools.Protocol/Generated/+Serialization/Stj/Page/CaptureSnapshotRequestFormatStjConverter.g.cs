//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class CaptureSnapshotRequestFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.CaptureSnapshotRequestFormat>
    {
        public override CefNet.DevTools.Protocol.Page.CaptureSnapshotRequestFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.CaptureSnapshotRequestFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.CaptureSnapshotRequestFormat.Mhtml => "mhtml",
                _ => throw new NotSupportedException("CaptureSnapshotRequestFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
