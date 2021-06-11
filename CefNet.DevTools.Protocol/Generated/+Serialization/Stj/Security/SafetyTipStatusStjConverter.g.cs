//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Security
{
    internal sealed class SafetyTipStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Security.SafetyTipStatus>
    {
        public override CefNet.DevTools.Protocol.Security.SafetyTipStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "badReputation" => CefNet.DevTools.Protocol.Security.SafetyTipStatus.BadReputation,
                "lookalike" => CefNet.DevTools.Protocol.Security.SafetyTipStatus.Lookalike,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Security.SafetyTipStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
