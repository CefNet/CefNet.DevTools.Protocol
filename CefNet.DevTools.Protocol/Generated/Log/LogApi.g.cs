//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Log
{
    /// <summary>Provides access to log entries.</summary>
    public readonly struct LogApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal LogApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Clears the log.</summary>
        public readonly System.Threading.Tasks.Task ClearAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Log.clear", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Disables log domain, prevents further log entries from being reported to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Log.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables log domain, sends the entries collected so far to the client by means of the
        /// `entryAdded` notification.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Log.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>start violation reporting.</summary>
        public readonly System.Threading.Tasks.Task StartViolationsReportAsync(
            CefNet.DevTools.Protocol.Log.StartViolationsReportRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Log.StartViolationsReportRequest>(
                    "Log.startViolationsReport", parameters, cancellationToken);
        }

        /// <summary>Stop violation reporting.</summary>
        public readonly System.Threading.Tasks.Task StopViolationsReportAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Log.stopViolationsReport", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Issued when new message was logged.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Log.EntryAddedEventArgs> EntryAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Log.EntryAddedEventArgs>("Log.entryAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Log.EntryAddedEventArgs>("Log.entryAdded", value);
            }
        }
    }
}
