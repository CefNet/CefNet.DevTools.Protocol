//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Overlay
{
    internal sealed class InspectModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Overlay.InspectMode>
    {
        public override CefNet.DevTools.Protocol.Overlay.InspectMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Overlay.InspectMode value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Overlay.InspectMode.CaptureAreaScreenshot => "captureAreaScreenshot",
                CefNet.DevTools.Protocol.Overlay.InspectMode.None => "none",
                CefNet.DevTools.Protocol.Overlay.InspectMode.SearchForNode => "searchForNode",
                CefNet.DevTools.Protocol.Overlay.InspectMode.SearchForUAShadowDOM => "searchForUAShadowDOM",
                CefNet.DevTools.Protocol.Overlay.InspectMode.ShowDistances => "showDistances",
                _ => throw new NotSupportedException("InspectMode" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
