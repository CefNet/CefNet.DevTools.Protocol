//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Inspector
{
    /// <summary>[Experimental] </summary>
    public readonly struct InspectorApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal InspectorApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables inspector domain notifications.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Inspector.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables inspector domain notifications.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Inspector.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Inspector.DetachedEventArgs> Detached 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Inspector.DetachedEventArgs>("Inspector.detached", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Inspector.DetachedEventArgs>("Inspector.detached", value);
            }
        }

        /// <summary>Fired when debugging target has crashed</summary>
        public readonly event System.EventHandler<System.EventArgs> TargetCrashed 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Inspector.targetCrashed", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Inspector.targetCrashed", value);
            }
        }

        /// <summary>
        /// Fired when debugging target has reloaded after crash
        /// </summary>
        public readonly event System.EventHandler<System.EventArgs> TargetReloadedAfterCrash 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Inspector.targetReloadedAfterCrash", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Inspector.targetReloadedAfterCrash", value);
            }
        }
    }
}
