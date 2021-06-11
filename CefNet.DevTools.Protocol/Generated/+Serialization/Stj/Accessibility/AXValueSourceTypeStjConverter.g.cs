//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Accessibility
{
    internal sealed class AXValueSourceTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Accessibility.AXValueSourceType>
    {
        public override CefNet.DevTools.Protocol.Accessibility.AXValueSourceType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "attribute" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.Attribute,
                "contents" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.Contents,
                "implicit" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.Implicit,
                "placeholder" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.Placeholder,
                "relatedElement" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.RelatedElement,
                "style" => CefNet.DevTools.Protocol.Accessibility.AXValueSourceType.Style,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Accessibility.AXValueSourceType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
