//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Security
{
    internal sealed class MixedContentTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Security.MixedContentType>
    {
        public override CefNet.DevTools.Protocol.Security.MixedContentType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "blockable" => CefNet.DevTools.Protocol.Security.MixedContentType.Blockable,
                "none" => CefNet.DevTools.Protocol.Security.MixedContentType.None,
                "optionally-blockable" => CefNet.DevTools.Protocol.Security.MixedContentType.OptionallyBlockable,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Security.MixedContentType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
