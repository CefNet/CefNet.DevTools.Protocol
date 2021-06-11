//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOM
{
    internal sealed class CompatibilityModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOM.CompatibilityMode>
    {
        public override CefNet.DevTools.Protocol.DOM.CompatibilityMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "LimitedQuirksMode" => CefNet.DevTools.Protocol.DOM.CompatibilityMode.LimitedQuirksMode,
                "NoQuirksMode" => CefNet.DevTools.Protocol.DOM.CompatibilityMode.NoQuirksMode,
                "QuirksMode" => CefNet.DevTools.Protocol.DOM.CompatibilityMode.QuirksMode,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOM.CompatibilityMode value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
