//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class DebugSymbolsTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.DebugSymbolsType>
    {
        public override CefNet.DevTools.Protocol.Debugger.DebugSymbolsType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "EmbeddedDWARF" => CefNet.DevTools.Protocol.Debugger.DebugSymbolsType.EmbeddedDWARF,
                "ExternalDWARF" => CefNet.DevTools.Protocol.Debugger.DebugSymbolsType.ExternalDWARF,
                "None" => CefNet.DevTools.Protocol.Debugger.DebugSymbolsType.None,
                "SourceMap" => CefNet.DevTools.Protocol.Debugger.DebugSymbolsType.SourceMap,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.DebugSymbolsType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
