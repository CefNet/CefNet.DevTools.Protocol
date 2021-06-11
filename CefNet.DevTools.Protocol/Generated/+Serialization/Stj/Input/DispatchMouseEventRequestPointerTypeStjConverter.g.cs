//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class DispatchMouseEventRequestPointerTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType>
    {
        public override CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType.Mouse => "mouse",
                CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType.Pen => "pen",
                _ => throw new NotSupportedException("DispatchMouseEventRequestPointerType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
