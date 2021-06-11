//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Browser
{
    internal sealed class BrowserCommandIdStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Browser.BrowserCommandId>
    {
        public override CefNet.DevTools.Protocol.Browser.BrowserCommandId Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Browser.BrowserCommandId value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Browser.BrowserCommandId.CloseTabSearch => "closeTabSearch",
                CefNet.DevTools.Protocol.Browser.BrowserCommandId.OpenTabSearch => "openTabSearch",
                _ => throw new NotSupportedException("BrowserCommandId" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
