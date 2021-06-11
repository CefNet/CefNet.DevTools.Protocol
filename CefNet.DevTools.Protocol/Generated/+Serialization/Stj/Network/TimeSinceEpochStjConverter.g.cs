//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class TimeSinceEpochStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.TimeSinceEpoch>
    {
        public override CefNet.DevTools.Protocol.Network.TimeSinceEpoch Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            if (!reader.TryGetDouble(out var value)) throw new JsonException();
            return new CefNet.DevTools.Protocol.Network.TimeSinceEpoch(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.TimeSinceEpoch value, 
            JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.GetUnderlyingValue());
        }
    }
}
