//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Security
{
    internal sealed class CertificateIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Security.CertificateId>
    {
        public override CefNet.DevTools.Protocol.Security.CertificateId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.Security.CertificateId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Security.CertificateId value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
