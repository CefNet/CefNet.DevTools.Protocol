//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOM
{
    internal sealed class NodeIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOM.NodeId>
    {
        public override CefNet.DevTools.Protocol.DOM.NodeId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.DOM.NodeId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOM.NodeId value, 
            JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.GetUnderlyingValue());
        }
    }
}
