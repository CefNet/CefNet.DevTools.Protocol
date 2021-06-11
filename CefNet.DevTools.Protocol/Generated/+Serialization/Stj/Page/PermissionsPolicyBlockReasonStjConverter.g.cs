//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class PermissionsPolicyBlockReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.PermissionsPolicyBlockReason>
    {
        public override CefNet.DevTools.Protocol.Page.PermissionsPolicyBlockReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Header" => CefNet.DevTools.Protocol.Page.PermissionsPolicyBlockReason.Header,
                "IframeAttribute" => CefNet.DevTools.Protocol.Page.PermissionsPolicyBlockReason.IframeAttribute,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.PermissionsPolicyBlockReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
