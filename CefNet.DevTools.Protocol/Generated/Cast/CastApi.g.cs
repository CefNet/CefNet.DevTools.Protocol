//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Cast
{
    /// <summary>
    /// [Experimental] A domain for interacting with Cast, Presentation API, and Remote Playback API
    /// functionalities.
    /// </summary>
    public readonly struct CastApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal CastApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Stops observing for sinks and issues.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Cast.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Starts observing for sinks that can be used for tab mirroring, and if set,
        /// sinks compatible with |presentationUrl| as well. When sinks are found, a
        /// |sinksUpdated| event is fired.
        /// Also starts observing for issue messages. When an issue is added or removed,
        /// an |issueUpdated| event is fired.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            CefNet.DevTools.Protocol.Cast.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Cast.EnableRequest>(
                    "Cast.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets a sink to be used when the web page requests the browser to choose a
        /// sink via Presentation API, Remote Playback API, or Cast SDK.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetSinkToUseAsync(
            CefNet.DevTools.Protocol.Cast.SetSinkToUseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Cast.SetSinkToUseRequest>(
                    "Cast.setSinkToUse", parameters, cancellationToken);
        }

        /// <summary>Starts mirroring the tab to the sink.</summary>
        public readonly System.Threading.Tasks.Task StartTabMirroringAsync(
            CefNet.DevTools.Protocol.Cast.StartTabMirroringRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Cast.StartTabMirroringRequest>(
                    "Cast.startTabMirroring", parameters, cancellationToken);
        }

        /// <summary>
        /// Stops the active Cast session on the sink.
        /// </summary>
        public readonly System.Threading.Tasks.Task StopCastingAsync(
            CefNet.DevTools.Protocol.Cast.StopCastingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Cast.StopCastingRequest>(
                    "Cast.stopCasting", parameters, cancellationToken);
        }

        /// <summary>
        /// This is fired whenever the outstanding issue/error message changes.
        /// |issueMessage| is empty if there is no issue.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Cast.IssueUpdatedEventArgs> IssueUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Cast.IssueUpdatedEventArgs>("Cast.issueUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Cast.IssueUpdatedEventArgs>("Cast.issueUpdated", value);
            }
        }

        /// <summary>
        /// This is fired whenever the list of available sinks changes. A sink is a
        /// device or a software surface that you can cast to.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Cast.SinksUpdatedEventArgs> SinksUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Cast.SinksUpdatedEventArgs>("Cast.sinksUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Cast.SinksUpdatedEventArgs>("Cast.sinksUpdated", value);
            }
        }
    }
}
