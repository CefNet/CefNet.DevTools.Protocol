//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.CSS
{
    internal sealed class StyleSheetOriginStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.CSS.StyleSheetOrigin>
    {
        public override CefNet.DevTools.Protocol.CSS.StyleSheetOrigin Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "injected" => CefNet.DevTools.Protocol.CSS.StyleSheetOrigin.Injected,
                "inspector" => CefNet.DevTools.Protocol.CSS.StyleSheetOrigin.Inspector,
                "regular" => CefNet.DevTools.Protocol.CSS.StyleSheetOrigin.Regular,
                "user-agent" => CefNet.DevTools.Protocol.CSS.StyleSheetOrigin.UserAgent,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.CSS.StyleSheetOrigin value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
