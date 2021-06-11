//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class PropertyPreviewSubtypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype>
    {
        public override CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "array" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Array,
                "arraybuffer" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Arraybuffer,
                "dataview" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Dataview,
                "date" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Date,
                "error" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Error,
                "generator" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Generator,
                "iterator" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Iterator,
                "map" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Map,
                "node" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Node,
                "null" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Null,
                "promise" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Promise,
                "proxy" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Proxy,
                "regexp" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Regexp,
                "set" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Set,
                "typedarray" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Typedarray,
                "wasmvalue" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Wasmvalue,
                "weakmap" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Weakmap,
                "weakset" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Weakset,
                "webassemblymemory" => CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype.Webassemblymemory,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.PropertyPreviewSubtype value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
