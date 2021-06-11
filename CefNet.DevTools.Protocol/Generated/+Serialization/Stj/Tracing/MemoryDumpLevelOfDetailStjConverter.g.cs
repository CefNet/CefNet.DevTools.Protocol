//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Tracing
{
    internal sealed class MemoryDumpLevelOfDetailStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail>
    {
        public override CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail.Background => "background",
                CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail.Detailed => "detailed",
                CefNet.DevTools.Protocol.Tracing.MemoryDumpLevelOfDetail.Light => "light",
                _ => throw new NotSupportedException("MemoryDumpLevelOfDetail" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
