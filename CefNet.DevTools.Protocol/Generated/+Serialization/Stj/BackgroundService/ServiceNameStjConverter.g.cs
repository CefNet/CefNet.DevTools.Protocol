//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.BackgroundService
{
    internal sealed class ServiceNameStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.BackgroundService.ServiceName>
    {
        public override CefNet.DevTools.Protocol.BackgroundService.ServiceName Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "backgroundFetch" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.BackgroundFetch,
                "backgroundSync" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.BackgroundSync,
                "notifications" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.Notifications,
                "paymentHandler" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.PaymentHandler,
                "periodicBackgroundSync" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.PeriodicBackgroundSync,
                "pushMessaging" => CefNet.DevTools.Protocol.BackgroundService.ServiceName.PushMessaging,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.BackgroundService.ServiceName value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.BackgroundFetch => "backgroundFetch",
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.BackgroundSync => "backgroundSync",
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.Notifications => "notifications",
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.PaymentHandler => "paymentHandler",
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.PeriodicBackgroundSync => "periodicBackgroundSync",
                CefNet.DevTools.Protocol.BackgroundService.ServiceName.PushMessaging => "pushMessaging",
                _ => throw new NotSupportedException("ServiceName" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
