//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Target
{
    internal sealed class TargetIDStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Target.TargetID>
    {
        public override CefNet.DevTools.Protocol.Target.TargetID Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.Target.TargetID(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Target.TargetID value, 
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.GetUnderlyingValue());
        }
    }
}
