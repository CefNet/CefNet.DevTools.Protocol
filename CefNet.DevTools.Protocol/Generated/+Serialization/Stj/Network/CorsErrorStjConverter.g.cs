//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.Network
{
    internal sealed class CorsErrorStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.Network.CorsError>
    {
        public override CefNet.DevTools.Protocol.Network.CorsError Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "AllowOriginMismatch" => CefNet.DevTools.Protocol.Network.CorsError.AllowOriginMismatch,
                "CorsDisabledScheme" => CefNet.DevTools.Protocol.Network.CorsError.CorsDisabledScheme,
                "DisallowedByMode" => CefNet.DevTools.Protocol.Network.CorsError.DisallowedByMode,
                "HeaderDisallowedByPreflightResponse" => CefNet.DevTools.Protocol.Network.CorsError.HeaderDisallowedByPreflightResponse,
                "InsecurePrivateNetwork" => CefNet.DevTools.Protocol.Network.CorsError.InsecurePrivateNetwork,
                "InvalidAllowCredentials" => CefNet.DevTools.Protocol.Network.CorsError.InvalidAllowCredentials,
                "InvalidAllowHeadersPreflightResponse" => CefNet.DevTools.Protocol.Network.CorsError.InvalidAllowHeadersPreflightResponse,
                "InvalidAllowMethodsPreflightResponse" => CefNet.DevTools.Protocol.Network.CorsError.InvalidAllowMethodsPreflightResponse,
                "InvalidAllowOriginValue" => CefNet.DevTools.Protocol.Network.CorsError.InvalidAllowOriginValue,
                "InvalidResponse" => CefNet.DevTools.Protocol.Network.CorsError.InvalidResponse,
                "MethodDisallowedByPreflightResponse" => CefNet.DevTools.Protocol.Network.CorsError.MethodDisallowedByPreflightResponse,
                "MissingAllowOriginHeader" => CefNet.DevTools.Protocol.Network.CorsError.MissingAllowOriginHeader,
                "MultipleAllowOriginValues" => CefNet.DevTools.Protocol.Network.CorsError.MultipleAllowOriginValues,
                "NoCorsRedirectModeNotFollow" => CefNet.DevTools.Protocol.Network.CorsError.NoCorsRedirectModeNotFollow,
                "PreflightAllowOriginMismatch" => CefNet.DevTools.Protocol.Network.CorsError.PreflightAllowOriginMismatch,
                "PreflightDisallowedRedirect" => CefNet.DevTools.Protocol.Network.CorsError.PreflightDisallowedRedirect,
                "PreflightInvalidAllowCredentials" => CefNet.DevTools.Protocol.Network.CorsError.PreflightInvalidAllowCredentials,
                "PreflightInvalidAllowExternal" => CefNet.DevTools.Protocol.Network.CorsError.PreflightInvalidAllowExternal,
                "PreflightInvalidAllowOriginValue" => CefNet.DevTools.Protocol.Network.CorsError.PreflightInvalidAllowOriginValue,
                "PreflightInvalidStatus" => CefNet.DevTools.Protocol.Network.CorsError.PreflightInvalidStatus,
                "PreflightMissingAllowExternal" => CefNet.DevTools.Protocol.Network.CorsError.PreflightMissingAllowExternal,
                "PreflightMissingAllowOriginHeader" => CefNet.DevTools.Protocol.Network.CorsError.PreflightMissingAllowOriginHeader,
                "PreflightMultipleAllowOriginValues" => CefNet.DevTools.Protocol.Network.CorsError.PreflightMultipleAllowOriginValues,
                "PreflightWildcardOriginNotAllowed" => CefNet.DevTools.Protocol.Network.CorsError.PreflightWildcardOriginNotAllowed,
                "RedirectContainsCredentials" => CefNet.DevTools.Protocol.Network.CorsError.RedirectContainsCredentials,
                "WildcardOriginNotAllowed" => CefNet.DevTools.Protocol.Network.CorsError.WildcardOriginNotAllowed,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.Network.CorsError value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
