//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Console
{
    internal sealed class ConsoleMessageSourceStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Console.ConsoleMessageSource>
    {
        public override CefNet.DevTools.Protocol.Console.ConsoleMessageSource Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "appcache" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Appcache,
                "console-api" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.ConsoleApi,
                "deprecation" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Deprecation,
                "javascript" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Javascript,
                "network" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Network,
                "other" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Other,
                "rendering" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Rendering,
                "security" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Security,
                "storage" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Storage,
                "worker" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Worker,
                "xml" => CefNet.DevTools.Protocol.Console.ConsoleMessageSource.Xml,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Console.ConsoleMessageSource value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
