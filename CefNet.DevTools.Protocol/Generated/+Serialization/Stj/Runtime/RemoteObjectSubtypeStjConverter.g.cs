//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Runtime
{
    internal sealed class RemoteObjectSubtypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype>
    {
        public override CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "array" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Array,
                "arraybuffer" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Arraybuffer,
                "dataview" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Dataview,
                "date" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Date,
                "error" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Error,
                "generator" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Generator,
                "iterator" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Iterator,
                "map" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Map,
                "node" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Node,
                "null" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Null,
                "promise" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Promise,
                "proxy" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Proxy,
                "regexp" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Regexp,
                "set" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Set,
                "typedarray" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Typedarray,
                "wasmvalue" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Wasmvalue,
                "weakmap" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Weakmap,
                "weakset" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Weakset,
                "webassemblymemory" => CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype.Webassemblymemory,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Runtime.RemoteObjectSubtype value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
