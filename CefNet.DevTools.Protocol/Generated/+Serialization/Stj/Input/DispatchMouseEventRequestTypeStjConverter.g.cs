//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class DispatchMouseEventRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType>
    {
        public override CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType.MouseMoved => "mouseMoved",
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType.MousePressed => "mousePressed",
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType.MouseReleased => "mouseReleased",
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType.MouseWheel => "mouseWheel",
                _ => throw new NotSupportedException("DispatchMouseEventRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
