//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Media
{
    internal sealed class PlayerMessageLevelStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Media.PlayerMessageLevel>
    {
        public override CefNet.DevTools.Protocol.Media.PlayerMessageLevel Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "debug" => CefNet.DevTools.Protocol.Media.PlayerMessageLevel.Debug,
                "error" => CefNet.DevTools.Protocol.Media.PlayerMessageLevel.Error,
                "info" => CefNet.DevTools.Protocol.Media.PlayerMessageLevel.Info,
                "warning" => CefNet.DevTools.Protocol.Media.PlayerMessageLevel.Warning,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Media.PlayerMessageLevel value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
