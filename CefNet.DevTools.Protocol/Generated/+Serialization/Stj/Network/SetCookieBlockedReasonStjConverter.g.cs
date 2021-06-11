//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class SetCookieBlockedReasonStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.SetCookieBlockedReason>
    {
        public override CefNet.DevTools.Protocol.Network.SetCookieBlockedReason Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "InvalidDomain" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.InvalidDomain,
                "InvalidPrefix" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.InvalidPrefix,
                "OverwriteSecure" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.OverwriteSecure,
                "SamePartyConflictsWithOtherAttributes" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SamePartyConflictsWithOtherAttributes,
                "SamePartyFromCrossPartyContext" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SamePartyFromCrossPartyContext,
                "SameSiteLax" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SameSiteLax,
                "SameSiteNoneInsecure" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SameSiteNoneInsecure,
                "SameSiteStrict" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SameSiteStrict,
                "SameSiteUnspecifiedTreatedAsLax" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SameSiteUnspecifiedTreatedAsLax,
                "SchemefulSameSiteLax" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SchemefulSameSiteLax,
                "SchemefulSameSiteStrict" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SchemefulSameSiteStrict,
                "SchemefulSameSiteUnspecifiedTreatedAsLax" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SchemefulSameSiteUnspecifiedTreatedAsLax,
                "SchemeNotSupported" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SchemeNotSupported,
                "SecureOnly" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SecureOnly,
                "SyntaxError" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.SyntaxError,
                "UnknownError" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.UnknownError,
                "UserPreferences" => CefNet.DevTools.Protocol.Network.SetCookieBlockedReason.UserPreferences,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.SetCookieBlockedReason value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
