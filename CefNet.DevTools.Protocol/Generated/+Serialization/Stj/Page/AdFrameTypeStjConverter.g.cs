//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class AdFrameTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.AdFrameType>
    {
        public override CefNet.DevTools.Protocol.Page.AdFrameType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "child" => CefNet.DevTools.Protocol.Page.AdFrameType.Child,
                "none" => CefNet.DevTools.Protocol.Page.AdFrameType.None,
                "root" => CefNet.DevTools.Protocol.Page.AdFrameType.Root,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.AdFrameType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
