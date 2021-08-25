//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class BackForwardCacheNotRestoredReasonTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType>
    {
        public override CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "Circumstantial" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType.Circumstantial,
                "PageSupportNeeded" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType.PageSupportNeeded,
                "SupportPending" => CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType.SupportPending,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.BackForwardCacheNotRestoredReasonType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
