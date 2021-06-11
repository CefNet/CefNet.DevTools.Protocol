//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class AutomationRateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.AutomationRate>
    {
        public override CefNet.DevTools.Protocol.WebAudio.AutomationRate Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "a-rate" => CefNet.DevTools.Protocol.WebAudio.AutomationRate.ARate,
                "k-rate" => CefNet.DevTools.Protocol.WebAudio.AutomationRate.KRate,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.AutomationRate value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
