//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// [Experimental] Represents the source scheme of the origin that originally set the cookie.
    /// A value of "Unset" allows protocol clients to emulate legacy cookie scope for the scheme.
    /// This is a temporary ability and it will be removed in the future.
    /// </summary>
    public enum CookieSourceScheme
    {
        Unset = 1,
        NonSecure,
        Secure,
    }
}
