//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class DisplayFeatureOrientationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation>
    {
        public override CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation.Horizontal => "horizontal",
                CefNet.DevTools.Protocol.Emulation.DisplayFeatureOrientation.Vertical => "vertical",
                _ => throw new NotSupportedException("DisplayFeatureOrientation" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
