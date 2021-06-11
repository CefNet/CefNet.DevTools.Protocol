//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CookieSameSiteStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CookieSameSite>
    {
        public override CefNet.DevTools.Protocol.Network.CookieSameSite Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Lax" => CefNet.DevTools.Protocol.Network.CookieSameSite.Lax,
                "None" => CefNet.DevTools.Protocol.Network.CookieSameSite.None,
                "Strict" => CefNet.DevTools.Protocol.Network.CookieSameSite.Strict,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CookieSameSite value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.CookieSameSite.Lax => "Lax",
                CefNet.DevTools.Protocol.Network.CookieSameSite.None => "None",
                CefNet.DevTools.Protocol.Network.CookieSameSite.Strict => "Strict",
                _ => throw new NotSupportedException("CookieSameSite" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
