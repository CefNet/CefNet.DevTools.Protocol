//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Fetch
{
    internal sealed class AuthChallengeSourceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Fetch.AuthChallengeSource>
    {
        public override CefNet.DevTools.Protocol.Fetch.AuthChallengeSource Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Proxy" => CefNet.DevTools.Protocol.Fetch.AuthChallengeSource.Proxy,
                "Server" => CefNet.DevTools.Protocol.Fetch.AuthChallengeSource.Server,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Fetch.AuthChallengeSource value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
