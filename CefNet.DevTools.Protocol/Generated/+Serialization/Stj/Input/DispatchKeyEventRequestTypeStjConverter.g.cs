//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class DispatchKeyEventRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType>
    {
        public override CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType.Char => "char",
                CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType.KeyDown => "keyDown",
                CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType.KeyUp => "keyUp",
                CefNet.DevTools.Protocol.Input.DispatchKeyEventRequestType.RawKeyDown => "rawKeyDown",
                _ => throw new NotSupportedException("DispatchKeyEventRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
