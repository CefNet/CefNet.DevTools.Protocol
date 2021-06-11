//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class VirtualTimePolicyStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy>
    {
        public override CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy.Advance => "advance",
                CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy.Pause => "pause",
                CefNet.DevTools.Protocol.Emulation.VirtualTimePolicy.PauseIfNetworkFetchesPending => "pauseIfNetworkFetchesPending",
                _ => throw new NotSupportedException("VirtualTimePolicy" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
