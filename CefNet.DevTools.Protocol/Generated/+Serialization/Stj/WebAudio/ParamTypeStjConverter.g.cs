//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class ParamTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.ParamType>
    {
        public override CefNet.DevTools.Protocol.WebAudio.ParamType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.WebAudio.ParamType(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.ParamType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
