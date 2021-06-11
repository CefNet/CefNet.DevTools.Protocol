//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.SystemInfo
{
    internal sealed class ImageTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.SystemInfo.ImageType>
    {
        public override CefNet.DevTools.Protocol.SystemInfo.ImageType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "jpeg" => CefNet.DevTools.Protocol.SystemInfo.ImageType.Jpeg,
                "unknown" => CefNet.DevTools.Protocol.SystemInfo.ImageType.Unknown,
                "webp" => CefNet.DevTools.Protocol.SystemInfo.ImageType.Webp,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.SystemInfo.ImageType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
