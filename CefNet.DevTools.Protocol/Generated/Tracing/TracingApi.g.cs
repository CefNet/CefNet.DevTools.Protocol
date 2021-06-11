//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Tracing
{
    /// <summary>[Experimental] </summary>
    public readonly struct TracingApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal TracingApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Stop trace events collection.</summary>
        public readonly System.Threading.Tasks.Task EndAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Tracing.end", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Gets supported tracing categories.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Tracing.GetCategoriesResponse> GetCategoriesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Tracing.GetCategoriesResponse>(
                    "Tracing.getCategories", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Record a clock sync marker in the trace.</summary>
        public readonly System.Threading.Tasks.Task RecordClockSyncMarkerAsync(
            CefNet.DevTools.Protocol.Tracing.RecordClockSyncMarkerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Tracing.RecordClockSyncMarkerRequest>(
                    "Tracing.recordClockSyncMarker", parameters, cancellationToken);
        }

        /// <summary>Request a global memory dump.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Tracing.RequestMemoryDumpResponse> RequestMemoryDumpAsync(
            CefNet.DevTools.Protocol.Tracing.RequestMemoryDumpRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Tracing.RequestMemoryDumpRequest, CefNet.DevTools.Protocol.Tracing.RequestMemoryDumpResponse>(
                    "Tracing.requestMemoryDump", parameters, cancellationToken);
        }

        /// <summary>Start trace events collection.</summary>
        public readonly System.Threading.Tasks.Task StartAsync(
            CefNet.DevTools.Protocol.Tracing.StartRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Tracing.StartRequest>(
                    "Tracing.start", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Tracing.BufferUsageEventArgs> BufferUsage 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Tracing.BufferUsageEventArgs>("Tracing.bufferUsage", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Tracing.BufferUsageEventArgs>("Tracing.bufferUsage", value);
            }
        }

        /// <summary>
        /// Contains an bucket of collected trace events. When tracing is stopped collected events will be
        /// send as a sequence of dataCollected events followed by tracingComplete event.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Tracing.DataCollectedEventArgs> DataCollected 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Tracing.DataCollectedEventArgs>("Tracing.dataCollected", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Tracing.DataCollectedEventArgs>("Tracing.dataCollected", value);
            }
        }

        /// <summary>
        /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
        /// delivered via dataCollected events.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Tracing.TracingCompleteEventArgs> TracingComplete 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Tracing.TracingCompleteEventArgs>("Tracing.tracingComplete", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Tracing.TracingCompleteEventArgs>("Tracing.tracingComplete", value);
            }
        }
    }
}
