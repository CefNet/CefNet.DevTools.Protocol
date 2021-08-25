//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class InspectorIssueCodeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.InspectorIssueCode>
    {
        public override CefNet.DevTools.Protocol.Audits.InspectorIssueCode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "AttributionReportingIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.AttributionReportingIssue,
                "BlockedByResponseIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.BlockedByResponseIssue,
                "ContentSecurityPolicyIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.ContentSecurityPolicyIssue,
                "CorsIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.CorsIssue,
                "HeavyAdIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.HeavyAdIssue,
                "LowTextContrastIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.LowTextContrastIssue,
                "MixedContentIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.MixedContentIssue,
                "NavigatorUserAgentIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.NavigatorUserAgentIssue,
                "QuirksModeIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.QuirksModeIssue,
                "SameSiteCookieIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.SameSiteCookieIssue,
                "SharedArrayBufferIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.SharedArrayBufferIssue,
                "TrustedWebActivityIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.TrustedWebActivityIssue,
                "WasmCrossOriginModuleSharingIssue" => CefNet.DevTools.Protocol.Audits.InspectorIssueCode.WasmCrossOriginModuleSharingIssue,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.InspectorIssueCode value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
