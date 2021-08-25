//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class IssueIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.IssueId>
    {
        public override CefNet.DevTools.Protocol.Audits.IssueId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            return new CefNet.DevTools.Protocol.Audits.IssueId(value);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.IssueId value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
