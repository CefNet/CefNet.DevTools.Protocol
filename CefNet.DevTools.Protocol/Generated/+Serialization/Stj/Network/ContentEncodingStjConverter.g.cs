//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class ContentEncodingStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.ContentEncoding>
    {
        public override CefNet.DevTools.Protocol.Network.ContentEncoding Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.ContentEncoding value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.ContentEncoding.Br => "br",
                CefNet.DevTools.Protocol.Network.ContentEncoding.Deflate => "deflate",
                CefNet.DevTools.Protocol.Network.ContentEncoding.Gzip => "gzip",
                _ => throw new NotSupportedException("ContentEncoding" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
