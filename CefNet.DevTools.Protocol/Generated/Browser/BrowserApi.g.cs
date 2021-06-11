//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Browser
{
    /// <summary>
    /// The Browser domain defines methods and events for browser managing.
    /// </summary>
    public readonly struct BrowserApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal BrowserApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Experimental] Cancel a download if in progress
        /// </summary>
        public readonly System.Threading.Tasks.Task CancelDownloadAsync(
            CefNet.DevTools.Protocol.Browser.CancelDownloadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.CancelDownloadRequest>(
                    "Browser.cancelDownload", parameters, cancellationToken);
        }

        /// <summary>Close browser gracefully.</summary>
        public readonly System.Threading.Tasks.Task CloseAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Browser.close", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Crashes browser on the main thread.
        /// </summary>
        public readonly System.Threading.Tasks.Task CrashAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Browser.crash", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] Crashes GPU process.</summary>
        public readonly System.Threading.Tasks.Task CrashGpuProcessAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Browser.crashGpuProcess", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Invoke custom browser commands used by telemetry.
        /// </summary>
        public readonly System.Threading.Tasks.Task ExecuteBrowserCommandAsync(
            CefNet.DevTools.Protocol.Browser.ExecuteBrowserCommandRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.ExecuteBrowserCommandRequest>(
                    "Browser.executeBrowserCommand", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the command line switches for the browser process if, and only if
        /// --enable-automation is on the commandline.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetBrowserCommandLineResponse> GetBrowserCommandLineAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Browser.GetBrowserCommandLineResponse>(
                    "Browser.getBrowserCommandLine", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Get a Chrome histogram by name.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetHistogramResponse> GetHistogramAsync(
            CefNet.DevTools.Protocol.Browser.GetHistogramRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.GetHistogramRequest, CefNet.DevTools.Protocol.Browser.GetHistogramResponse>(
                    "Browser.getHistogram", parameters, cancellationToken);
        }

        /// <summary>[Experimental] Get Chrome histograms.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetHistogramsResponse> GetHistogramsAsync(
            CefNet.DevTools.Protocol.Browser.GetHistogramsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.GetHistogramsRequest, CefNet.DevTools.Protocol.Browser.GetHistogramsResponse>(
                    "Browser.getHistograms", parameters, cancellationToken);
        }

        /// <summary>Returns version information.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetVersionResponse> GetVersionAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Browser.GetVersionResponse>(
                    "Browser.getVersion", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Get position and size of the browser window.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetWindowBoundsResponse> GetWindowBoundsAsync(
            CefNet.DevTools.Protocol.Browser.GetWindowBoundsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.GetWindowBoundsRequest, CefNet.DevTools.Protocol.Browser.GetWindowBoundsResponse>(
                    "Browser.getWindowBounds", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Get the browser window that contains the devtools target.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Browser.GetWindowForTargetResponse> GetWindowForTargetAsync(
            CefNet.DevTools.Protocol.Browser.GetWindowForTargetRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.GetWindowForTargetRequest, CefNet.DevTools.Protocol.Browser.GetWindowForTargetResponse>(
                    "Browser.getWindowForTarget", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Grant specific permissions to the given origin and reject all others.
        /// </summary>
        public readonly System.Threading.Tasks.Task GrantPermissionsAsync(
            CefNet.DevTools.Protocol.Browser.GrantPermissionsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.GrantPermissionsRequest>(
                    "Browser.grantPermissions", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Reset all permission management for all origins.
        /// </summary>
        public readonly System.Threading.Tasks.Task ResetPermissionsAsync(
            CefNet.DevTools.Protocol.Browser.ResetPermissionsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.ResetPermissionsRequest>(
                    "Browser.resetPermissions", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Set dock tile details, platform-specific.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDockTileAsync(
            CefNet.DevTools.Protocol.Browser.SetDockTileRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.SetDockTileRequest>(
                    "Browser.setDockTile", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Set the behavior when downloading a file.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDownloadBehaviorAsync(
            CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.SetDownloadBehaviorRequest>(
                    "Browser.setDownloadBehavior", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Set permission settings for given origin.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetPermissionAsync(
            CefNet.DevTools.Protocol.Browser.SetPermissionRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.SetPermissionRequest>(
                    "Browser.setPermission", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Set position and/or size of the browser window.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetWindowBoundsAsync(
            CefNet.DevTools.Protocol.Browser.SetWindowBoundsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Browser.SetWindowBoundsRequest>(
                    "Browser.setWindowBounds", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fired when download makes progress. Last call has |done| == true.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Browser.DownloadProgressEventArgs> DownloadProgress 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Browser.DownloadProgressEventArgs>("Browser.downloadProgress", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Browser.DownloadProgressEventArgs>("Browser.downloadProgress", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when page is about to start a download.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Browser.DownloadWillBeginEventArgs> DownloadWillBegin 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Browser.DownloadWillBeginEventArgs>("Browser.downloadWillBegin", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Browser.DownloadWillBeginEventArgs>("Browser.downloadWillBegin", value);
            }
        }
    }
}
