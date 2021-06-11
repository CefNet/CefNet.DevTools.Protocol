//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ResourcePriorityStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ResourcePriority>
    {
        public override CefNet.DevTools.Protocol.Network.ResourcePriority Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "High" => CefNet.DevTools.Protocol.Network.ResourcePriority.High,
                "Low" => CefNet.DevTools.Protocol.Network.ResourcePriority.Low,
                "Medium" => CefNet.DevTools.Protocol.Network.ResourcePriority.Medium,
                "VeryHigh" => CefNet.DevTools.Protocol.Network.ResourcePriority.VeryHigh,
                "VeryLow" => CefNet.DevTools.Protocol.Network.ResourcePriority.VeryLow,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ResourcePriority value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
