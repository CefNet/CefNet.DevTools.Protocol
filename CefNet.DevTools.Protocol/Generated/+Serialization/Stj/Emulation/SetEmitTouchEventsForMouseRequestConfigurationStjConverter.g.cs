//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class SetEmitTouchEventsForMouseRequestConfigurationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration>
    {
        public override CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration.Desktop => "desktop",
                CefNet.DevTools.Protocol.Emulation.SetEmitTouchEventsForMouseRequestConfiguration.Mobile => "mobile",
                _ => throw new NotSupportedException("SetEmitTouchEventsForMouseRequestConfiguration" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
