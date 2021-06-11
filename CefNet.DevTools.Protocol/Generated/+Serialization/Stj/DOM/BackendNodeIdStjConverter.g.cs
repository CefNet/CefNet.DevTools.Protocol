//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOM
{
    internal sealed class BackendNodeIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOM.BackendNodeId>
    {
        public override CefNet.DevTools.Protocol.DOM.BackendNodeId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.DOM.BackendNodeId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOM.BackendNodeId value, 
            JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.GetUnderlyingValue());
        }
    }
}
