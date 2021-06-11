//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.DOMStorage
{
    /// <summary>
    /// [Experimental] Query and modify DOM storage.
    /// </summary>
    public readonly struct DOMStorageApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DOMStorageApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        public readonly System.Threading.Tasks.Task ClearAsync(
            CefNet.DevTools.Protocol.DOMStorage.ClearRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMStorage.ClearRequest>(
                    "DOMStorage.clear", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables storage tracking, prevents storage events from being sent to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOMStorage.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables storage tracking, storage events will now be delivered to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "DOMStorage.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.DOMStorage.GetDOMStorageItemsResponse> GetDOMStorageItemsAsync(
            CefNet.DevTools.Protocol.DOMStorage.GetDOMStorageItemsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMStorage.GetDOMStorageItemsRequest, CefNet.DevTools.Protocol.DOMStorage.GetDOMStorageItemsResponse>(
                    "DOMStorage.getDOMStorageItems", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task RemoveDOMStorageItemAsync(
            CefNet.DevTools.Protocol.DOMStorage.RemoveDOMStorageItemRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMStorage.RemoveDOMStorageItemRequest>(
                    "DOMStorage.removeDOMStorageItem", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task SetDOMStorageItemAsync(
            CefNet.DevTools.Protocol.DOMStorage.SetDOMStorageItemRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.DOMStorage.SetDOMStorageItemRequest>(
                    "DOMStorage.setDOMStorageItem", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemAddedEventArgs> DomStorageItemAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemAddedEventArgs>("DOMStorage.domStorageItemAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemAddedEventArgs>("DOMStorage.domStorageItemAdded", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemRemovedEventArgs> DomStorageItemRemoved 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemRemovedEventArgs>("DOMStorage.domStorageItemRemoved", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemRemovedEventArgs>("DOMStorage.domStorageItemRemoved", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemsClearedEventArgs> DomStorageItemsCleared 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemsClearedEventArgs>("DOMStorage.domStorageItemsCleared", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemsClearedEventArgs>("DOMStorage.domStorageItemsCleared", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemUpdatedEventArgs> DomStorageItemUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemUpdatedEventArgs>("DOMStorage.domStorageItemUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.DOMStorage.DomStorageItemUpdatedEventArgs>("DOMStorage.domStorageItemUpdated", value);
            }
        }
    }
}
