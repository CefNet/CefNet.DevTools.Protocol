//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Console
{
    internal sealed class ConsoleMessageLevelStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Console.ConsoleMessageLevel>
    {
        public override CefNet.DevTools.Protocol.Console.ConsoleMessageLevel Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "debug" => CefNet.DevTools.Protocol.Console.ConsoleMessageLevel.Debug,
                "error" => CefNet.DevTools.Protocol.Console.ConsoleMessageLevel.Error,
                "info" => CefNet.DevTools.Protocol.Console.ConsoleMessageLevel.Info,
                "log" => CefNet.DevTools.Protocol.Console.ConsoleMessageLevel.Log,
                "warning" => CefNet.DevTools.Protocol.Console.ConsoleMessageLevel.Warning,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Console.ConsoleMessageLevel value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
