//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    internal sealed class StringIndexStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.DOMSnapshot.StringIndex>
    {
        public override CefNet.DevTools.Protocol.DOMSnapshot.StringIndex Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetInt32(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.DOMSnapshot.StringIndex(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.DOMSnapshot.StringIndex value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
