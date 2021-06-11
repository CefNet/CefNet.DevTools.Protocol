//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.LayerTree
{
    /// <summary>[Experimental] </summary>
    public readonly struct LayerTreeApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal LayerTreeApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Provides the reasons why the given layer was composited.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.CompositingReasonsResponse> CompositingReasonsAsync(
            CefNet.DevTools.Protocol.LayerTree.CompositingReasonsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.CompositingReasonsRequest, CefNet.DevTools.Protocol.LayerTree.CompositingReasonsResponse>(
                    "LayerTree.compositingReasons", parameters, cancellationToken);
        }

        /// <summary>Disables compositing tree inspection.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "LayerTree.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables compositing tree inspection.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "LayerTree.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Returns the snapshot identifier.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.LoadSnapshotResponse> LoadSnapshotAsync(
            CefNet.DevTools.Protocol.LayerTree.LoadSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.LoadSnapshotRequest, CefNet.DevTools.Protocol.LayerTree.LoadSnapshotResponse>(
                    "LayerTree.loadSnapshot", parameters, cancellationToken);
        }

        /// <summary>Returns the layer snapshot identifier.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.MakeSnapshotResponse> MakeSnapshotAsync(
            CefNet.DevTools.Protocol.LayerTree.MakeSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.MakeSnapshotRequest, CefNet.DevTools.Protocol.LayerTree.MakeSnapshotResponse>(
                    "LayerTree.makeSnapshot", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.ProfileSnapshotResponse> ProfileSnapshotAsync(
            CefNet.DevTools.Protocol.LayerTree.ProfileSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.ProfileSnapshotRequest, CefNet.DevTools.Protocol.LayerTree.ProfileSnapshotResponse>(
                    "LayerTree.profileSnapshot", parameters, cancellationToken);
        }

        /// <summary>
        /// Releases layer snapshot captured by the back-end.
        /// </summary>
        public readonly System.Threading.Tasks.Task ReleaseSnapshotAsync(
            CefNet.DevTools.Protocol.LayerTree.ReleaseSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.ReleaseSnapshotRequest>(
                    "LayerTree.releaseSnapshot", parameters, cancellationToken);
        }

        /// <summary>
        /// Replays the layer snapshot and returns the resulting bitmap.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.ReplaySnapshotResponse> ReplaySnapshotAsync(
            CefNet.DevTools.Protocol.LayerTree.ReplaySnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.ReplaySnapshotRequest, CefNet.DevTools.Protocol.LayerTree.ReplaySnapshotResponse>(
                    "LayerTree.replaySnapshot", parameters, cancellationToken);
        }

        /// <summary>
        /// Replays the layer snapshot and returns canvas log.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.LayerTree.SnapshotCommandLogResponse> SnapshotCommandLogAsync(
            CefNet.DevTools.Protocol.LayerTree.SnapshotCommandLogRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.LayerTree.SnapshotCommandLogRequest, CefNet.DevTools.Protocol.LayerTree.SnapshotCommandLogResponse>(
                    "LayerTree.snapshotCommandLog", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.LayerTree.LayerPaintedEventArgs> LayerPainted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.LayerTree.LayerPaintedEventArgs>("LayerTree.layerPainted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.LayerTree.LayerPaintedEventArgs>("LayerTree.layerPainted", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.LayerTree.LayerTreeDidChangeEventArgs> LayerTreeDidChange 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.LayerTree.LayerTreeDidChangeEventArgs>("LayerTree.layerTreeDidChange", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.LayerTree.LayerTreeDidChangeEventArgs>("LayerTree.layerTreeDidChange", value);
            }
        }
    }
}
