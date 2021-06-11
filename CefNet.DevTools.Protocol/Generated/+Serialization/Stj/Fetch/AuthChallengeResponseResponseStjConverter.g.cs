//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Fetch
{
    internal sealed class AuthChallengeResponseResponseStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse>
    {
        public override CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse.CancelAuth => "CancelAuth",
                CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse.Default => "Default",
                CefNet.DevTools.Protocol.Fetch.AuthChallengeResponseResponse.ProvideCredentials => "ProvideCredentials",
                _ => throw new NotSupportedException("AuthChallengeResponseResponse" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
