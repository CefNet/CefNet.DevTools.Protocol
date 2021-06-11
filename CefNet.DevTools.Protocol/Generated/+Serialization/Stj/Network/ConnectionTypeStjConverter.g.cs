//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ConnectionTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ConnectionType>
    {
        public override CefNet.DevTools.Protocol.Network.ConnectionType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ConnectionType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.ConnectionType.Bluetooth => "bluetooth",
                CefNet.DevTools.Protocol.Network.ConnectionType.Cellular2g => "cellular2g",
                CefNet.DevTools.Protocol.Network.ConnectionType.Cellular3g => "cellular3g",
                CefNet.DevTools.Protocol.Network.ConnectionType.Cellular4g => "cellular4g",
                CefNet.DevTools.Protocol.Network.ConnectionType.Ethernet => "ethernet",
                CefNet.DevTools.Protocol.Network.ConnectionType.None => "none",
                CefNet.DevTools.Protocol.Network.ConnectionType.Other => "other",
                CefNet.DevTools.Protocol.Network.ConnectionType.Wifi => "wifi",
                CefNet.DevTools.Protocol.Network.ConnectionType.Wimax => "wimax",
                _ => throw new NotSupportedException("ConnectionType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
