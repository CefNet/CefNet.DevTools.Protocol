//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class HeavyAdReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.HeavyAdReason>
    {
        public override CefNet.DevTools.Protocol.Audits.HeavyAdReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CpuPeakLimit" => CefNet.DevTools.Protocol.Audits.HeavyAdReason.CpuPeakLimit,
                "CpuTotalLimit" => CefNet.DevTools.Protocol.Audits.HeavyAdReason.CpuTotalLimit,
                "NetworkTotalLimit" => CefNet.DevTools.Protocol.Audits.HeavyAdReason.NetworkTotalLimit,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.HeavyAdReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
