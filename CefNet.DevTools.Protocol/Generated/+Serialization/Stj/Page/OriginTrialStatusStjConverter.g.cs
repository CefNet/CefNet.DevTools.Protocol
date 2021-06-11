//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class OriginTrialStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.OriginTrialStatus>
    {
        public override CefNet.DevTools.Protocol.Page.OriginTrialStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Enabled" => CefNet.DevTools.Protocol.Page.OriginTrialStatus.Enabled,
                "OSNotSupported" => CefNet.DevTools.Protocol.Page.OriginTrialStatus.OSNotSupported,
                "TrialNotAllowed" => CefNet.DevTools.Protocol.Page.OriginTrialStatus.TrialNotAllowed,
                "ValidTokenNotProvided" => CefNet.DevTools.Protocol.Page.OriginTrialStatus.ValidTokenNotProvided,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.OriginTrialStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
