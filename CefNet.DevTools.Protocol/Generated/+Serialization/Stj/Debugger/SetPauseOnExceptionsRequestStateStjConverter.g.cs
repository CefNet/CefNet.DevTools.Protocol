//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class SetPauseOnExceptionsRequestStateStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState>
    {
        public override CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState.All => "all",
                CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState.None => "none",
                CefNet.DevTools.Protocol.Debugger.SetPauseOnExceptionsRequestState.Uncaught => "uncaught",
                _ => throw new NotSupportedException("SetPauseOnExceptionsRequestState" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
