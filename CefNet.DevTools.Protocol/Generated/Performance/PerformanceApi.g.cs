//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Performance
{
    public readonly struct PerformanceApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal PerformanceApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Disable collecting and reporting metrics.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Performance.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enable collecting and reporting metrics.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            CefNet.DevTools.Protocol.Performance.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Performance.EnableRequest>(
                    "Performance.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Retrieve current values of run-time metrics.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Performance.GetMetricsResponse> GetMetricsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Performance.GetMetricsResponse>(
                    "Performance.getMetrics", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Sets time domain to use for collecting and reporting duration metrics.
        /// Note that this must be called before enabling metrics collection. Calling
        /// this method while metrics collection is enabled returns an error.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetTimeDomainAsync(
            CefNet.DevTools.Protocol.Performance.SetTimeDomainRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Performance.SetTimeDomainRequest>(
                    "Performance.setTimeDomain", parameters, cancellationToken);
        }

        /// <summary>Current values of the metrics.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Performance.MetricsEventArgs> Metrics 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Performance.MetricsEventArgs>("Performance.metrics", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Performance.MetricsEventArgs>("Performance.metrics", value);
            }
        }
    }
}
