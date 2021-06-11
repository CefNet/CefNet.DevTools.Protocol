//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAuthn
{
    internal sealed class AuthenticatorTransportStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport>
    {
        public override CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport.Ble => "ble",
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport.Cable => "cable",
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport.Internal => "internal",
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport.Nfc => "nfc",
                CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport.Usb => "usb",
                _ => throw new NotSupportedException("AuthenticatorTransport" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
