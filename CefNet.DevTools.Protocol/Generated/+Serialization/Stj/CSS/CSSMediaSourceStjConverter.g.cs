//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.CSS
{
    internal sealed class CSSMediaSourceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.CSS.CSSMediaSource>
    {
        public override CefNet.DevTools.Protocol.CSS.CSSMediaSource Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "importRule" => CefNet.DevTools.Protocol.CSS.CSSMediaSource.ImportRule,
                "inlineSheet" => CefNet.DevTools.Protocol.CSS.CSSMediaSource.InlineSheet,
                "linkedSheet" => CefNet.DevTools.Protocol.CSS.CSSMediaSource.LinkedSheet,
                "mediaRule" => CefNet.DevTools.Protocol.CSS.CSSMediaSource.MediaRule,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.CSS.CSSMediaSource value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
