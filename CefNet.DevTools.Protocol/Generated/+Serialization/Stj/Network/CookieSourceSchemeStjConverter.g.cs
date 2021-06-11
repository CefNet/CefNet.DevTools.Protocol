//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CookieSourceSchemeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CookieSourceScheme>
    {
        public override CefNet.DevTools.Protocol.Network.CookieSourceScheme Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "NonSecure" => CefNet.DevTools.Protocol.Network.CookieSourceScheme.NonSecure,
                "Secure" => CefNet.DevTools.Protocol.Network.CookieSourceScheme.Secure,
                "Unset" => CefNet.DevTools.Protocol.Network.CookieSourceScheme.Unset,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CookieSourceScheme value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.CookieSourceScheme.NonSecure => "NonSecure",
                CefNet.DevTools.Protocol.Network.CookieSourceScheme.Secure => "Secure",
                CefNet.DevTools.Protocol.Network.CookieSourceScheme.Unset => "Unset",
                _ => throw new NotSupportedException("CookieSourceScheme" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
