//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAuthn
{
    internal sealed class Ctap2VersionStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAuthn.Ctap2Version>
    {
        public override CefNet.DevTools.Protocol.WebAuthn.Ctap2Version Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAuthn.Ctap2Version value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.WebAuthn.Ctap2Version.Ctap2_0 => "ctap2_0",
                CefNet.DevTools.Protocol.WebAuthn.Ctap2Version.Ctap2_1 => "ctap2_1",
                _ => throw new NotSupportedException("Ctap2Version" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
