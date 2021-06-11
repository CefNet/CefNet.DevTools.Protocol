//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    internal sealed class CacheIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.CacheStorage.CacheId>
    {
        public override CefNet.DevTools.Protocol.CacheStorage.CacheId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.CacheStorage.CacheId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.CacheStorage.CacheId value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
