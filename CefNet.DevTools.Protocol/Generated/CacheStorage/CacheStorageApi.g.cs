//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.CacheStorage
{
    /// <summary>[Experimental] </summary>
    public readonly struct CacheStorageApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal CacheStorageApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Deletes a cache.</summary>
        public readonly System.Threading.Tasks.Task DeleteCacheAsync(
            CefNet.DevTools.Protocol.CacheStorage.DeleteCacheRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CacheStorage.DeleteCacheRequest>(
                    "CacheStorage.deleteCache", parameters, cancellationToken);
        }

        /// <summary>Deletes a cache entry.</summary>
        public readonly System.Threading.Tasks.Task DeleteEntryAsync(
            CefNet.DevTools.Protocol.CacheStorage.DeleteEntryRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CacheStorage.DeleteEntryRequest>(
                    "CacheStorage.deleteEntry", parameters, cancellationToken);
        }

        /// <summary>Fetches cache entry.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CacheStorage.RequestCachedResponseResponse> RequestCachedResponseAsync(
            CefNet.DevTools.Protocol.CacheStorage.RequestCachedResponseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CacheStorage.RequestCachedResponseRequest, CefNet.DevTools.Protocol.CacheStorage.RequestCachedResponseResponse>(
                    "CacheStorage.requestCachedResponse", parameters, cancellationToken);
        }

        /// <summary>Requests cache names.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CacheStorage.RequestCacheNamesResponse> RequestCacheNamesAsync(
            CefNet.DevTools.Protocol.CacheStorage.RequestCacheNamesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CacheStorage.RequestCacheNamesRequest, CefNet.DevTools.Protocol.CacheStorage.RequestCacheNamesResponse>(
                    "CacheStorage.requestCacheNames", parameters, cancellationToken);
        }

        /// <summary>Requests data from cache.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.CacheStorage.RequestEntriesResponse> RequestEntriesAsync(
            CefNet.DevTools.Protocol.CacheStorage.RequestEntriesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.CacheStorage.RequestEntriesRequest, CefNet.DevTools.Protocol.CacheStorage.RequestEntriesResponse>(
                    "CacheStorage.requestEntries", parameters, cancellationToken);
        }
    }
}
