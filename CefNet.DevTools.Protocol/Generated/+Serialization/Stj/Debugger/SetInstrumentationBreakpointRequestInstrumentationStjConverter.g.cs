//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class SetInstrumentationBreakpointRequestInstrumentationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequestInstrumentation>
    {
        public override CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequestInstrumentation Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequestInstrumentation value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequestInstrumentation.BeforeScriptExecution => "beforeScriptExecution",
                CefNet.DevTools.Protocol.Debugger.SetInstrumentationBreakpointRequestInstrumentation.BeforeScriptWithSourceMapExecution => "beforeScriptWithSourceMapExecution",
                _ => throw new NotSupportedException("SetInstrumentationBreakpointRequestInstrumentation" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
