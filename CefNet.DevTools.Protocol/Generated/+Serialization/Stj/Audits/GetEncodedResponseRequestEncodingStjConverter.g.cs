//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class GetEncodedResponseRequestEncodingStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding>
    {
        public override CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding.Jpeg => "jpeg",
                CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding.Png => "png",
                CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequestEncoding.Webp => "webp",
                _ => throw new NotSupportedException("GetEncodedResponseRequestEncoding" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
