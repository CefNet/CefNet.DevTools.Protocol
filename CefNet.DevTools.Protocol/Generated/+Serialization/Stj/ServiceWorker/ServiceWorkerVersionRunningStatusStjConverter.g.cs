//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    internal sealed class ServiceWorkerVersionRunningStatusStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus>
    {
        public override CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "running" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus.Running,
                "starting" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus.Starting,
                "stopped" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus.Stopped,
                "stopping" => CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus.Stopping,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.ServiceWorker.ServiceWorkerVersionRunningStatus value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
