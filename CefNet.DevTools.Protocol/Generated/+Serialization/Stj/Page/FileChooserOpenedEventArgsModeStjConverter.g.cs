//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class FileChooserOpenedEventArgsModeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode>
    {
        public override CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "selectMultiple" => CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode.SelectMultiple,
                "selectSingle" => CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode.SelectSingle,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgsMode value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
