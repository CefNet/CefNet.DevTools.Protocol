//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class MixedContentResolutionStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus>
    {
        public override CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "MixedContentAutomaticallyUpgraded" => CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus.MixedContentAutomaticallyUpgraded,
                "MixedContentBlocked" => CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus.MixedContentBlocked,
                "MixedContentWarning" => CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus.MixedContentWarning,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
