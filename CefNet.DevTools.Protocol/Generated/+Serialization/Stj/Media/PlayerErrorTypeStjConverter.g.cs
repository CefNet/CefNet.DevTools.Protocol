//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Media
{
    internal sealed class PlayerErrorTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Media.PlayerErrorType>
    {
        public override CefNet.DevTools.Protocol.Media.PlayerErrorType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "media_error" => CefNet.DevTools.Protocol.Media.PlayerErrorType.Media_error,
                "pipeline_error" => CefNet.DevTools.Protocol.Media.PlayerErrorType.Pipeline_error,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Media.PlayerErrorType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
