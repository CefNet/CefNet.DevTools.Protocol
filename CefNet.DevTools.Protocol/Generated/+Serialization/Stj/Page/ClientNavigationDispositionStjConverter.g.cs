//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class ClientNavigationDispositionStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.ClientNavigationDisposition>
    {
        public override CefNet.DevTools.Protocol.Page.ClientNavigationDisposition Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "currentTab" => CefNet.DevTools.Protocol.Page.ClientNavigationDisposition.CurrentTab,
                "download" => CefNet.DevTools.Protocol.Page.ClientNavigationDisposition.Download,
                "newTab" => CefNet.DevTools.Protocol.Page.ClientNavigationDisposition.NewTab,
                "newWindow" => CefNet.DevTools.Protocol.Page.ClientNavigationDisposition.NewWindow,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.ClientNavigationDisposition value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
