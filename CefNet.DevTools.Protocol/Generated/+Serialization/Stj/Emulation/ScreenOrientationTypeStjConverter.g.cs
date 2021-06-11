//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class ScreenOrientationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.ScreenOrientationType>
    {
        public override CefNet.DevTools.Protocol.Emulation.ScreenOrientationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.ScreenOrientationType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.ScreenOrientationType.LandscapePrimary => "landscapePrimary",
                CefNet.DevTools.Protocol.Emulation.ScreenOrientationType.LandscapeSecondary => "landscapeSecondary",
                CefNet.DevTools.Protocol.Emulation.ScreenOrientationType.PortraitPrimary => "portraitPrimary",
                CefNet.DevTools.Protocol.Emulation.ScreenOrientationType.PortraitSecondary => "portraitSecondary",
                _ => throw new NotSupportedException("ScreenOrientationType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
