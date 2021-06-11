//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.IndexedDB
{
    /// <summary>[Experimental] </summary>
    public readonly struct IndexedDBApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal IndexedDBApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>Clears all entries from an object store.</summary>
        public readonly System.Threading.Tasks.Task ClearObjectStoreAsync(
            CefNet.DevTools.Protocol.IndexedDB.ClearObjectStoreRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.ClearObjectStoreRequest>(
                    "IndexedDB.clearObjectStore", parameters, cancellationToken);
        }

        /// <summary>Deletes a database.</summary>
        public readonly System.Threading.Tasks.Task DeleteDatabaseAsync(
            CefNet.DevTools.Protocol.IndexedDB.DeleteDatabaseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.DeleteDatabaseRequest>(
                    "IndexedDB.deleteDatabase", parameters, cancellationToken);
        }

        /// <summary>
        /// Delete a range of entries from an object store
        /// </summary>
        public readonly System.Threading.Tasks.Task DeleteObjectStoreEntriesAsync(
            CefNet.DevTools.Protocol.IndexedDB.DeleteObjectStoreEntriesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.DeleteObjectStoreEntriesRequest>(
                    "IndexedDB.deleteObjectStoreEntries", parameters, cancellationToken);
        }

        /// <summary>Disables events from backend.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "IndexedDB.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables events from backend.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "IndexedDB.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Gets metadata of an object store</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IndexedDB.GetMetadataResponse> GetMetadataAsync(
            CefNet.DevTools.Protocol.IndexedDB.GetMetadataRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.GetMetadataRequest, CefNet.DevTools.Protocol.IndexedDB.GetMetadataResponse>(
                    "IndexedDB.getMetadata", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests data from object store or index.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IndexedDB.RequestDataResponse> RequestDataAsync(
            CefNet.DevTools.Protocol.IndexedDB.RequestDataRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.RequestDataRequest, CefNet.DevTools.Protocol.IndexedDB.RequestDataResponse>(
                    "IndexedDB.requestData", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests database with given name in given frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseResponse> RequestDatabaseAsync(
            CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseRequest, CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseResponse>(
                    "IndexedDB.requestDatabase", parameters, cancellationToken);
        }

        /// <summary>
        /// Requests database names for given security origin.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseNamesResponse> RequestDatabaseNamesAsync(
            CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseNamesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseNamesRequest, CefNet.DevTools.Protocol.IndexedDB.RequestDatabaseNamesResponse>(
                    "IndexedDB.requestDatabaseNames", parameters, cancellationToken);
        }
    }
}
