//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class ContextStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.ContextState>
    {
        public override CefNet.DevTools.Protocol.WebAudio.ContextState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "closed" => CefNet.DevTools.Protocol.WebAudio.ContextState.Closed,
                "running" => CefNet.DevTools.Protocol.WebAudio.ContextState.Running,
                "suspended" => CefNet.DevTools.Protocol.WebAudio.ContextState.Suspended,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.ContextState value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
