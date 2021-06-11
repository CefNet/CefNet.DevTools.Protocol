//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    internal sealed class ServiceWorkerVersionStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus>
    {
        public override CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "activated" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.Activated,
                "activating" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.Activating,
                "installed" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.Installed,
                "installing" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.Installing,
                "new" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.New,
                "redundant" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus.Redundant,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
