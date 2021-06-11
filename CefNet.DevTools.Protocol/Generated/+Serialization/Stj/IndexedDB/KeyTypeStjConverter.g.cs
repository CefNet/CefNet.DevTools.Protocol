//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.IndexedDB
{
    internal sealed class KeyTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.IndexedDB.KeyType>
    {
        public override CefNet.DevTools.Protocol.IndexedDB.KeyType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.IndexedDB.KeyType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.IndexedDB.KeyType.Array => "array",
                CefNet.DevTools.Protocol.IndexedDB.KeyType.Date => "date",
                CefNet.DevTools.Protocol.IndexedDB.KeyType.Number => "number",
                CefNet.DevTools.Protocol.IndexedDB.KeyType.String => "string",
                _ => throw new NotSupportedException("KeyType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
