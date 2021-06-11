//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Storage
{
    /// <summary>[Experimental] </summary>
    public readonly struct StorageApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal StorageApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Clears cookies.</summary>
        public readonly System.Threading.Tasks.Task ClearCookiesAsync(
            CefNet.DevTools.Protocol.Storage.ClearCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.ClearCookiesRequest>(
                    "Storage.clearCookies", parameters, cancellationToken);
        }

        /// <summary>Clears storage for origin.</summary>
        public readonly System.Threading.Tasks.Task ClearDataForOriginAsync(
            CefNet.DevTools.Protocol.Storage.ClearDataForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.ClearDataForOriginRequest>(
                    "Storage.clearDataForOrigin", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Removes all Trust Tokens issued by the provided issuerOrigin.
        /// Leaves other stored data, including the issuer's Redemption Records, intact.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Storage.ClearTrustTokensResponse> ClearTrustTokensAsync(
            CefNet.DevTools.Protocol.Storage.ClearTrustTokensRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.ClearTrustTokensRequest, CefNet.DevTools.Protocol.Storage.ClearTrustTokensResponse>(
                    "Storage.clearTrustTokens", parameters, cancellationToken);
        }

        /// <summary>Returns all browser cookies.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Storage.GetCookiesResponse> GetCookiesAsync(
            CefNet.DevTools.Protocol.Storage.GetCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.GetCookiesRequest, CefNet.DevTools.Protocol.Storage.GetCookiesResponse>(
                    "Storage.getCookies", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the number of stored Trust Tokens per issuer for the
        /// current browsing context.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Storage.GetTrustTokensResponse> GetTrustTokensAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Storage.GetTrustTokensResponse>(
                    "Storage.getTrustTokens", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Returns usage and quota in bytes.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Storage.GetUsageAndQuotaResponse> GetUsageAndQuotaAsync(
            CefNet.DevTools.Protocol.Storage.GetUsageAndQuotaRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.GetUsageAndQuotaRequest, CefNet.DevTools.Protocol.Storage.GetUsageAndQuotaResponse>(
                    "Storage.getUsageAndQuota", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Override quota for the specified origin
        /// </summary>
        public readonly System.Threading.Tasks.Task OverrideQuotaForOriginAsync(
            CefNet.DevTools.Protocol.Storage.OverrideQuotaForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.OverrideQuotaForOriginRequest>(
                    "Storage.overrideQuotaForOrigin", parameters, cancellationToken);
        }

        /// <summary>Sets given cookies.</summary>
        public readonly System.Threading.Tasks.Task SetCookiesAsync(
            CefNet.DevTools.Protocol.Storage.SetCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.SetCookiesRequest>(
                    "Storage.setCookies", parameters, cancellationToken);
        }

        /// <summary>
        /// Registers origin to be notified when an update occurs to its cache storage list.
        /// </summary>
        public readonly System.Threading.Tasks.Task TrackCacheStorageForOriginAsync(
            CefNet.DevTools.Protocol.Storage.TrackCacheStorageForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.TrackCacheStorageForOriginRequest>(
                    "Storage.trackCacheStorageForOrigin", parameters, cancellationToken);
        }

        /// <summary>
        /// Registers origin to be notified when an update occurs to its IndexedDB.
        /// </summary>
        public readonly System.Threading.Tasks.Task TrackIndexedDBForOriginAsync(
            CefNet.DevTools.Protocol.Storage.TrackIndexedDBForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.TrackIndexedDBForOriginRequest>(
                    "Storage.trackIndexedDBForOrigin", parameters, cancellationToken);
        }

        /// <summary>
        /// Unregisters origin from receiving notifications for cache storage.
        /// </summary>
        public readonly System.Threading.Tasks.Task UntrackCacheStorageForOriginAsync(
            CefNet.DevTools.Protocol.Storage.UntrackCacheStorageForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.UntrackCacheStorageForOriginRequest>(
                    "Storage.untrackCacheStorageForOrigin", parameters, cancellationToken);
        }

        /// <summary>
        /// Unregisters origin from receiving notifications for IndexedDB.
        /// </summary>
        public readonly System.Threading.Tasks.Task UntrackIndexedDBForOriginAsync(
            CefNet.DevTools.Protocol.Storage.UntrackIndexedDBForOriginRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Storage.UntrackIndexedDBForOriginRequest>(
                    "Storage.untrackIndexedDBForOrigin", parameters, cancellationToken);
        }

        /// <summary>A cache's contents have been modified.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageContentUpdatedEventArgs> CacheStorageContentUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageContentUpdatedEventArgs>("Storage.cacheStorageContentUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageContentUpdatedEventArgs>("Storage.cacheStorageContentUpdated", value);
            }
        }

        /// <summary>A cache has been added/deleted.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageListUpdatedEventArgs> CacheStorageListUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageListUpdatedEventArgs>("Storage.cacheStorageListUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Storage.CacheStorageListUpdatedEventArgs>("Storage.cacheStorageListUpdated", value);
            }
        }

        /// <summary>
        /// The origin's IndexedDB object store has been modified.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBContentUpdatedEventArgs> IndexedDBContentUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBContentUpdatedEventArgs>("Storage.indexedDBContentUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBContentUpdatedEventArgs>("Storage.indexedDBContentUpdated", value);
            }
        }

        /// <summary>
        /// The origin's IndexedDB database list has been modified.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBListUpdatedEventArgs> IndexedDBListUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBListUpdatedEventArgs>("Storage.indexedDBListUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Storage.IndexedDBListUpdatedEventArgs>("Storage.indexedDBListUpdated", value);
            }
        }
    }
}
