//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class ContinueToLocationRequestTargetCallFramesStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequestTargetCallFrames>
    {
        public override CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequestTargetCallFrames Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequestTargetCallFrames value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequestTargetCallFrames.Any => "any",
                CefNet.DevTools.Protocol.Debugger.ContinueToLocationRequestTargetCallFrames.Current => "current",
                _ => throw new NotSupportedException("ContinueToLocationRequestTargetCallFrames" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
