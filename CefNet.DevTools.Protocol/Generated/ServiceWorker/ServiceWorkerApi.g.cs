//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.ServiceWorker
{
    /// <summary>[Experimental] </summary>
    public readonly struct ServiceWorkerApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal ServiceWorkerApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        public readonly System.Threading.Tasks.Task DeliverPushMessageAsync(
            CefNet.DevTools.Protocol.ServiceWorker.DeliverPushMessageRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.DeliverPushMessageRequest>(
                    "ServiceWorker.deliverPushMessage", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "ServiceWorker.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task DispatchPeriodicSyncEventAsync(
            CefNet.DevTools.Protocol.ServiceWorker.DispatchPeriodicSyncEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.DispatchPeriodicSyncEventRequest>(
                    "ServiceWorker.dispatchPeriodicSyncEvent", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task DispatchSyncEventAsync(
            CefNet.DevTools.Protocol.ServiceWorker.DispatchSyncEventRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.DispatchSyncEventRequest>(
                    "ServiceWorker.dispatchSyncEvent", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "ServiceWorker.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task InspectWorkerAsync(
            CefNet.DevTools.Protocol.ServiceWorker.InspectWorkerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.InspectWorkerRequest>(
                    "ServiceWorker.inspectWorker", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetForceUpdateOnPageLoadAsync(
            CefNet.DevTools.Protocol.ServiceWorker.SetForceUpdateOnPageLoadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.SetForceUpdateOnPageLoadRequest>(
                    "ServiceWorker.setForceUpdateOnPageLoad", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SkipWaitingAsync(
            CefNet.DevTools.Protocol.ServiceWorker.SkipWaitingRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.SkipWaitingRequest>(
                    "ServiceWorker.skipWaiting", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StartWorkerAsync(
            CefNet.DevTools.Protocol.ServiceWorker.StartWorkerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.StartWorkerRequest>(
                    "ServiceWorker.startWorker", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StopAllWorkersAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "ServiceWorker.stopAllWorkers", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task StopWorkerAsync(
            CefNet.DevTools.Protocol.ServiceWorker.StopWorkerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.StopWorkerRequest>(
                    "ServiceWorker.stopWorker", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task UnregisterAsync(
            CefNet.DevTools.Protocol.ServiceWorker.UnregisterRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.UnregisterRequest>(
                    "ServiceWorker.unregister", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task UpdateRegistrationAsync(
            CefNet.DevTools.Protocol.ServiceWorker.UpdateRegistrationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ServiceWorker.UpdateRegistrationRequest>(
                    "ServiceWorker.updateRegistration", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerErrorReportedEventArgs> WorkerErrorReported 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerErrorReportedEventArgs>("ServiceWorker.workerErrorReported", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerErrorReportedEventArgs>("ServiceWorker.workerErrorReported", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerRegistrationUpdatedEventArgs> WorkerRegistrationUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerRegistrationUpdatedEventArgs>("ServiceWorker.workerRegistrationUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerRegistrationUpdatedEventArgs>("ServiceWorker.workerRegistrationUpdated", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerVersionUpdatedEventArgs> WorkerVersionUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerVersionUpdatedEventArgs>("ServiceWorker.workerVersionUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.ServiceWorker.WorkerVersionUpdatedEventArgs>("ServiceWorker.workerVersionUpdated", value);
            }
        }
    }
}
