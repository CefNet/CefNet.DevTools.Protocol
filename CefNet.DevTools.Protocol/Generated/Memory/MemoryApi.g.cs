//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Memory
{
    /// <summary>[Experimental] </summary>
    public readonly struct MemoryApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal MemoryApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Simulate OomIntervention by purging V8 memory.
        /// </summary>
        public readonly System.Threading.Tasks.Task ForciblyPurgeJavaScriptMemoryAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Memory.forciblyPurgeJavaScriptMemory", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Retrieve native memory allocations profile
        /// collected since renderer process startup.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Memory.GetAllTimeSamplingProfileResponse> GetAllTimeSamplingProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Memory.GetAllTimeSamplingProfileResponse>(
                    "Memory.getAllTimeSamplingProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Retrieve native memory allocations profile
        /// collected since browser process startup.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Memory.GetBrowserSamplingProfileResponse> GetBrowserSamplingProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Memory.GetBrowserSamplingProfileResponse>(
                    "Memory.getBrowserSamplingProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Memory.GetDOMCountersResponse> GetDOMCountersAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Memory.GetDOMCountersResponse>(
                    "Memory.getDOMCounters", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Retrieve native memory allocations profile collected since last
        /// `startSampling` call.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Memory.GetSamplingProfileResponse> GetSamplingProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Memory.GetSamplingProfileResponse>(
                    "Memory.getSamplingProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task PrepareForLeakDetectionAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Memory.prepareForLeakDetection", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enable/disable suppressing memory pressure notifications in all processes.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPressureNotificationsSuppressedAsync(
            CefNet.DevTools.Protocol.Memory.SetPressureNotificationsSuppressedRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Memory.SetPressureNotificationsSuppressedRequest>(
                    "Memory.setPressureNotificationsSuppressed", parameters, cancellationToken);
        }

        /// <summary>
        /// Simulate a memory pressure notification in all processes.
        /// </summary>
        public readonly System.Threading.Tasks.Task SimulatePressureNotificationAsync(
            CefNet.DevTools.Protocol.Memory.SimulatePressureNotificationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Memory.SimulatePressureNotificationRequest>(
                    "Memory.simulatePressureNotification", parameters, cancellationToken);
        }

        /// <summary>Start collecting native memory profile.</summary>
        public readonly System.Threading.Tasks.Task StartSamplingAsync(
            CefNet.DevTools.Protocol.Memory.StartSamplingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Memory.StartSamplingRequest>(
                    "Memory.startSampling", parameters, cancellationToken);
        }

        /// <summary>Stop collecting native memory profile.</summary>
        public readonly System.Threading.Tasks.Task StopSamplingAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Memory.stopSampling", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }
    }
}
