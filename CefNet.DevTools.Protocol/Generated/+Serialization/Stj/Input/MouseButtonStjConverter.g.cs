//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class MouseButtonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.MouseButton>
    {
        public override CefNet.DevTools.Protocol.Input.MouseButton Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.MouseButton value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.MouseButton.Back => "back",
                CefNet.DevTools.Protocol.Input.MouseButton.Forward => "forward",
                CefNet.DevTools.Protocol.Input.MouseButton.Left => "left",
                CefNet.DevTools.Protocol.Input.MouseButton.Middle => "middle",
                CefNet.DevTools.Protocol.Input.MouseButton.None => "none",
                CefNet.DevTools.Protocol.Input.MouseButton.Right => "right",
                _ => throw new NotSupportedException("MouseButton" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
