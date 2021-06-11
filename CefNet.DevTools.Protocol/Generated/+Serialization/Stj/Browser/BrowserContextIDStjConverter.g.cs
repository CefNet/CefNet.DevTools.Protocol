//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class BrowserContextIDStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.BrowserContextID>
    {
        public override CefNet.DevTools.Protocol.Browser.BrowserContextID Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.Browser.BrowserContextID(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.BrowserContextID value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
