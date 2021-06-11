//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class SharedArrayBufferIssueTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType>
    {
        public override CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CreationIssue" => CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType.CreationIssue,
                "TransferIssue" => CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType.TransferIssue,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.SharedArrayBufferIssueType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
