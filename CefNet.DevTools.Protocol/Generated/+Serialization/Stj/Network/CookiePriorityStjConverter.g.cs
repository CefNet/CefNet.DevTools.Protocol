//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CookiePriorityStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CookiePriority>
    {
        public override CefNet.DevTools.Protocol.Network.CookiePriority Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "High" => CefNet.DevTools.Protocol.Network.CookiePriority.High,
                "Low" => CefNet.DevTools.Protocol.Network.CookiePriority.Low,
                "Medium" => CefNet.DevTools.Protocol.Network.CookiePriority.Medium,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CookiePriority value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.CookiePriority.High => "High",
                CefNet.DevTools.Protocol.Network.CookiePriority.Low => "Low",
                CefNet.DevTools.Protocol.Network.CookiePriority.Medium => "Medium",
                _ => throw new NotSupportedException("CookiePriority" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
