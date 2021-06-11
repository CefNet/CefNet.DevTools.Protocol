//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Audits
{
    internal sealed class SameSiteCookieWarningReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason>
    {
        public override CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "WarnSameSiteLaxCrossDowngradeLax" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteLaxCrossDowngradeLax,
                "WarnSameSiteLaxCrossDowngradeStrict" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteLaxCrossDowngradeStrict,
                "WarnSameSiteNoneInsecure" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteNoneInsecure,
                "WarnSameSiteStrictCrossDowngradeLax" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteStrictCrossDowngradeLax,
                "WarnSameSiteStrictCrossDowngradeStrict" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteStrictCrossDowngradeStrict,
                "WarnSameSiteStrictLaxDowngradeStrict" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteStrictLaxDowngradeStrict,
                "WarnSameSiteUnspecifiedCrossSiteContext" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteUnspecifiedCrossSiteContext,
                "WarnSameSiteUnspecifiedLaxAllowUnsafe" => CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason.WarnSameSiteUnspecifiedLaxAllowUnsafe,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Audits.SameSiteCookieWarningReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
