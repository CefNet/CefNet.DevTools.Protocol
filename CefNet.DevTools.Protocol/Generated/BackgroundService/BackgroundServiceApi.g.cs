//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.BackgroundService
{
    /// <summary>
    /// [Experimental] Defines events for background web platform features.
    /// </summary>
    public readonly struct BackgroundServiceApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal BackgroundServiceApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Clears all stored data for the service.</summary>
        public readonly System.Threading.Tasks.Task ClearEventsAsync(
            CefNet.DevTools.Protocol.BackgroundService.ClearEventsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.BackgroundService.ClearEventsRequest>(
                    "BackgroundService.clearEvents", parameters, cancellationToken);
        }

        /// <summary>Set the recording state for the service.</summary>
        public readonly System.Threading.Tasks.Task SetRecordingAsync(
            CefNet.DevTools.Protocol.BackgroundService.SetRecordingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.BackgroundService.SetRecordingRequest>(
                    "BackgroundService.setRecording", parameters, cancellationToken);
        }

        /// <summary>Enables event updates for the service.</summary>
        public readonly System.Threading.Tasks.Task StartObservingAsync(
            CefNet.DevTools.Protocol.BackgroundService.StartObservingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.BackgroundService.StartObservingRequest>(
                    "BackgroundService.startObserving", parameters, cancellationToken);
        }

        /// <summary>Disables event updates for the service.</summary>
        public readonly System.Threading.Tasks.Task StopObservingAsync(
            CefNet.DevTools.Protocol.BackgroundService.StopObservingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.BackgroundService.StopObservingRequest>(
                    "BackgroundService.stopObserving", parameters, cancellationToken);
        }

        /// <summary>
        /// Called with all existing backgroundServiceEvents when enabled, and all new
        /// events afterwards if enabled and recording.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.BackgroundService.BackgroundServiceEventReceivedEventArgs> BackgroundServiceEventReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.BackgroundService.BackgroundServiceEventReceivedEventArgs>("BackgroundService.backgroundServiceEventReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.BackgroundService.BackgroundServiceEventReceivedEventArgs>("BackgroundService.backgroundServiceEventReceived", value);
            }
        }

        /// <summary>
        /// Called when the recording state for the service has been updated.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.BackgroundService.RecordingStateChangedEventArgs> RecordingStateChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.BackgroundService.RecordingStateChangedEventArgs>("BackgroundService.recordingStateChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.BackgroundService.RecordingStateChangedEventArgs>("BackgroundService.recordingStateChanged", value);
            }
        }
    }
}
