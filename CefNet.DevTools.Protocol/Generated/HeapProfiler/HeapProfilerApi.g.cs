//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.HeapProfiler
{
    /// <summary>[Experimental] </summary>
    public readonly struct HeapProfilerApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal HeapProfilerApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details
        /// $x functions).
        /// </summary>
        public readonly System.Threading.Tasks.Task AddInspectedHeapObjectAsync(
            CefNet.DevTools.Protocol.HeapProfiler.AddInspectedHeapObjectRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.AddInspectedHeapObjectRequest>(
                    "HeapProfiler.addInspectedHeapObject", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task CollectGarbageAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "HeapProfiler.collectGarbage", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "HeapProfiler.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "HeapProfiler.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.HeapProfiler.GetHeapObjectIdResponse> GetHeapObjectIdAsync(
            CefNet.DevTools.Protocol.HeapProfiler.GetHeapObjectIdRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.GetHeapObjectIdRequest, CefNet.DevTools.Protocol.HeapProfiler.GetHeapObjectIdResponse>(
                    "HeapProfiler.getHeapObjectId", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.HeapProfiler.GetObjectByHeapObjectIdResponse> GetObjectByHeapObjectIdAsync(
            CefNet.DevTools.Protocol.HeapProfiler.GetObjectByHeapObjectIdRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.GetObjectByHeapObjectIdRequest, CefNet.DevTools.Protocol.HeapProfiler.GetObjectByHeapObjectIdResponse>(
                    "HeapProfiler.getObjectByHeapObjectId", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.HeapProfiler.GetSamplingProfileResponse> GetSamplingProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.HeapProfiler.GetSamplingProfileResponse>(
                    "HeapProfiler.getSamplingProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StartSamplingAsync(
            CefNet.DevTools.Protocol.HeapProfiler.StartSamplingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.StartSamplingRequest>(
                    "HeapProfiler.startSampling", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StartTrackingHeapObjectsAsync(
            CefNet.DevTools.Protocol.HeapProfiler.StartTrackingHeapObjectsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.StartTrackingHeapObjectsRequest>(
                    "HeapProfiler.startTrackingHeapObjects", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.HeapProfiler.StopSamplingResponse> StopSamplingAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.HeapProfiler.StopSamplingResponse>(
                    "HeapProfiler.stopSampling", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StopTrackingHeapObjectsAsync(
            CefNet.DevTools.Protocol.HeapProfiler.StopTrackingHeapObjectsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.StopTrackingHeapObjectsRequest>(
                    "HeapProfiler.stopTrackingHeapObjects", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task TakeHeapSnapshotAsync(
            CefNet.DevTools.Protocol.HeapProfiler.TakeHeapSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.HeapProfiler.TakeHeapSnapshotRequest>(
                    "HeapProfiler.takeHeapSnapshot", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.HeapProfiler.AddHeapSnapshotChunkEventArgs> AddHeapSnapshotChunk 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.HeapProfiler.AddHeapSnapshotChunkEventArgs>("HeapProfiler.addHeapSnapshotChunk", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.HeapProfiler.AddHeapSnapshotChunkEventArgs>("HeapProfiler.addHeapSnapshotChunk", value);
            }
        }

        /// <summary>
        /// If heap objects tracking has been started then backend may send update for one or more fragments
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.HeapProfiler.HeapStatsUpdateEventArgs> HeapStatsUpdate 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.HeapProfiler.HeapStatsUpdateEventArgs>("HeapProfiler.heapStatsUpdate", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.HeapProfiler.HeapStatsUpdateEventArgs>("HeapProfiler.heapStatsUpdate", value);
            }
        }

        /// <summary>
        /// If heap objects tracking has been started then backend regularly sends a current value for last
        /// seen object id and corresponding timestamp. If the were changes in the heap since last event
        /// then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.HeapProfiler.LastSeenObjectIdEventArgs> LastSeenObjectId 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.HeapProfiler.LastSeenObjectIdEventArgs>("HeapProfiler.lastSeenObjectId", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.HeapProfiler.LastSeenObjectIdEventArgs>("HeapProfiler.lastSeenObjectId", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.HeapProfiler.ReportHeapSnapshotProgressEventArgs> ReportHeapSnapshotProgress 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.HeapProfiler.ReportHeapSnapshotProgressEventArgs>("HeapProfiler.reportHeapSnapshotProgress", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.HeapProfiler.ReportHeapSnapshotProgressEventArgs>("HeapProfiler.reportHeapSnapshotProgress", value);
            }
        }

        public readonly event System.EventHandler<System.EventArgs> ResetProfiles 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("HeapProfiler.resetProfiles", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("HeapProfiler.resetProfiles", value);
            }
        }
    }
}
