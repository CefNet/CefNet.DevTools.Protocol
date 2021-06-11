//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class ChannelInterpretationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation>
    {
        public override CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "discrete" => CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation.Discrete,
                "speakers" => CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation.Speakers,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
