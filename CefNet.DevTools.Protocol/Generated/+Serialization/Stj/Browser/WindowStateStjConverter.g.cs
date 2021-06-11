//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class WindowStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.WindowState>
    {
        public override CefNet.DevTools.Protocol.Browser.WindowState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "fullscreen" => CefNet.DevTools.Protocol.Browser.WindowState.Fullscreen,
                "maximized" => CefNet.DevTools.Protocol.Browser.WindowState.Maximized,
                "minimized" => CefNet.DevTools.Protocol.Browser.WindowState.Minimized,
                "normal" => CefNet.DevTools.Protocol.Browser.WindowState.Normal,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.WindowState value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Browser.WindowState.Fullscreen => "fullscreen",
                CefNet.DevTools.Protocol.Browser.WindowState.Maximized => "maximized",
                CefNet.DevTools.Protocol.Browser.WindowState.Minimized => "minimized",
                CefNet.DevTools.Protocol.Browser.WindowState.Normal => "normal",
                _ => throw new NotSupportedException("WindowState" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
