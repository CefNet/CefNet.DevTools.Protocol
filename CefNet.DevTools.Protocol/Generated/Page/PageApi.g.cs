//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Page
{
    /// <summary>
    /// Actions and events related to the inspected page belong to the page domain.
    /// </summary>
    public readonly struct PageApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal PageApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Experimental] Seeds compilation cache for given url. Compilation cache does not survive
        /// cross-process navigation.
        /// </summary>
        public readonly System.Threading.Tasks.Task AddCompilationCacheAsync(
            CefNet.DevTools.Protocol.Page.AddCompilationCacheRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.AddCompilationCacheRequest>(
                    "Page.addCompilationCache", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Deprecated, please use addScriptToEvaluateOnNewDocument instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnLoadResponse> AddScriptToEvaluateOnLoadAsync(
            CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnLoadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnLoadRequest, CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnLoadResponse>(
                    "Page.addScriptToEvaluateOnLoad", parameters, cancellationToken);
        }

        /// <summary>
        /// Evaluates given script in every frame upon creation (before loading frame's scripts).
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnNewDocumentResponse> AddScriptToEvaluateOnNewDocumentAsync(
            CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnNewDocumentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnNewDocumentRequest, CefNet.DevTools.Protocol.Page.AddScriptToEvaluateOnNewDocumentResponse>(
                    "Page.addScriptToEvaluateOnNewDocument", parameters, cancellationToken);
        }

        /// <summary>Brings page to front (activates tab).</summary>
        public readonly System.Threading.Tasks.Task BringToFrontAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.bringToFront", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Capture page screenshot.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.CaptureScreenshotResponse> CaptureScreenshotAsync(
            CefNet.DevTools.Protocol.Page.CaptureScreenshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.CaptureScreenshotRequest, CefNet.DevTools.Protocol.Page.CaptureScreenshotResponse>(
                    "Page.captureScreenshot", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns a snapshot of the page as a string. For MHTML format, the serialization includes
        /// iframes, shadow DOM, external resources, and element-inline styles.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.CaptureSnapshotResponse> CaptureSnapshotAsync(
            CefNet.DevTools.Protocol.Page.CaptureSnapshotRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.CaptureSnapshotRequest, CefNet.DevTools.Protocol.Page.CaptureSnapshotResponse>(
                    "Page.captureSnapshot", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Clears seeded compilation cache.
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearCompilationCacheAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.clearCompilationCache", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Clears the overridden device metrics.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task ClearDeviceMetricsOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.clearDeviceMetricsOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Clears the overridden Device Orientation.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task ClearDeviceOrientationOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.clearDeviceOrientationOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Clears the overridden Geolocation Position and Error.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task ClearGeolocationOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.clearGeolocationOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Tries to close page, running its beforeunload hooks, if any.
        /// </summary>
        public readonly System.Threading.Tasks.Task CloseAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.close", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Crashes renderer on the IO thread, generates minidumps.
        /// </summary>
        public readonly System.Threading.Tasks.Task CrashAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.crash", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Creates an isolated world for the given frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.CreateIsolatedWorldResponse> CreateIsolatedWorldAsync(
            CefNet.DevTools.Protocol.Page.CreateIsolatedWorldRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.CreateIsolatedWorldRequest, CefNet.DevTools.Protocol.Page.CreateIsolatedWorldResponse>(
                    "Page.createIsolatedWorld", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Deletes browser cookie with given name, domain and path.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task DeleteCookieAsync(
            CefNet.DevTools.Protocol.Page.DeleteCookieRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.DeleteCookieRequest>(
                    "Page.deleteCookie", parameters, cancellationToken);
        }

        /// <summary>Disables page domain notifications.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables page domain notifications.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Generates a report for testing.
        /// </summary>
        public readonly System.Threading.Tasks.Task GenerateTestReportAsync(
            CefNet.DevTools.Protocol.Page.GenerateTestReportRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.GenerateTestReportRequest>(
                    "Page.generateTestReport", parameters, cancellationToken);
        }

        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetAppManifestResponse> GetAppManifestAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetAppManifestResponse>(
                    "Page.getAppManifest", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Returns all browser cookies. Depending on the backend support, will return detailed cookie
        /// information in the `cookies` field.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetCookiesResponse> GetCookiesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetCookiesResponse>(
                    "Page.getCookies", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Returns present frame tree structure.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetFrameTreeResponse> GetFrameTreeAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetFrameTreeResponse>(
                    "Page.getFrameTree", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetInstallabilityErrorsResponse> GetInstallabilityErrorsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetInstallabilityErrorsResponse>(
                    "Page.getInstallabilityErrors", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetLayoutMetricsResponse> GetLayoutMetricsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetLayoutMetricsResponse>(
                    "Page.getLayoutMetrics", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>[Experimental] </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetManifestIconsResponse> GetManifestIconsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetManifestIconsResponse>(
                    "Page.getManifestIcons", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns navigation history for the current page.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetNavigationHistoryResponse> GetNavigationHistoryAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetNavigationHistoryResponse>(
                    "Page.getNavigationHistory", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Get Permissions Policy state on given frame.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetPermissionsPolicyStateResponse> GetPermissionsPolicyStateAsync(
            CefNet.DevTools.Protocol.Page.GetPermissionsPolicyStateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.GetPermissionsPolicyStateRequest, CefNet.DevTools.Protocol.Page.GetPermissionsPolicyStateResponse>(
                    "Page.getPermissionsPolicyState", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns content of the given resource.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetResourceContentResponse> GetResourceContentAsync(
            CefNet.DevTools.Protocol.Page.GetResourceContentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.GetResourceContentRequest, CefNet.DevTools.Protocol.Page.GetResourceContentResponse>(
                    "Page.getResourceContent", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns present frame / resource tree structure.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.GetResourceTreeResponse> GetResourceTreeAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Page.GetResourceTreeResponse>(
                    "Page.getResourceTree", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
        /// </summary>
        public readonly System.Threading.Tasks.Task HandleJavaScriptDialogAsync(
            CefNet.DevTools.Protocol.Page.HandleJavaScriptDialogRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.HandleJavaScriptDialogRequest>(
                    "Page.handleJavaScriptDialog", parameters, cancellationToken);
        }

        /// <summary>Navigates current page to the given URL.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.NavigateResponse> NavigateAsync(
            CefNet.DevTools.Protocol.Page.NavigateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.NavigateRequest, CefNet.DevTools.Protocol.Page.NavigateResponse>(
                    "Page.navigate", parameters, cancellationToken);
        }

        /// <summary>
        /// Navigates current page to the given history entry.
        /// </summary>
        public readonly System.Threading.Tasks.Task NavigateToHistoryEntryAsync(
            CefNet.DevTools.Protocol.Page.NavigateToHistoryEntryRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.NavigateToHistoryEntryRequest>(
                    "Page.navigateToHistoryEntry", parameters, cancellationToken);
        }

        /// <summary>Print page as PDF.</summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.PrintToPDFResponse> PrintToPDFAsync(
            CefNet.DevTools.Protocol.Page.PrintToPDFRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.PrintToPDFRequest, CefNet.DevTools.Protocol.Page.PrintToPDFResponse>(
                    "Page.printToPDF", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Requests backend to produce compilation cache for the specified scripts.
        /// Unlike setProduceCompilationCache, this allows client to only produce cache
        /// for specific scripts. `scripts` are appeneded to the list of scripts
        /// for which the cache for would produced. Disabling compilation cache with
        /// `setProduceCompilationCache` would reset all pending cache requests.
        /// The list may also be reset during page navigation.
        /// When script with a matching URL is encountered, the cache is optionally
        /// produced upon backend discretion, based on internal heuristics.
        /// See also: `Page.compilationCacheProduced`.
        /// </summary>
        public readonly System.Threading.Tasks.Task ProduceCompilationCacheAsync(
            CefNet.DevTools.Protocol.Page.ProduceCompilationCacheRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.ProduceCompilationCacheRequest>(
                    "Page.produceCompilationCache", parameters, cancellationToken);
        }

        /// <summary>
        /// Reloads given page optionally ignoring the cache.
        /// </summary>
        public readonly System.Threading.Tasks.Task ReloadAsync(
            CefNet.DevTools.Protocol.Page.ReloadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.ReloadRequest>(
                    "Page.reload", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task RemoveScriptToEvaluateOnLoadAsync(
            CefNet.DevTools.Protocol.Page.RemoveScriptToEvaluateOnLoadRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.RemoveScriptToEvaluateOnLoadRequest>(
                    "Page.removeScriptToEvaluateOnLoad", parameters, cancellationToken);
        }

        /// <summary>Removes given script from the list.</summary>
        public readonly System.Threading.Tasks.Task RemoveScriptToEvaluateOnNewDocumentAsync(
            CefNet.DevTools.Protocol.Page.RemoveScriptToEvaluateOnNewDocumentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.RemoveScriptToEvaluateOnNewDocumentRequest>(
                    "Page.removeScriptToEvaluateOnNewDocument", parameters, cancellationToken);
        }

        /// <summary>
        /// Resets navigation history for the current page.
        /// </summary>
        public readonly System.Threading.Tasks.Task ResetNavigationHistoryAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.resetNavigationHistory", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Acknowledges that a screencast frame has been received by the frontend.
        /// </summary>
        public readonly System.Threading.Tasks.Task ScreencastFrameAckAsync(
            CefNet.DevTools.Protocol.Page.ScreencastFrameAckRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.ScreencastFrameAckRequest>(
                    "Page.screencastFrameAck", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Searches for given string in resource content.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Page.SearchInResourceResponse> SearchInResourceAsync(
            CefNet.DevTools.Protocol.Page.SearchInResourceRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SearchInResourceRequest, CefNet.DevTools.Protocol.Page.SearchInResourceResponse>(
                    "Page.searchInResource", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enable Chrome's experimental ad filter on all sites.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAdBlockingEnabledAsync(
            CefNet.DevTools.Protocol.Page.SetAdBlockingEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetAdBlockingEnabledRequest>(
                    "Page.setAdBlockingEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enable page Content Security Policy by-passing.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBypassCSPAsync(
            CefNet.DevTools.Protocol.Page.SetBypassCSPRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetBypassCSPRequest>(
                    "Page.setBypassCSP", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
        /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
        /// query results).
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetDeviceMetricsOverrideAsync(
            CefNet.DevTools.Protocol.Page.SetDeviceMetricsOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetDeviceMetricsOverrideRequest>(
                    "Page.setDeviceMetricsOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Overrides the Device Orientation.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetDeviceOrientationOverrideAsync(
            CefNet.DevTools.Protocol.Page.SetDeviceOrientationOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetDeviceOrientationOverrideRequest>(
                    "Page.setDeviceOrientationOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets given markup as the document's HTML.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetDocumentContentAsync(
            CefNet.DevTools.Protocol.Page.SetDocumentContentRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetDocumentContentRequest>(
                    "Page.setDocumentContent", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Set the behavior when downloading a file.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetDownloadBehaviorAsync(
            CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetDownloadBehaviorRequest>(
                    "Page.setDownloadBehavior", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Set generic font families.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetFontFamiliesAsync(
            CefNet.DevTools.Protocol.Page.SetFontFamiliesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetFontFamiliesRequest>(
                    "Page.setFontFamilies", parameters, cancellationToken);
        }

        /// <summary>[Experimental] Set default font sizes.</summary>
        public readonly System.Threading.Tasks.Task SetFontSizesAsync(
            CefNet.DevTools.Protocol.Page.SetFontSizesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetFontSizesRequest>(
                    "Page.setFontSizes", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
        /// unavailable.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetGeolocationOverrideAsync(
            CefNet.DevTools.Protocol.Page.SetGeolocationOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetGeolocationOverrideRequest>(
                    "Page.setGeolocationOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Intercept file chooser requests and transfer control to protocol clients.
        /// When file chooser interception is enabled, native file chooser dialog is not shown.
        /// Instead, a protocol event `Page.fileChooserOpened` is emitted.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetInterceptFileChooserDialogAsync(
            CefNet.DevTools.Protocol.Page.SetInterceptFileChooserDialogRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetInterceptFileChooserDialogRequest>(
                    "Page.setInterceptFileChooserDialog", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Controls whether page will emit lifecycle events.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetLifecycleEventsEnabledAsync(
            CefNet.DevTools.Protocol.Page.SetLifecycleEventsEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetLifecycleEventsEnabledRequest>(
                    "Page.setLifecycleEventsEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Forces compilation cache to be generated for every subresource script.
        /// See also: `Page.produceCompilationCache`.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetProduceCompilationCacheAsync(
            CefNet.DevTools.Protocol.Page.SetProduceCompilationCacheRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetProduceCompilationCacheRequest>(
                    "Page.setProduceCompilationCache", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Toggles mouse event-based touch event emulation.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetTouchEmulationEnabledAsync(
            CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetTouchEmulationEnabledRequest>(
                    "Page.setTouchEmulationEnabled", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Tries to update the web lifecycle state of the page.
        /// It will transition the page to the given state according to:
        /// https://github.com/WICG/web-lifecycle/
        /// </summary>
        public readonly System.Threading.Tasks.Task SetWebLifecycleStateAsync(
            CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.SetWebLifecycleStateRequest>(
                    "Page.setWebLifecycleState", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Starts sending each frame using the `screencastFrame` event.
        /// </summary>
        public readonly System.Threading.Tasks.Task StartScreencastAsync(
            CefNet.DevTools.Protocol.Page.StartScreencastRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Page.StartScreencastRequest>(
                    "Page.startScreencast", parameters, cancellationToken);
        }

        /// <summary>
        /// Force the page stop all navigations and pending resource fetches.
        /// </summary>
        public readonly System.Threading.Tasks.Task StopLoadingAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.stopLoading", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Stops sending each frame in the `screencastFrame`.
        /// </summary>
        public readonly System.Threading.Tasks.Task StopScreencastAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.stopScreencast", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
        /// </summary>
        public readonly System.Threading.Tasks.Task WaitForDebuggerAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Page.waitForDebugger", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
        /// not assume any ordering with the Page.frameNavigated event. This event is fired only for
        /// main-frame history navigation where the document changes (non-same-document navigations),
        /// when bfcache navigation fails.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.BackForwardCacheNotUsedEventArgs> BackForwardCacheNotUsed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.BackForwardCacheNotUsedEventArgs>("Page.backForwardCacheNotUsed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.BackForwardCacheNotUsedEventArgs>("Page.backForwardCacheNotUsed", value);
            }
        }

        /// <summary>
        /// [Experimental] Issued for every compilation cache generated. Is only available
        /// if Page.setGenerateCompilationCache is enabled.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.CompilationCacheProducedEventArgs> CompilationCacheProduced 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.CompilationCacheProducedEventArgs>("Page.compilationCacheProduced", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.CompilationCacheProducedEventArgs>("Page.compilationCacheProduced", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when opening document to write to.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.DocumentOpenedEventArgs> DocumentOpened 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.DocumentOpenedEventArgs>("Page.documentOpened", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.DocumentOpenedEventArgs>("Page.documentOpened", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.DomContentEventFiredEventArgs> DomContentEventFired 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.DomContentEventFiredEventArgs>("Page.domContentEventFired", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.DomContentEventFiredEventArgs>("Page.domContentEventFired", value);
            }
        }

        /// <summary>
        /// [Deprecated] [Experimental] Fired when download makes progress. Last call has |done| == true.
        /// Deprecated. Use Browser.downloadProgress instead.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.DownloadProgressEventArgs> DownloadProgress 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.DownloadProgressEventArgs>("Page.downloadProgress", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.DownloadProgressEventArgs>("Page.downloadProgress", value);
            }
        }

        /// <summary>
        /// [Deprecated] [Experimental] Fired when page is about to start a download.
        /// Deprecated. Use Browser.downloadWillBegin instead.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.DownloadWillBeginEventArgs> DownloadWillBegin 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.DownloadWillBeginEventArgs>("Page.downloadWillBegin", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.DownloadWillBeginEventArgs>("Page.downloadWillBegin", value);
            }
        }

        /// <summary>
        /// Emitted only when `page.interceptFileChooser` is enabled.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgs> FileChooserOpened 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgs>("Page.fileChooserOpened", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FileChooserOpenedEventArgs>("Page.fileChooserOpened", value);
            }
        }

        /// <summary>
        /// Fired when frame has been attached to its parent.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameAttachedEventArgs> FrameAttached 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameAttachedEventArgs>("Page.frameAttached", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameAttachedEventArgs>("Page.frameAttached", value);
            }
        }

        /// <summary>
        /// [Deprecated] Fired when frame no longer has a scheduled navigation.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameClearedScheduledNavigationEventArgs> FrameClearedScheduledNavigation 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameClearedScheduledNavigationEventArgs>("Page.frameClearedScheduledNavigation", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameClearedScheduledNavigationEventArgs>("Page.frameClearedScheduledNavigation", value);
            }
        }

        /// <summary>
        /// Fired when frame has been detached from its parent.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameDetachedEventArgs> FrameDetached 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameDetachedEventArgs>("Page.frameDetached", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameDetachedEventArgs>("Page.frameDetached", value);
            }
        }

        /// <summary>
        /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameNavigatedEventArgs> FrameNavigated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameNavigatedEventArgs>("Page.frameNavigated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameNavigatedEventArgs>("Page.frameNavigated", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when a renderer-initiated navigation is requested.
        /// Navigation may still be cancelled after the event is issued.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameRequestedNavigationEventArgs> FrameRequestedNavigation 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameRequestedNavigationEventArgs>("Page.frameRequestedNavigation", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameRequestedNavigationEventArgs>("Page.frameRequestedNavigation", value);
            }
        }

        /// <summary>[Experimental] </summary>
        public readonly event System.EventHandler<System.EventArgs> FrameResized 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Page.frameResized", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Page.frameResized", value);
            }
        }

        /// <summary>
        /// [Deprecated] Fired when frame schedules a potential navigation.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameScheduledNavigationEventArgs> FrameScheduledNavigation 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameScheduledNavigationEventArgs>("Page.frameScheduledNavigation", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameScheduledNavigationEventArgs>("Page.frameScheduledNavigation", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when frame has started loading.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameStartedLoadingEventArgs> FrameStartedLoading 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameStartedLoadingEventArgs>("Page.frameStartedLoading", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameStartedLoadingEventArgs>("Page.frameStartedLoading", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when frame has stopped loading.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.FrameStoppedLoadingEventArgs> FrameStoppedLoading 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.FrameStoppedLoadingEventArgs>("Page.frameStoppedLoading", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.FrameStoppedLoadingEventArgs>("Page.frameStoppedLoading", value);
            }
        }

        /// <summary>Fired when interstitial page was hidden</summary>
        public readonly event System.EventHandler<System.EventArgs> InterstitialHidden 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Page.interstitialHidden", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Page.interstitialHidden", value);
            }
        }

        /// <summary>Fired when interstitial page was shown</summary>
        public readonly event System.EventHandler<System.EventArgs> InterstitialShown 
        {
            add
            {
                _session.AddEventHandler<System.EventArgs>("Page.interstitialShown", value);
            }
            remove
            {
                _session.RemoveEventHandler<System.EventArgs>("Page.interstitialShown", value);
            }
        }

        /// <summary>
        /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
        /// closed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogClosedEventArgs> JavascriptDialogClosed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogClosedEventArgs>("Page.javascriptDialogClosed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogClosedEventArgs>("Page.javascriptDialogClosed", value);
            }
        }

        /// <summary>
        /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
        /// open.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogOpeningEventArgs> JavascriptDialogOpening 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogOpeningEventArgs>("Page.javascriptDialogOpening", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.JavascriptDialogOpeningEventArgs>("Page.javascriptDialogOpening", value);
            }
        }

        /// <summary>
        /// Fired for top level page lifecycle events such as navigation, load, paint, etc.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.LifecycleEventEventArgs> LifecycleEvent 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.LifecycleEventEventArgs>("Page.lifecycleEvent", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.LifecycleEventEventArgs>("Page.lifecycleEvent", value);
            }
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.LoadEventFiredEventArgs> LoadEventFired 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.LoadEventFiredEventArgs>("Page.loadEventFired", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.LoadEventFiredEventArgs>("Page.loadEventFired", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.NavigatedWithinDocumentEventArgs> NavigatedWithinDocument 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.NavigatedWithinDocumentEventArgs>("Page.navigatedWithinDocument", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.NavigatedWithinDocumentEventArgs>("Page.navigatedWithinDocument", value);
            }
        }

        /// <summary>
        /// [Experimental] Compressed image data requested by the `startScreencast`.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.ScreencastFrameEventArgs> ScreencastFrame 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.ScreencastFrameEventArgs>("Page.screencastFrame", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.ScreencastFrameEventArgs>("Page.screencastFrame", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when the page with currently enabled screencast was shown or hidden `.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.ScreencastVisibilityChangedEventArgs> ScreencastVisibilityChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.ScreencastVisibilityChangedEventArgs>("Page.screencastVisibilityChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.ScreencastVisibilityChangedEventArgs>("Page.screencastVisibilityChanged", value);
            }
        }

        /// <summary>
        /// Fired when a new window is going to be opened, via window.open(), link click, form submission,
        /// etc.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Page.WindowOpenEventArgs> WindowOpen 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Page.WindowOpenEventArgs>("Page.windowOpen", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Page.WindowOpenEventArgs>("Page.windowOpen", value);
            }
        }
    }
}
