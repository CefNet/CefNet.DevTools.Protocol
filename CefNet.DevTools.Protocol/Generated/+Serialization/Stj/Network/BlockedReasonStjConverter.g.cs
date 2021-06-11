//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class BlockedReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.BlockedReason>
    {
        public override CefNet.DevTools.Protocol.Network.BlockedReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "coep-frame-resource-needs-coep-header" => CefNet.DevTools.Protocol.Network.BlockedReason.CoepFrameResourceNeedsCoepHeader,
                "content-type" => CefNet.DevTools.Protocol.Network.BlockedReason.ContentType,
                "coop-sandboxed-iframe-cannot-navigate-to-coop-page" => CefNet.DevTools.Protocol.Network.BlockedReason.CoopSandboxedIframeCannotNavigateToCoopPage,
                "corp-not-same-origin" => CefNet.DevTools.Protocol.Network.BlockedReason.CorpNotSameOrigin,
                "corp-not-same-origin-after-defaulted-to-same-origin-by-coep" => CefNet.DevTools.Protocol.Network.BlockedReason.CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
                "corp-not-same-site" => CefNet.DevTools.Protocol.Network.BlockedReason.CorpNotSameSite,
                "csp" => CefNet.DevTools.Protocol.Network.BlockedReason.Csp,
                "inspector" => CefNet.DevTools.Protocol.Network.BlockedReason.Inspector,
                "mixed-content" => CefNet.DevTools.Protocol.Network.BlockedReason.MixedContent,
                "origin" => CefNet.DevTools.Protocol.Network.BlockedReason.Origin,
                "other" => CefNet.DevTools.Protocol.Network.BlockedReason.Other,
                "subresource-filter" => CefNet.DevTools.Protocol.Network.BlockedReason.SubresourceFilter,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.BlockedReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
