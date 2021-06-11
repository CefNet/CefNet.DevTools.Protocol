//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class DispatchTouchEventRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType>
    {
        public override CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType.TouchCancel => "touchCancel",
                CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType.TouchEnd => "touchEnd",
                CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType.TouchMove => "touchMove",
                CefNet.DevTools.Protocol.Input.DispatchTouchEventRequestType.TouchStart => "touchStart",
                _ => throw new NotSupportedException("DispatchTouchEventRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
