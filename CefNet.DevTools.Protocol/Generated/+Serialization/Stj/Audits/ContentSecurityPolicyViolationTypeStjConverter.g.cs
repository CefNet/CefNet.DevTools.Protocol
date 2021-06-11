//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class ContentSecurityPolicyViolationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType>
    {
        public override CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "kEvalViolation" => CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType.KEvalViolation,
                "kInlineViolation" => CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType.KInlineViolation,
                "kTrustedTypesPolicyViolation" => CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType.KTrustedTypesPolicyViolation,
                "kTrustedTypesSinkViolation" => CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType.KTrustedTypesSinkViolation,
                "kURLViolation" => CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType.KURLViolation,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.ContentSecurityPolicyViolationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
