//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Page
{
    internal sealed class OriginTrialUsageRestrictionStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction>
    {
        public override CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "None" => CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction.None,
                "Subset" => CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction.Subset,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Page.OriginTrialUsageRestriction value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
