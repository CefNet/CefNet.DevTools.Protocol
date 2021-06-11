//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CertificateTransparencyComplianceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance>
    {
        public override CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "compliant" => CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance.Compliant,
                "not-compliant" => CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance.NotCompliant,
                "unknown" => CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance.Unknown,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CertificateTransparencyCompliance value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
