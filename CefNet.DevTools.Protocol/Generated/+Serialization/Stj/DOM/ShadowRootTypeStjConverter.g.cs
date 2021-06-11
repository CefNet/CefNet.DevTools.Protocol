//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOM
{
    internal sealed class ShadowRootTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOM.ShadowRootType>
    {
        public override CefNet.DevTools.Protocol.DOM.ShadowRootType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "closed" => CefNet.DevTools.Protocol.DOM.ShadowRootType.Closed,
                "open" => CefNet.DevTools.Protocol.DOM.ShadowRootType.Open,
                "user-agent" => CefNet.DevTools.Protocol.DOM.ShadowRootType.UserAgent,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOM.ShadowRootType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
