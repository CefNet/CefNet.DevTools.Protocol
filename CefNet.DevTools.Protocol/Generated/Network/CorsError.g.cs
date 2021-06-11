//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>The reason why request was blocked.</summary>
    public enum CorsError
    {
        DisallowedByMode = 1,
        InvalidResponse,
        WildcardOriginNotAllowed,
        MissingAllowOriginHeader,
        MultipleAllowOriginValues,
        InvalidAllowOriginValue,
        AllowOriginMismatch,
        InvalidAllowCredentials,
        CorsDisabledScheme,
        PreflightInvalidStatus,
        PreflightDisallowedRedirect,
        PreflightWildcardOriginNotAllowed,
        PreflightMissingAllowOriginHeader,
        PreflightMultipleAllowOriginValues,
        PreflightInvalidAllowOriginValue,
        PreflightAllowOriginMismatch,
        PreflightInvalidAllowCredentials,
        PreflightMissingAllowExternal,
        PreflightInvalidAllowExternal,
        InvalidAllowMethodsPreflightResponse,
        InvalidAllowHeadersPreflightResponse,
        MethodDisallowedByPreflightResponse,
        HeaderDisallowedByPreflightResponse,
        RedirectContainsCredentials,
        InsecurePrivateNetwork,
        NoCorsRedirectModeNotFollow,
    }
}
