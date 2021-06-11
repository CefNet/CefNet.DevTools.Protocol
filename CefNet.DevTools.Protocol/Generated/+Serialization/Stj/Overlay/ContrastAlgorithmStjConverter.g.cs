//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Overlay
{
    internal sealed class ContrastAlgorithmStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm>
    {
        public override CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm.Aa => "aa",
                CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm.Aaa => "aaa",
                CefNet.DevTools.Protocol.Overlay.ContrastAlgorithm.Apca => "apca",
                _ => throw new NotSupportedException("ContrastAlgorithm" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
