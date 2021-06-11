//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.PerformanceTimeline
{
    /// <summary>
    /// [Experimental] Reporting of performance timeline events, as specified in
    /// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
    /// </summary>
    public readonly struct PerformanceTimelineApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal PerformanceTimelineApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Previously buffered events would be reported before method returns.
        /// See also: timelineEventAdded
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            CefNet.DevTools.Protocol.PerformanceTimeline.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.PerformanceTimeline.EnableRequest>(
                    "PerformanceTimeline.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.PerformanceTimeline.TimelineEventAddedEventArgs> TimelineEventAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.PerformanceTimeline.TimelineEventAddedEventArgs>("PerformanceTimeline.timelineEventAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.PerformanceTimeline.TimelineEventAddedEventArgs>("PerformanceTimeline.timelineEventAdded", value);
            }
        }
    }
}
