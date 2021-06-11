//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Memory
{
    internal sealed class PressureLevelStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Memory.PressureLevel>
    {
        public override CefNet.DevTools.Protocol.Memory.PressureLevel Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Memory.PressureLevel value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Memory.PressureLevel.Critical => "critical",
                CefNet.DevTools.Protocol.Memory.PressureLevel.Moderate => "moderate",
                _ => throw new NotSupportedException("PressureLevel" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
