//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class IPAddressSpaceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.IPAddressSpace>
    {
        public override CefNet.DevTools.Protocol.Network.IPAddressSpace Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Local" => CefNet.DevTools.Protocol.Network.IPAddressSpace.Local,
                "Private" => CefNet.DevTools.Protocol.Network.IPAddressSpace.Private,
                "Public" => CefNet.DevTools.Protocol.Network.IPAddressSpace.Public,
                "Unknown" => CefNet.DevTools.Protocol.Network.IPAddressSpace.Unknown,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.IPAddressSpace value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
