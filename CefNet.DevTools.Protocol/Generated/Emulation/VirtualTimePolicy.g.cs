//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Emulation
{
    /// <summary>
    /// [Experimental] advance: If the scheduler runs out of immediate work, the virtual time base may fast forward to
    /// allow the next delayed task (if any) to run; pause: The virtual time base may not advance;
    /// pauseIfNetworkFetchesPending: The virtual time base may not advance if there are any pending
    /// resource fetches.
    /// </summary>
    public enum VirtualTimePolicy
    {
        Advance = 1,
        Pause,
        PauseIfNetworkFetchesPending,
    }
}
