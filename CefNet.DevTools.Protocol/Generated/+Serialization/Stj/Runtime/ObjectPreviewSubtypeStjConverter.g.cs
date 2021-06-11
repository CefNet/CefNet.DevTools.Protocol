//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class ObjectPreviewSubtypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype>
    {
        public override CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "array" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Array,
                "arraybuffer" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Arraybuffer,
                "dataview" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Dataview,
                "date" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Date,
                "error" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Error,
                "generator" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Generator,
                "iterator" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Iterator,
                "map" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Map,
                "node" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Node,
                "null" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Null,
                "promise" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Promise,
                "proxy" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Proxy,
                "regexp" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Regexp,
                "set" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Set,
                "typedarray" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Typedarray,
                "wasmvalue" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Wasmvalue,
                "weakmap" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Weakmap,
                "weakset" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Weakset,
                "webassemblymemory" => CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype.Webassemblymemory,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.ObjectPreviewSubtype value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
