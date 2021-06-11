//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class TransitionTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.TransitionType>
    {
        public override CefNet.DevTools.Protocol.Page.TransitionType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "address_bar" => CefNet.DevTools.Protocol.Page.TransitionType.Address_bar,
                "auto_bookmark" => CefNet.DevTools.Protocol.Page.TransitionType.Auto_bookmark,
                "auto_subframe" => CefNet.DevTools.Protocol.Page.TransitionType.Auto_subframe,
                "auto_toplevel" => CefNet.DevTools.Protocol.Page.TransitionType.Auto_toplevel,
                "form_submit" => CefNet.DevTools.Protocol.Page.TransitionType.Form_submit,
                "generated" => CefNet.DevTools.Protocol.Page.TransitionType.Generated,
                "keyword" => CefNet.DevTools.Protocol.Page.TransitionType.Keyword,
                "keyword_generated" => CefNet.DevTools.Protocol.Page.TransitionType.Keyword_generated,
                "link" => CefNet.DevTools.Protocol.Page.TransitionType.Link,
                "manual_subframe" => CefNet.DevTools.Protocol.Page.TransitionType.Manual_subframe,
                "other" => CefNet.DevTools.Protocol.Page.TransitionType.Other,
                "reload" => CefNet.DevTools.Protocol.Page.TransitionType.Reload,
                "typed" => CefNet.DevTools.Protocol.Page.TransitionType.Typed,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.TransitionType value, 
            JsonSerializerOptions options)
        {
            var serialized = value switch
            {
                CefNet.DevTools.Protocol.Page.TransitionType.Address_bar => "address_bar",
                CefNet.DevTools.Protocol.Page.TransitionType.Auto_bookmark => "auto_bookmark",
                CefNet.DevTools.Protocol.Page.TransitionType.Auto_subframe => "auto_subframe",
                CefNet.DevTools.Protocol.Page.TransitionType.Auto_toplevel => "auto_toplevel",
                CefNet.DevTools.Protocol.Page.TransitionType.Form_submit => "form_submit",
                CefNet.DevTools.Protocol.Page.TransitionType.Generated => "generated",
                CefNet.DevTools.Protocol.Page.TransitionType.Keyword => "keyword",
                CefNet.DevTools.Protocol.Page.TransitionType.Keyword_generated => "keyword_generated",
                CefNet.DevTools.Protocol.Page.TransitionType.Link => "link",
                CefNet.DevTools.Protocol.Page.TransitionType.Manual_subframe => "manual_subframe",
                CefNet.DevTools.Protocol.Page.TransitionType.Other => "other",
                CefNet.DevTools.Protocol.Page.TransitionType.Reload => "reload",
                CefNet.DevTools.Protocol.Page.TransitionType.Typed => "typed",
                _ => throw new NotSupportedException("TransitionType" + "::" + value.ToString()),
            };
            writer.WriteStringValue(serialized);
        }
    }
}
