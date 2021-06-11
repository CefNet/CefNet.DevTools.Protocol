//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Profiler
{
    public readonly struct ProfilerApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal ProfilerApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Disable counters collection.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableCountersAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.disableCounters", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Disable run time call stats collection.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableRuntimeCallStatsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.disableRuntimeCallStats", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enable counters collection.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableCountersAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.enableCounters", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enable run time call stats collection.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableRuntimeCallStatsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.enableRuntimeCallStats", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Collect coverage data for the current isolate. The coverage data may be incomplete due to
        /// garbage collection.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.GetBestEffortCoverageResponse> GetBestEffortCoverageAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.GetBestEffortCoverageResponse>(
                    "Profiler.getBestEffortCoverage", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] Retrieve counters.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.GetCountersResponse> GetCountersAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.GetCountersResponse>(
                    "Profiler.getCounters", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Retrieve run time call stats.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.GetRuntimeCallStatsResponse> GetRuntimeCallStatsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.GetRuntimeCallStatsResponse>(
                    "Profiler.getRuntimeCallStats", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetSamplingIntervalAsync(
            CefNet.DevTools.Protocol.Profiler.SetSamplingIntervalRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Profiler.SetSamplingIntervalRequest>(
                    "Profiler.setSamplingInterval", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StartAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.start", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code
        /// coverage may be incomplete. Enabling prevents running optimized code and resets execution
        /// counters.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.StartPreciseCoverageResponse> StartPreciseCoverageAsync(
            CefNet.DevTools.Protocol.Profiler.StartPreciseCoverageRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Profiler.StartPreciseCoverageRequest, CefNet.DevTools.Protocol.Profiler.StartPreciseCoverageResponse>(
                    "Profiler.startPreciseCoverage", parameters, cancellationToken);
        }

        /// <summary>[Experimental] Enable type profile.</summary>
        public readonly System.Threading.Tasks.Task StartTypeProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.startTypeProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.StopResponse> StopAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.StopResponse>(
                    "Profiler.stop", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows
        /// executing optimized code.
        /// </summary>
        public readonly System.Threading.Tasks.Task StopPreciseCoverageAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.stopPreciseCoverage", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Disable type profile. Disabling releases type profile data collected so far.
        /// </summary>
        public readonly System.Threading.Tasks.Task StopTypeProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Profiler.stopTypeProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Collect coverage data for the current isolate, and resets execution counters. Precise code
        /// coverage needs to have started.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.TakePreciseCoverageResponse> TakePreciseCoverageAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.TakePreciseCoverageResponse>(
                    "Profiler.takePreciseCoverage", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] Collect type profile.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Profiler.TakeTypeProfileResponse> TakeTypeProfileAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Profiler.TakeTypeProfileResponse>(
                    "Profiler.takeTypeProfile", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileFinishedEventArgs> ConsoleProfileFinished 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileFinishedEventArgs>("Profiler.consoleProfileFinished", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileFinishedEventArgs>("Profiler.consoleProfileFinished", value);
            }
        }

        /// <summary>
        /// Sent when new profile recording is started using console.profile() call.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileStartedEventArgs> ConsoleProfileStarted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileStartedEventArgs>("Profiler.consoleProfileStarted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Profiler.ConsoleProfileStartedEventArgs>("Profiler.consoleProfileStarted", value);
            }
        }

        /// <summary>
        /// [Experimental] Reports coverage delta since the last poll (either from an event like this, or from
        /// `takePreciseCoverage` for the current isolate. May only be sent if precise code
        /// coverage has been started. This event can be trigged by the embedder to, for example,
        /// trigger collection of coverage data immediatelly at a certain point in time.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Profiler.PreciseCoverageDeltaUpdateEventArgs> PreciseCoverageDeltaUpdate 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Profiler.PreciseCoverageDeltaUpdateEventArgs>("Profiler.preciseCoverageDeltaUpdate", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Profiler.PreciseCoverageDeltaUpdateEventArgs>("Profiler.preciseCoverageDeltaUpdate", value);
            }
        }
    }
}
