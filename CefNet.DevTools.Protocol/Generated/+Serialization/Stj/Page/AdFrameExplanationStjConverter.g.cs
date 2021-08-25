//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class AdFrameExplanationStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.AdFrameExplanation>
    {
        public override CefNet.DevTools.Protocol.Page.AdFrameExplanation Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "CreatedByAdScript" => CefNet.DevTools.Protocol.Page.AdFrameExplanation.CreatedByAdScript,
                "MatchedBlockingRule" => CefNet.DevTools.Protocol.Page.AdFrameExplanation.MatchedBlockingRule,
                "ParentIsAd" => CefNet.DevTools.Protocol.Page.AdFrameExplanation.ParentIsAd,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.AdFrameExplanation value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
