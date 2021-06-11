//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class TwaQualityEnforcementViolationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType>
    {
        public override CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "kDigitalAssetLinks" => CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType.KDigitalAssetLinks,
                "kHttpError" => CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType.KHttpError,
                "kUnavailableOffline" => CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType.KUnavailableOffline,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
