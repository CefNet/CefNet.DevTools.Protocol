//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.SystemInfo
{
    internal sealed class SubsamplingFormatStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat>
    {
        public override CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "yuv420" => CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat.Yuv420,
                "yuv422" => CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat.Yuv422,
                "yuv444" => CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat.Yuv444,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.SystemInfo.SubsamplingFormat value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
