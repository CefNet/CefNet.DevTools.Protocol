//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class WindowIDStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.WindowID>
    {
        public override CefNet.DevTools.Protocol.Browser.WindowID Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.Browser.WindowID(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.WindowID value, 
            JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.GetUnderlyingValue());
        }
    }
}
