//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.CacheStorage
{
    internal sealed class CachedResponseTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.CacheStorage.CachedResponseType>
    {
        public override CefNet.DevTools.Protocol.CacheStorage.CachedResponseType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "basic" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.Basic,
                "cors" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.Cors,
                "default" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.Default,
                "error" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.Error,
                "opaqueRedirect" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.OpaqueRedirect,
                "opaqueResponse" => CefNet.DevTools.Protocol.CacheStorage.CachedResponseType.OpaqueResponse,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.CacheStorage.CachedResponseType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
