//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Accessibility
{
    internal sealed class AXValueNativeSourceTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType>
    {
        public override CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "figcaption" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Figcaption,
                "label" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Label,
                "labelfor" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Labelfor,
                "labelwrapped" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Labelwrapped,
                "legend" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Legend,
                "other" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Other,
                "rubyannotation" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Rubyannotation,
                "tablecaption" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Tablecaption,
                "title" => CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType.Title,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Accessibility.AXValueNativeSourceType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
