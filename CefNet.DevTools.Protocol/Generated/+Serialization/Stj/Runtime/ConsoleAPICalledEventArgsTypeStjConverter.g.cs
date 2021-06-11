//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class ConsoleAPICalledEventArgsTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType>
    {
        public override CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "assert" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Assert,
                "clear" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Clear,
                "count" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Count,
                "debug" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Debug,
                "dir" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Dir,
                "dirxml" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Dirxml,
                "endGroup" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.EndGroup,
                "error" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Error,
                "info" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Info,
                "log" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Log,
                "profile" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Profile,
                "profileEnd" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.ProfileEnd,
                "startGroup" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.StartGroup,
                "startGroupCollapsed" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.StartGroupCollapsed,
                "table" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Table,
                "timeEnd" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.TimeEnd,
                "trace" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Trace,
                "warning" => CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType.Warning,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.ConsoleAPICalledEventArgsType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
