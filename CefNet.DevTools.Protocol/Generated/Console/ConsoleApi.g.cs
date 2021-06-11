//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Console
{
    /// <summary>
    /// [Deprecated] This domain is deprecated - use Runtime or Log instead.
    /// </summary>
    [Obsolete]
    public readonly struct ConsoleApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal ConsoleApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Does nothing.</summary>
        public readonly System.Threading.Tasks.Task ClearMessagesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Console.clearMessages", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Disables console domain, prevents further console messages from being reported to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Console.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables console domain, sends the messages collected so far to the client by means of the
        /// `messageAdded` notification.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Console.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Issued when new console message is added.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Console.MessageAddedEventArgs> MessageAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Console.MessageAddedEventArgs>("Console.messageAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Console.MessageAddedEventArgs>("Console.messageAdded", value);
            }
        }
    }
}
