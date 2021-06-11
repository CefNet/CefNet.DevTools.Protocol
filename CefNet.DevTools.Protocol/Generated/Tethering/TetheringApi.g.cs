//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Tethering
{
    /// <summary>
    /// [Experimental] The Tethering domain defines methods and events for browser port binding.
    /// </summary>
    public readonly struct TetheringApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal TetheringApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Request browser port binding.</summary>
        public readonly System.Threading.Tasks.Task BindAsync(
            CefNet.DevTools.Protocol.Tethering.BindRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Tethering.BindRequest>(
                    "Tethering.bind", parameters, cancellationToken);
        }

        /// <summary>Request browser port unbinding.</summary>
        public readonly System.Threading.Tasks.Task UnbindAsync(
            CefNet.DevTools.Protocol.Tethering.UnbindRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Tethering.UnbindRequest>(
                    "Tethering.unbind", parameters, cancellationToken);
        }

        /// <summary>
        /// Informs that port was successfully bound and got a specified connection id.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Tethering.AcceptedEventArgs> Accepted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Tethering.AcceptedEventArgs>("Tethering.accepted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Tethering.AcceptedEventArgs>("Tethering.accepted", value);
            }
        }
    }
}
