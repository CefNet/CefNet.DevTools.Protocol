//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class AuthChallengeResponseResponseStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse>
    {
        public override CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse.CancelAuth => "CancelAuth",
                CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse.Default => "Default",
                CefNet.DevTools.Protocol.Network.AuthChallengeResponseResponse.ProvideCredentials => "ProvideCredentials",
                _ => throw new NotSupportedException("AuthChallengeResponseResponse" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
