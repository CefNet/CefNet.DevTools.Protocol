//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Emulation
{
    internal sealed class DisabledImageTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Emulation.DisabledImageType>
    {
        public override CefNet.DevTools.Protocol.Emulation.DisabledImageType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Emulation.DisabledImageType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Emulation.DisabledImageType.Avif => "avif",
                CefNet.DevTools.Protocol.Emulation.DisabledImageType.Jxl => "jxl",
                CefNet.DevTools.Protocol.Emulation.DisabledImageType.Webp => "webp",
                _ => throw new NotSupportedException("DisabledImageType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
