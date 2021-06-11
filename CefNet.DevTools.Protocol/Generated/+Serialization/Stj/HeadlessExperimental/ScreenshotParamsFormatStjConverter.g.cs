//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.HeadlessExperimental
{
    internal sealed class ScreenshotParamsFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat>
    {
        public override CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat.Jpeg => "jpeg",
                CefNet.DevTools.Protocol.HeadlessExperimental.ScreenshotParamsFormat.Png => "png",
                _ => throw new NotSupportedException("ScreenshotParamsFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
