//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Database
{
    /// <summary>[Experimental] </summary>
    public readonly struct DatabaseApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal DatabaseApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Disables database tracking, prevents database events from being sent to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Database.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables database tracking, database events will now be delivered to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Database.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Database.ExecuteSQLResponse> ExecuteSQLAsync(
            CefNet.DevTools.Protocol.Database.ExecuteSQLRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Database.ExecuteSQLRequest, CefNet.DevTools.Protocol.Database.ExecuteSQLResponse>(
                    "Database.executeSQL", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Database.GetDatabaseTableNamesResponse> GetDatabaseTableNamesAsync(
            CefNet.DevTools.Protocol.Database.GetDatabaseTableNamesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Database.GetDatabaseTableNamesRequest, CefNet.DevTools.Protocol.Database.GetDatabaseTableNamesResponse>(
                    "Database.getDatabaseTableNames", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Database.AddDatabaseEventArgs> AddDatabase 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Database.AddDatabaseEventArgs>("Database.addDatabase", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Database.AddDatabaseEventArgs>("Database.addDatabase", value);
            }
        }
    }
}
