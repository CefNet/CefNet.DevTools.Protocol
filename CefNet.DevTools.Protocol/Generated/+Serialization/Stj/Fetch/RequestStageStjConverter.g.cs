//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Fetch
{
    internal sealed class RequestStageStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Fetch.RequestStage>
    {
        public override CefNet.DevTools.Protocol.Fetch.RequestStage Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Fetch.RequestStage value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Fetch.RequestStage.Request => "Request",
                CefNet.DevTools.Protocol.Fetch.RequestStage.Response => "Response",
                _ => throw new NotSupportedException("RequestStage" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
