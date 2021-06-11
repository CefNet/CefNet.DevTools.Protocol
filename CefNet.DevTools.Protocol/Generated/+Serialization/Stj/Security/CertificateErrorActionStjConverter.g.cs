//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Security
{
    internal sealed class CertificateErrorActionStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Security.CertificateErrorAction>
    {
        public override CefNet.DevTools.Protocol.Security.CertificateErrorAction Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Security.CertificateErrorAction value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Security.CertificateErrorAction.Cancel => "cancel",
                CefNet.DevTools.Protocol.Security.CertificateErrorAction.Continue => "continue",
                _ => throw new NotSupportedException("CertificateErrorAction" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
