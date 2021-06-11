//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Debugger
{
    internal sealed class ScriptLanguageStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Debugger.ScriptLanguage>
    {
        public override CefNet.DevTools.Protocol.Debugger.ScriptLanguage Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "JavaScript" => CefNet.DevTools.Protocol.Debugger.ScriptLanguage.JavaScript,
                "WebAssembly" => CefNet.DevTools.Protocol.Debugger.ScriptLanguage.WebAssembly,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Debugger.ScriptLanguage value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
