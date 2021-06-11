//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class LoaderIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.LoaderId>
    {
        public override CefNet.DevTools.Protocol.Network.LoaderId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.Network.LoaderId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.LoaderId value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
