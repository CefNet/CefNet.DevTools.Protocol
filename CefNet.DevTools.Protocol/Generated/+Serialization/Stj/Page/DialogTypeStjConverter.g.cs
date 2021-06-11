//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class DialogTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.DialogType>
    {
        public override CefNet.DevTools.Protocol.Page.DialogType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "alert" => CefNet.DevTools.Protocol.Page.DialogType.Alert,
                "beforeunload" => CefNet.DevTools.Protocol.Page.DialogType.Beforeunload,
                "confirm" => CefNet.DevTools.Protocol.Page.DialogType.Confirm,
                "prompt" => CefNet.DevTools.Protocol.Page.DialogType.Prompt,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.DialogType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
