//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.ApplicationCache
{
    /// <summary>[Experimental] </summary>
    public readonly struct ApplicationCacheApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal ApplicationCacheApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Enables application cache domain notifications.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "ApplicationCache.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns relevant application cache data for the document in given frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.ApplicationCache.GetApplicationCacheForFrameResponse> GetApplicationCacheForFrameAsync(
            CefNet.DevTools.Protocol.ApplicationCache.GetApplicationCacheForFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ApplicationCache.GetApplicationCacheForFrameRequest, CefNet.DevTools.Protocol.ApplicationCache.GetApplicationCacheForFrameResponse>(
                    "ApplicationCache.getApplicationCacheForFrame", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns array of frame identifiers with manifest urls for each frame containing a document
        /// associated with some application cache.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.ApplicationCache.GetFramesWithManifestsResponse> GetFramesWithManifestsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.ApplicationCache.GetFramesWithManifestsResponse>(
                    "ApplicationCache.getFramesWithManifests", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns manifest URL for document in the given frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.ApplicationCache.GetManifestForFrameResponse> GetManifestForFrameAsync(
            CefNet.DevTools.Protocol.ApplicationCache.GetManifestForFrameRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.ApplicationCache.GetManifestForFrameRequest, CefNet.DevTools.Protocol.ApplicationCache.GetManifestForFrameResponse>(
                    "ApplicationCache.getManifestForFrame", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheStatusUpdatedEventArgs> ApplicationCacheStatusUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheStatusUpdatedEventArgs>("ApplicationCache.applicationCacheStatusUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.ApplicationCache.ApplicationCacheStatusUpdatedEventArgs>("ApplicationCache.applicationCacheStatusUpdated", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.ApplicationCache.NetworkStateUpdatedEventArgs> NetworkStateUpdated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.ApplicationCache.NetworkStateUpdatedEventArgs>("ApplicationCache.networkStateUpdated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.ApplicationCache.NetworkStateUpdatedEventArgs>("ApplicationCache.networkStateUpdated", value);
            }
        }
    }
}
