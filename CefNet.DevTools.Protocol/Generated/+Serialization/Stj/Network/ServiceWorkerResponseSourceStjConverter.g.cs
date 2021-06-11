//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ServiceWorkerResponseSourceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource>
    {
        public override CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "cache-storage" => CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource.CacheStorage,
                "fallback-code" => CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource.FallbackCode,
                "http-cache" => CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource.HttpCache,
                "network" => CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource.Network,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ServiceWorkerResponseSource value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
