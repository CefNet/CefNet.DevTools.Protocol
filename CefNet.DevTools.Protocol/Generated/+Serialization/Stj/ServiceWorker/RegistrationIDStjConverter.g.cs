//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    internal sealed class RegistrationIDStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.ServiceWorker.RegistrationID>
    {
        public override CefNet.DevTools.Protocol.ServiceWorker.RegistrationID Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.ServiceWorker.RegistrationID(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.ServiceWorker.RegistrationID value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
