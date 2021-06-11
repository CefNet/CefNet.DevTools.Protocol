//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.HeadlessExperimental
{
    /// <summary>
    /// [Experimental] This domain provides experimental commands only supported in headless mode.
    /// </summary>
    public readonly struct HeadlessExperimentalApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal HeadlessExperimentalApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
        /// screenshot from the resulting frame. Requires that the target was created with enabled
        /// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
        /// https://goo.gl/3zHXhB for more background.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.HeadlessExperimental.BeginFrameResponse> BeginFrameAsync(
            CefNet.DevTools.Protocol.HeadlessExperimental.BeginFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeadlessExperimental.BeginFrameRequest, CefNet.DevTools.Protocol.HeadlessExperimental.BeginFrameResponse>(
                    "HeadlessExperimental.beginFrame", parameters, cancellationToken);
        }

        /// <summary>Disables headless events for the target.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "HeadlessExperimental.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables headless events for the target.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "HeadlessExperimental.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Issued when the target starts or stops needing BeginFrames.
        /// Deprecated. Issue beginFrame unconditionally instead and use result from
        /// beginFrame to detect whether the frames were suppressed.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.HeadlessExperimental.NeedsBeginFramesChangedEventArgs> NeedsBeginFramesChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.HeadlessExperimental.NeedsBeginFramesChangedEventArgs>("HeadlessExperimental.needsBeginFramesChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.HeadlessExperimental.NeedsBeginFramesChangedEventArgs>("HeadlessExperimental.needsBeginFramesChanged", value);
            }
        }
    }
}
