//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class ClientNavigationReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.ClientNavigationReason>
    {
        public override CefNet.DevTools.Protocol.Page.ClientNavigationReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "anchorClick" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.AnchorClick,
                "formSubmissionGet" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.FormSubmissionGet,
                "formSubmissionPost" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.FormSubmissionPost,
                "httpHeaderRefresh" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.HttpHeaderRefresh,
                "metaTagRefresh" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.MetaTagRefresh,
                "pageBlockInterstitial" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.PageBlockInterstitial,
                "reload" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.Reload,
                "scriptInitiated" => CefNet.DevTools.Protocol.Page.ClientNavigationReason.ScriptInitiated,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.ClientNavigationReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
