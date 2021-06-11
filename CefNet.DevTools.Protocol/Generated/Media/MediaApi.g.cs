//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Media
{
    /// <summary>
    /// [Experimental] This domain allows detailed inspection of media elements
    /// </summary>
    public readonly struct MediaApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal MediaApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Disables the Media domain.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Media.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables the Media domain</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Media.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Send a list of any errors that need to be delivered.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Media.PlayerErrorsRaisedEventArgs> PlayerErrorsRaised 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Media.PlayerErrorsRaisedEventArgs>("Media.playerErrorsRaised", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Media.PlayerErrorsRaisedEventArgs>("Media.playerErrorsRaised", value);
            }
        }

        /// <summary>
        /// Send events as a list, allowing them to be batched on the browser for less
        /// congestion. If batched, events must ALWAYS be in chronological order.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Media.PlayerEventsAddedEventArgs> PlayerEventsAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Media.PlayerEventsAddedEventArgs>("Media.playerEventsAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Media.PlayerEventsAddedEventArgs>("Media.playerEventsAdded", value);
            }
        }

        /// <summary>
        /// Send a list of any messages that need to be delivered.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Media.PlayerMessagesLoggedEventArgs> PlayerMessagesLogged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Media.PlayerMessagesLoggedEventArgs>("Media.playerMessagesLogged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Media.PlayerMessagesLoggedEventArgs>("Media.playerMessagesLogged", value);
            }
        }

        /// <summary>
        /// This can be called multiple times, and can be used to set / override /
        /// remove player properties. A null propValue indicates removal.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Media.PlayerPropertiesChangedEventArgs> PlayerPropertiesChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Media.PlayerPropertiesChangedEventArgs>("Media.playerPropertiesChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Media.PlayerPropertiesChangedEventArgs>("Media.playerPropertiesChanged", value);
            }
        }

        /// <summary>
        /// Called whenever a player is created, or when a new agent joins and receives
        /// a list of active players. If an agent is restored, it will receive the full
        /// list of player ids and all events again.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Media.PlayersCreatedEventArgs> PlayersCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Media.PlayersCreatedEventArgs>("Media.playersCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Media.PlayersCreatedEventArgs>("Media.playersCreated", value);
            }
        }
    }
}
