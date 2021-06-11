//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.DOMSnapshot
{
    /// <summary>
    /// [Experimental] This domain facilitates obtaining document snapshots with DOM, layout, and style information.
    /// </summary>
    public readonly struct DOMSnapshotApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DOMSnapshotApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
        /// template contents, and imported documents) in a flattened array, as well as layout and
        /// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
        /// flattened.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOMSnapshot.CaptureSnapshotResponse> CaptureSnapshotAsync(
            CefNet.DevTools.Protocol.DOMSnapshot.CaptureSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMSnapshot.CaptureSnapshotRequest, CefNet.DevTools.Protocol.DOMSnapshot.CaptureSnapshotResponse>(
                    "DOMSnapshot.captureSnapshot", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables DOM snapshot agent for the given page.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOMSnapshot.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables DOM snapshot agent for the given page.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOMSnapshot.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Returns a document snapshot, including the full DOM tree of the root node (including iframes,
        /// template contents, and imported documents) in a flattened array, as well as layout and
        /// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
        /// flattened.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOMSnapshot.GetSnapshotResponse> GetSnapshotAsync(
            CefNet.DevTools.Protocol.DOMSnapshot.GetSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMSnapshot.GetSnapshotRequest, CefNet.DevTools.Protocol.DOMSnapshot.GetSnapshotResponse>(
                    "DOMSnapshot.getSnapshot", parameters, cancellationToken);
        }
    }
}
