//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class ChannelCountModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.ChannelCountMode>
    {
        public override CefNet.DevTools.Protocol.WebAudio.ChannelCountMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "clamped-max" => CefNet.DevTools.Protocol.WebAudio.ChannelCountMode.ClampedMax,
                "explicit" => CefNet.DevTools.Protocol.WebAudio.ChannelCountMode.Explicit,
                "max" => CefNet.DevTools.Protocol.WebAudio.ChannelCountMode.Max,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.ChannelCountMode value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
