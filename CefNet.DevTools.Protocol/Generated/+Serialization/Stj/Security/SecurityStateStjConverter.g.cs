//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Security
{
    internal sealed class SecurityStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Security.SecurityState>
    {
        public override CefNet.DevTools.Protocol.Security.SecurityState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "info" => CefNet.DevTools.Protocol.Security.SecurityState.Info,
                "insecure" => CefNet.DevTools.Protocol.Security.SecurityState.Insecure,
                "insecure-broken" => CefNet.DevTools.Protocol.Security.SecurityState.InsecureBroken,
                "neutral" => CefNet.DevTools.Protocol.Security.SecurityState.Neutral,
                "secure" => CefNet.DevTools.Protocol.Security.SecurityState.Secure,
                "unknown" => CefNet.DevTools.Protocol.Security.SecurityState.Unknown,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Security.SecurityState value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
