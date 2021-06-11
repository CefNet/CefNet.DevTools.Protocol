//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Overlay
{
    internal sealed class LineStylePatternStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Overlay.LineStylePattern>
    {
        public override CefNet.DevTools.Protocol.Overlay.LineStylePattern Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Overlay.LineStylePattern value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Overlay.LineStylePattern.Dashed => "dashed",
                CefNet.DevTools.Protocol.Overlay.LineStylePattern.Dotted => "dotted",
                _ => throw new NotSupportedException("LineStylePattern" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
