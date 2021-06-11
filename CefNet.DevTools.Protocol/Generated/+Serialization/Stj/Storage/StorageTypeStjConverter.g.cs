//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Storage
{
    internal sealed class StorageTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Storage.StorageType>
    {
        public override CefNet.DevTools.Protocol.Storage.StorageType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "all" => CefNet.DevTools.Protocol.Storage.StorageType.All,
                "appcache" => CefNet.DevTools.Protocol.Storage.StorageType.Appcache,
                "cache_storage" => CefNet.DevTools.Protocol.Storage.StorageType.Cache_storage,
                "cookies" => CefNet.DevTools.Protocol.Storage.StorageType.Cookies,
                "file_systems" => CefNet.DevTools.Protocol.Storage.StorageType.File_systems,
                "indexeddb" => CefNet.DevTools.Protocol.Storage.StorageType.Indexeddb,
                "local_storage" => CefNet.DevTools.Protocol.Storage.StorageType.Local_storage,
                "other" => CefNet.DevTools.Protocol.Storage.StorageType.Other,
                "service_workers" => CefNet.DevTools.Protocol.Storage.StorageType.Service_workers,
                "shader_cache" => CefNet.DevTools.Protocol.Storage.StorageType.Shader_cache,
                "websql" => CefNet.DevTools.Protocol.Storage.StorageType.Websql,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Storage.StorageType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
