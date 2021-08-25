//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class CaptureScreenshotRequestFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat>
    {
        public override CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat.Jpeg => "jpeg",
                CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat.Png => "png",
                CefNet.DevTools.Protocol.Page.CaptureScreenshotRequestFormat.Webp => "webp",
                _ => throw new NotSupportedException("CaptureScreenshotRequestFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
