//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class RequestReferrerPolicyStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.RequestReferrerPolicy>
    {
        public override CefNet.DevTools.Protocol.Network.RequestReferrerPolicy Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "no-referrer" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.NoReferrer,
                "no-referrer-when-downgrade" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.NoReferrerWhenDowngrade,
                "origin" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.Origin,
                "origin-when-cross-origin" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.OriginWhenCrossOrigin,
                "same-origin" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.SameOrigin,
                "strict-origin" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.StrictOrigin,
                "strict-origin-when-cross-origin" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.StrictOriginWhenCrossOrigin,
                "unsafe-url" => CefNet.DevTools.Protocol.Network.RequestReferrerPolicy.UnsafeUrl,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.RequestReferrerPolicy value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
