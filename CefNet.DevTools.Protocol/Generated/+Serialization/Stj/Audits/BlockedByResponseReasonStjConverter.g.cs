//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class BlockedByResponseReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.BlockedByResponseReason>
    {
        public override CefNet.DevTools.Protocol.Audits.BlockedByResponseReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CoepFrameResourceNeedsCoepHeader" => CefNet.DevTools.Protocol.Audits.BlockedByResponseReason.CoepFrameResourceNeedsCoepHeader,
                "CoopSandboxedIFrameCannotNavigateToCoopPage" => CefNet.DevTools.Protocol.Audits.BlockedByResponseReason.CoopSandboxedIFrameCannotNavigateToCoopPage,
                "CorpNotSameOrigin" => CefNet.DevTools.Protocol.Audits.BlockedByResponseReason.CorpNotSameOrigin,
                "CorpNotSameOriginAfterDefaultedToSameOriginByCoep" => CefNet.DevTools.Protocol.Audits.BlockedByResponseReason.CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
                "CorpNotSameSite" => CefNet.DevTools.Protocol.Audits.BlockedByResponseReason.CorpNotSameSite,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.BlockedByResponseReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
