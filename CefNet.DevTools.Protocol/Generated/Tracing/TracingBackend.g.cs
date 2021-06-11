//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Tracing
{
    /// <summary>
    /// Backend type to use for tracing. `chrome` uses the Chrome-integrated
    /// tracing service and is supported on all platforms. `system` is only
    /// supported on Chrome OS and uses the Perfetto system tracing service.
    /// `auto` chooses `system` when the perfettoConfig provided to Tracing.start
    /// specifies at least one non-Chrome data source; otherwise uses `chrome`.
    /// </summary>
    public enum TracingBackend
    {
        Auto = 1,
        Chrome,
        System,
    }
}
