//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class HeavyAdResolutionStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus>
    {
        public override CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "HeavyAdBlocked" => CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus.HeavyAdBlocked,
                "HeavyAdWarning" => CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus.HeavyAdWarning,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.HeavyAdResolutionStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
