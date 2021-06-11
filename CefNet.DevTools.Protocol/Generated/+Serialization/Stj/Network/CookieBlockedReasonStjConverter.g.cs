//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CookieBlockedReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CookieBlockedReason>
    {
        public override CefNet.DevTools.Protocol.Network.CookieBlockedReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "DomainMismatch" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.DomainMismatch,
                "NotOnPath" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.NotOnPath,
                "SamePartyFromCrossPartyContext" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SamePartyFromCrossPartyContext,
                "SameSiteLax" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SameSiteLax,
                "SameSiteNoneInsecure" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SameSiteNoneInsecure,
                "SameSiteStrict" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SameSiteStrict,
                "SameSiteUnspecifiedTreatedAsLax" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SameSiteUnspecifiedTreatedAsLax,
                "SchemefulSameSiteLax" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SchemefulSameSiteLax,
                "SchemefulSameSiteStrict" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SchemefulSameSiteStrict,
                "SchemefulSameSiteUnspecifiedTreatedAsLax" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SchemefulSameSiteUnspecifiedTreatedAsLax,
                "SecureOnly" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.SecureOnly,
                "UnknownError" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.UnknownError,
                "UserPreferences" => CefNet.DevTools.Protocol.Network.CookieBlockedReason.UserPreferences,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CookieBlockedReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
