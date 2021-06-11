//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class StartScreencastRequestFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat>
    {
        public override CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat.Jpeg => "jpeg",
                CefNet.DevTools.Protocol.Page.StartScreencastRequestFormat.Png => "png",
                _ => throw new NotSupportedException("StartScreencastRequestFormat" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
