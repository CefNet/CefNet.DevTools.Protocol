//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOMDebugger
{
    internal sealed class DOMBreakpointTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType>
    {
        public override CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType.AttributeModified => "attribute-modified",
                CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType.NodeRemoved => "node-removed",
                CefNet.DevTools.Protocol.DOMDebugger.DOMBreakpointType.SubtreeModified => "subtree-modified",
                _ => throw new NotSupportedException("DOMBreakpointType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
