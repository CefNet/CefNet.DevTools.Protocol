//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class AttributionReportingIssueTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType>
    {
        public override CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "AttributionSourceUntrustworthyOrigin" => CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType.AttributionSourceUntrustworthyOrigin,
                "AttributionUntrustworthyOrigin" => CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType.AttributionUntrustworthyOrigin,
                "InvalidAttributionData" => CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType.InvalidAttributionData,
                "InvalidAttributionSourceEventId" => CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType.InvalidAttributionSourceEventId,
                "PermissionPolicyDisabled" => CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType.PermissionPolicyDisabled,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.AttributionReportingIssueType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
