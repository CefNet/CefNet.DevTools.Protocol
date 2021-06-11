//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Animation
{
    internal sealed class AnimationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Animation.AnimationType>
    {
        public override CefNet.DevTools.Protocol.Animation.AnimationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CSSAnimation" => CefNet.DevTools.Protocol.Animation.AnimationType.CSSAnimation,
                "CSSTransition" => CefNet.DevTools.Protocol.Animation.AnimationType.CSSTransition,
                "WebAnimation" => CefNet.DevTools.Protocol.Animation.AnimationType.WebAnimation,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Animation.AnimationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
