//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class NavigationTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.NavigationType>
    {
        public override CefNet.DevTools.Protocol.Page.NavigationType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "BackForwardCacheRestore" => CefNet.DevTools.Protocol.Page.NavigationType.BackForwardCacheRestore,
                "Navigation" => CefNet.DevTools.Protocol.Page.NavigationType.Navigation,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.NavigationType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
