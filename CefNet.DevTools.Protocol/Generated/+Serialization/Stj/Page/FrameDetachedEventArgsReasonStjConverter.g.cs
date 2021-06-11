//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class FrameDetachedEventArgsReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.FrameDetachedEventArgsReason>
    {
        public override CefNet.DevTools.Protocol.Page.FrameDetachedEventArgsReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "remove" => CefNet.DevTools.Protocol.Page.FrameDetachedEventArgsReason.Remove,
                "swap" => CefNet.DevTools.Protocol.Page.FrameDetachedEventArgsReason.Swap,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.FrameDetachedEventArgsReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
