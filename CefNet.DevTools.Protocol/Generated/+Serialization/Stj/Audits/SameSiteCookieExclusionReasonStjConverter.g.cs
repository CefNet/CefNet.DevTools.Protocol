//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class SameSiteCookieExclusionReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason>
    {
        public override CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "ExcludeInvalidSameParty" => CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason.ExcludeInvalidSameParty,
                "ExcludeSameSiteLax" => CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason.ExcludeSameSiteLax,
                "ExcludeSameSiteNoneInsecure" => CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason.ExcludeSameSiteNoneInsecure,
                "ExcludeSameSiteStrict" => CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason.ExcludeSameSiteStrict,
                "ExcludeSameSiteUnspecifiedTreatedAsLax" => CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason.ExcludeSameSiteUnspecifiedTreatedAsLax,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.SameSiteCookieExclusionReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
