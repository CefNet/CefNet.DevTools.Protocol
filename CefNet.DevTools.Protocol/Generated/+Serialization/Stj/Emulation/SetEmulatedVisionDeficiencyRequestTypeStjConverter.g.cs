//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class SetEmulatedVisionDeficiencyRequestTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType>
    {
        public override CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.Achromatopsia => "achromatopsia",
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.BlurredVision => "blurredVision",
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.Deuteranopia => "deuteranopia",
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.None => "none",
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.Protanopia => "protanopia",
                CefNet.DevTools.Protocol.Emulation.SetEmulatedVisionDeficiencyRequestType.Tritanopia => "tritanopia",
                _ => throw new NotSupportedException("SetEmulatedVisionDeficiencyRequestType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
