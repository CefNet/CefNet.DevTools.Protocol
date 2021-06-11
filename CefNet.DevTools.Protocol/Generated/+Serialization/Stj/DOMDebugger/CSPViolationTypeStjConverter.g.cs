//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    internal sealed class CSPViolationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOMDebugger.CSPViolationType>
    {
        public override CefNet.DevTools.Protocol.DOMDebugger.CSPViolationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOMDebugger.CSPViolationType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.DOMDebugger.CSPViolationType.TrustedtypePolicyViolation => "trustedtype-policy-violation",
                CefNet.DevTools.Protocol.DOMDebugger.CSPViolationType.TrustedtypeSinkViolation => "trustedtype-sink-violation",
                _ => throw new NotSupportedException("CSPViolationType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
