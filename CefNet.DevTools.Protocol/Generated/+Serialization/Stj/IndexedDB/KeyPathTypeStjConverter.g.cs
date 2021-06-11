//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    internal sealed class KeyPathTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.IndexedDB.KeyPathType>
    {
        public override CefNet.DevTools.Protocol.IndexedDB.KeyPathType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "array" => CefNet.DevTools.Protocol.IndexedDB.KeyPathType.Array,
                "null" => CefNet.DevTools.Protocol.IndexedDB.KeyPathType.Null,
                "string" => CefNet.DevTools.Protocol.IndexedDB.KeyPathType.String,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.IndexedDB.KeyPathType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
