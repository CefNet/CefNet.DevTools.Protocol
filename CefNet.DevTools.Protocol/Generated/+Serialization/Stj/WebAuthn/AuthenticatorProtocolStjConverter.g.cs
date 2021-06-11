//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAuthn
{
    internal sealed class AuthenticatorProtocolStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol>
    {
        public override CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol.Ctap2 => "ctap2",
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol.U2f => "u2f",
                _ => throw new NotSupportedException("AuthenticatorProtocol" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
