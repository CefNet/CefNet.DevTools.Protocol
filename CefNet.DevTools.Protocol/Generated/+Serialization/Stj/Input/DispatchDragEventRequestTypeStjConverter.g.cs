//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class DispatchDragEventRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType>
    {
        public override CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType.DragCancel => "dragCancel",
                CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType.DragEnter => "dragEnter",
                CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType.DragOver => "dragOver",
                CefNet.DevTools.Protocol.Input.DispatchDragEventRequestType.Drop => "drop",
                _ => throw new NotSupportedException("DispatchDragEventRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
