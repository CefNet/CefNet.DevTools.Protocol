//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class InterceptionStageStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.InterceptionStage>
    {
        public override CefNet.DevTools.Protocol.Network.InterceptionStage Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.InterceptionStage value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Network.InterceptionStage.HeadersReceived => "HeadersReceived",
                CefNet.DevTools.Protocol.Network.InterceptionStage.Request => "Request",
                _ => throw new NotSupportedException("InterceptionStage" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
