//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class EmulateTouchFromMouseEventRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType>
    {
        public override CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType.MouseMoved => "mouseMoved",
                CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType.MousePressed => "mousePressed",
                CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType.MouseReleased => "mouseReleased",
                CefNet.DevTools.Protocol.Input.EmulateTouchFromMouseEventRequestType.MouseWheel => "mouseWheel",
                _ => throw new NotSupportedException("EmulateTouchFromMouseEventRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
