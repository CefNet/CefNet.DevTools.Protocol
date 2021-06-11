//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Overlay
{
    internal sealed class ColorFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Overlay.ColorFormat>
    {
        public override CefNet.DevTools.Protocol.Overlay.ColorFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Overlay.ColorFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Overlay.ColorFormat.Hex => "hex",
                CefNet.DevTools.Protocol.Overlay.ColorFormat.Hsl => "hsl",
                CefNet.DevTools.Protocol.Overlay.ColorFormat.Rgb => "rgb",
                _ => throw new NotSupportedException("ColorFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
