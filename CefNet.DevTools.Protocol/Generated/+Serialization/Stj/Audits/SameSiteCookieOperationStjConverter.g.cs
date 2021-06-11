//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class SameSiteCookieOperationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation>
    {
        public override CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "ReadCookie" => CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation.ReadCookie,
                "SetCookie" => CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation.SetCookie,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.SameSiteCookieOperation value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
