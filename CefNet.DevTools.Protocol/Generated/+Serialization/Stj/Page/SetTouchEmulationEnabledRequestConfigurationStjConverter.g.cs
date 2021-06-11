//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class SetTouchEmulationEnabledRequestConfigurationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration>
    {
        public override CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration.Desktop => "desktop",
                CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequestConfiguration.Mobile => "mobile",
                _ => throw new NotSupportedException("SetTouchEmulationEnabledRequestConfiguration" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
