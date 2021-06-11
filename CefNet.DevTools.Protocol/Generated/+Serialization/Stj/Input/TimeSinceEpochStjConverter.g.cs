//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Input
{
    internal sealed class TimeSinceEpochStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Input.TimeSinceEpoch>
    {
        public override CefNet.DevTools.Protocol.Input.TimeSinceEpoch Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Input.TimeSinceEpoch value, 
            JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.GetUnderlyingValue());
        }
    }
}
