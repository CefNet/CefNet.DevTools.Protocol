//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class OriginTrialTokenStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus>
    {
        public override CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Expired" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.Expired,
                "FeatureDisabled" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.FeatureDisabled,
                "FeatureDisabledForUser" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.FeatureDisabledForUser,
                "Insecure" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.Insecure,
                "InvalidSignature" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.InvalidSignature,
                "Malformed" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.Malformed,
                "NotSupported" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.NotSupported,
                "Success" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.Success,
                "TokenDisabled" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.TokenDisabled,
                "WrongOrigin" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.WrongOrigin,
                "WrongVersion" => CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus.WrongVersion,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.OriginTrialTokenStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
