//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// Network domain allows tracking network activities of the page. It exposes information about http,
    /// file, data and other requests and responses, their headers, bodies, timing, etc.
    /// </summary>
    public readonly struct NetworkApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal NetworkApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// [Deprecated] Tells whether clearing browser cache is supported.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.CanClearBrowserCacheResponse> CanClearBrowserCacheAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Network.CanClearBrowserCacheResponse>(
                    "Network.canClearBrowserCache", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Tells whether clearing browser cookies is supported.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.CanClearBrowserCookiesResponse> CanClearBrowserCookiesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Network.CanClearBrowserCookiesResponse>(
                    "Network.canClearBrowserCookies", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Tells whether emulation of network conditions is supported.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.CanEmulateNetworkConditionsResponse> CanEmulateNetworkConditionsAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Network.CanEmulateNetworkConditionsResponse>(
                    "Network.canEmulateNetworkConditions", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Clears accepted encodings set by setAcceptedEncodings
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearAcceptedEncodingsOverrideAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Network.clearAcceptedEncodingsOverride", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Clears browser cache.</summary>
        public readonly System.Threading.Tasks.Task ClearBrowserCacheAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Network.clearBrowserCache", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Clears browser cookies.</summary>
        public readonly System.Threading.Tasks.Task ClearBrowserCookiesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Network.clearBrowserCookies", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Response to Network.requestIntercepted which either modifies the request to continue with any
        /// modifications, or blocks it, or completes it with the provided response bytes. If a network
        /// fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted
        /// event will be sent with the same InterceptionId.
        /// Deprecated, use Fetch.continueRequest, Fetch.fulfillRequest and Fetch.failRequest instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task ContinueInterceptedRequestAsync(
            CefNet.DevTools.Protocol.Network.ContinueInterceptedRequestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.ContinueInterceptedRequestRequest>(
                    "Network.continueInterceptedRequest", parameters, cancellationToken);
        }

        /// <summary>
        /// Deletes browser cookies with matching name and url or domain/path pair.
        /// </summary>
        public readonly System.Threading.Tasks.Task DeleteCookiesAsync(
            CefNet.DevTools.Protocol.Network.DeleteCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.DeleteCookiesRequest>(
                    "Network.deleteCookies", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables network tracking, prevents network events from being sent to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Network.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Activates emulation of network conditions.
        /// </summary>
        public readonly System.Threading.Tasks.Task EmulateNetworkConditionsAsync(
            CefNet.DevTools.Protocol.Network.EmulateNetworkConditionsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.EmulateNetworkConditionsRequest>(
                    "Network.emulateNetworkConditions", parameters, cancellationToken);
        }

        /// <summary>
        /// Enables network tracking, network events will now be delivered to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            CefNet.DevTools.Protocol.Network.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.EnableRequest>(
                    "Network.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie
        /// information in the `cookies` field.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetAllCookiesResponse> GetAllCookiesAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit, CefNet.DevTools.Protocol.Network.GetAllCookiesResponse>(
                    "Network.getAllCookies", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns the DER-encoded certificate.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetCertificateResponse> GetCertificateAsync(
            CefNet.DevTools.Protocol.Network.GetCertificateRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetCertificateRequest, CefNet.DevTools.Protocol.Network.GetCertificateResponse>(
                    "Network.getCertificate", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all browser cookies for the current URL. Depending on the backend support, will return
        /// detailed cookie information in the `cookies` field.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetCookiesResponse> GetCookiesAsync(
            CefNet.DevTools.Protocol.Network.GetCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetCookiesRequest, CefNet.DevTools.Protocol.Network.GetCookiesResponse>(
                    "Network.getCookies", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns post data sent with the request. Returns an error when no data was sent with the request.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetRequestPostDataResponse> GetRequestPostDataAsync(
            CefNet.DevTools.Protocol.Network.GetRequestPostDataRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetRequestPostDataRequest, CefNet.DevTools.Protocol.Network.GetRequestPostDataResponse>(
                    "Network.getRequestPostData", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns content served for the given request.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetResponseBodyResponse> GetResponseBodyAsync(
            CefNet.DevTools.Protocol.Network.GetResponseBodyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetResponseBodyRequest, CefNet.DevTools.Protocol.Network.GetResponseBodyResponse>(
                    "Network.getResponseBody", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns content served for the given currently intercepted request.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetResponseBodyForInterceptionResponse> GetResponseBodyForInterceptionAsync(
            CefNet.DevTools.Protocol.Network.GetResponseBodyForInterceptionRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetResponseBodyForInterceptionRequest, CefNet.DevTools.Protocol.Network.GetResponseBodyForInterceptionResponse>(
                    "Network.getResponseBodyForInterception", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns information about the COEP/COOP isolation status.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.GetSecurityIsolationStatusResponse> GetSecurityIsolationStatusAsync(
            CefNet.DevTools.Protocol.Network.GetSecurityIsolationStatusRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.GetSecurityIsolationStatusRequest, CefNet.DevTools.Protocol.Network.GetSecurityIsolationStatusResponse>(
                    "Network.getSecurityIsolationStatus", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Fetches the resource and returns the content.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.LoadNetworkResourceResponse> LoadNetworkResourceAsync(
            CefNet.DevTools.Protocol.Network.LoadNetworkResourceRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.LoadNetworkResourceRequest, CefNet.DevTools.Protocol.Network.LoadNetworkResourceResponse>(
                    "Network.loadNetworkResource", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] This method sends a new XMLHttpRequest which is identical to the original one. The following
        /// parameters should be identical: method, url, async, request body, extra headers, withCredentials
        /// attribute, user, password.
        /// </summary>
        public readonly System.Threading.Tasks.Task ReplayXHRAsync(
            CefNet.DevTools.Protocol.Network.ReplayXHRRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.ReplayXHRRequest>(
                    "Network.replayXHR", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Searches for given string in response content.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.SearchInResponseBodyResponse> SearchInResponseBodyAsync(
            CefNet.DevTools.Protocol.Network.SearchInResponseBodyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SearchInResponseBodyRequest, CefNet.DevTools.Protocol.Network.SearchInResponseBodyResponse>(
                    "Network.searchInResponseBody", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAcceptedEncodingsAsync(
            CefNet.DevTools.Protocol.Network.SetAcceptedEncodingsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetAcceptedEncodingsRequest>(
                    "Network.setAcceptedEncodings", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Specifies whether to attach a page script stack id in requests
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAttachDebugStackAsync(
            CefNet.DevTools.Protocol.Network.SetAttachDebugStackRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetAttachDebugStackRequest>(
                    "Network.setAttachDebugStack", parameters, cancellationToken);
        }

        /// <summary>[Experimental] Blocks URLs from loading.</summary>
        public readonly System.Threading.Tasks.Task SetBlockedURLsAsync(
            CefNet.DevTools.Protocol.Network.SetBlockedURLsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetBlockedURLsRequest>(
                    "Network.setBlockedURLs", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Toggles ignoring of service worker for each request.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetBypassServiceWorkerAsync(
            CefNet.DevTools.Protocol.Network.SetBypassServiceWorkerRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetBypassServiceWorkerRequest>(
                    "Network.setBypassServiceWorker", parameters, cancellationToken);
        }

        /// <summary>
        /// Toggles ignoring cache for each request. If `true`, cache will not be used.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetCacheDisabledAsync(
            CefNet.DevTools.Protocol.Network.SetCacheDisabledRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetCacheDisabledRequest>(
                    "Network.setCacheDisabled", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.SetCookieResponse> SetCookieAsync(
            CefNet.DevTools.Protocol.Network.SetCookieRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetCookieRequest, CefNet.DevTools.Protocol.Network.SetCookieResponse>(
                    "Network.setCookie", parameters, cancellationToken);
        }

        /// <summary>Sets given cookies.</summary>
        public readonly System.Threading.Tasks.Task SetCookiesAsync(
            CefNet.DevTools.Protocol.Network.SetCookiesRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetCookiesRequest>(
                    "Network.setCookies", parameters, cancellationToken);
        }

        /// <summary>
        /// Specifies whether to always send extra HTTP headers with the requests from this page.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetExtraHTTPHeadersAsync(
            CefNet.DevTools.Protocol.Network.SetExtraHTTPHeadersRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetExtraHTTPHeadersRequest>(
                    "Network.setExtraHTTPHeaders", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] [Experimental] Sets the requests to intercept that match the provided patterns and optionally resource types.
        /// Deprecated, please use Fetch.enable instead.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetRequestInterceptionAsync(
            CefNet.DevTools.Protocol.Network.SetRequestInterceptionRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetRequestInterceptionRequest>(
                    "Network.setRequestInterception", parameters, cancellationToken);
        }

        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetUserAgentOverrideAsync(
            CefNet.DevTools.Protocol.Network.SetUserAgentOverrideRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.SetUserAgentOverrideRequest>(
                    "Network.setUserAgentOverride", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Returns a handle to the stream representing the response body. Note that after this command,
        /// the intercepted request can't be continued as is -- you either need to cancel it or to provide
        /// the response body. The stream only supports sequential read, IO.read will fail if the position
        /// is specified.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Network.TakeResponseBodyForInterceptionAsStreamResponse> TakeResponseBodyForInterceptionAsStreamAsync(
            CefNet.DevTools.Protocol.Network.TakeResponseBodyForInterceptionAsStreamRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Network.TakeResponseBodyForInterceptionAsStreamRequest, CefNet.DevTools.Protocol.Network.TakeResponseBodyForInterceptionAsStreamResponse>(
                    "Network.takeResponseBodyForInterceptionAsStream", parameters, cancellationToken);
        }

        /// <summary>
        /// Fired when data chunk was received over the network.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.DataReceivedEventArgs> DataReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.DataReceivedEventArgs>("Network.dataReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.DataReceivedEventArgs>("Network.dataReceived", value);
            }
        }

        /// <summary>
        /// Fired when EventSource message is received.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.EventSourceMessageReceivedEventArgs> EventSourceMessageReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.EventSourceMessageReceivedEventArgs>("Network.eventSourceMessageReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.EventSourceMessageReceivedEventArgs>("Network.eventSourceMessageReceived", value);
            }
        }

        /// <summary>
        /// Fired when HTTP request has failed to load.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.LoadingFailedEventArgs> LoadingFailed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.LoadingFailedEventArgs>("Network.loadingFailed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.LoadingFailedEventArgs>("Network.loadingFailed", value);
            }
        }

        /// <summary>
        /// Fired when HTTP request has finished loading.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.LoadingFinishedEventArgs> LoadingFinished 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.LoadingFinishedEventArgs>("Network.loadingFinished", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.LoadingFinishedEventArgs>("Network.loadingFinished", value);
            }
        }

        /// <summary>
        /// [Deprecated] [Experimental] Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
        /// mocked.
        /// Deprecated, use Fetch.requestPaused instead.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.RequestInterceptedEventArgs> RequestIntercepted 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.RequestInterceptedEventArgs>("Network.requestIntercepted", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.RequestInterceptedEventArgs>("Network.requestIntercepted", value);
            }
        }

        /// <summary>
        /// Fired if request ended up loading from cache.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.RequestServedFromCacheEventArgs> RequestServedFromCache 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.RequestServedFromCacheEventArgs>("Network.requestServedFromCache", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.RequestServedFromCacheEventArgs>("Network.requestServedFromCache", value);
            }
        }

        /// <summary>
        /// Fired when page is about to send HTTP request.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentEventArgs> RequestWillBeSent 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentEventArgs>("Network.requestWillBeSent", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentEventArgs>("Network.requestWillBeSent", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when additional information about a requestWillBeSent event is available from the
        /// network stack. Not every requestWillBeSent event will have an additional
        /// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
        /// or requestWillBeSentExtraInfo will be fired first for the same request.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentExtraInfoEventArgs> RequestWillBeSentExtraInfo 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentExtraInfoEventArgs>("Network.requestWillBeSentExtraInfo", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.RequestWillBeSentExtraInfoEventArgs>("Network.requestWillBeSentExtraInfo", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when resource loading priority is changed
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.ResourceChangedPriorityEventArgs> ResourceChangedPriority 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.ResourceChangedPriorityEventArgs>("Network.resourceChangedPriority", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.ResourceChangedPriorityEventArgs>("Network.resourceChangedPriority", value);
            }
        }

        /// <summary>Fired when HTTP response is available.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedEventArgs> ResponseReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedEventArgs>("Network.responseReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedEventArgs>("Network.responseReceived", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when additional information about a responseReceived event is available from the network
        /// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
        /// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedExtraInfoEventArgs> ResponseReceivedExtraInfo 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedExtraInfoEventArgs>("Network.responseReceivedExtraInfo", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.ResponseReceivedExtraInfoEventArgs>("Network.responseReceivedExtraInfo", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when a signed exchange was received over the network
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.SignedExchangeReceivedEventArgs> SignedExchangeReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.SignedExchangeReceivedEventArgs>("Network.signedExchangeReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.SignedExchangeReceivedEventArgs>("Network.signedExchangeReceived", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when request for resources within a .wbn file failed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseErrorEventArgs> SubresourceWebBundleInnerResponseError 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseErrorEventArgs>("Network.subresourceWebBundleInnerResponseError", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseErrorEventArgs>("Network.subresourceWebBundleInnerResponseError", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired when handling requests for resources within a .wbn file.
        /// Note: this will only be fired for resources that are requested by the webpage.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseParsedEventArgs> SubresourceWebBundleInnerResponseParsed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseParsedEventArgs>("Network.subresourceWebBundleInnerResponseParsed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleInnerResponseParsedEventArgs>("Network.subresourceWebBundleInnerResponseParsed", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired once when parsing the .wbn file has failed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataErrorEventArgs> SubresourceWebBundleMetadataError 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataErrorEventArgs>("Network.subresourceWebBundleMetadataError", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataErrorEventArgs>("Network.subresourceWebBundleMetadataError", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired once when parsing the .wbn file has succeeded.
        /// The event contains the information about the web bundle contents.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataReceivedEventArgs> SubresourceWebBundleMetadataReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataReceivedEventArgs>("Network.subresourceWebBundleMetadataReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.SubresourceWebBundleMetadataReceivedEventArgs>("Network.subresourceWebBundleMetadataReceived", value);
            }
        }

        /// <summary>
        /// [Experimental] Fired exactly once for each Trust Token operation. Depending on
        /// the type of the operation and whether the operation succeeded or
        /// failed, the event is fired before the corresponding request was sent
        /// or after the response was received.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgs> TrustTokenOperationDone 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgs>("Network.trustTokenOperationDone", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.TrustTokenOperationDoneEventArgs>("Network.trustTokenOperationDone", value);
            }
        }

        /// <summary>Fired when WebSocket is closed.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketClosedEventArgs> WebSocketClosed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketClosedEventArgs>("Network.webSocketClosed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketClosedEventArgs>("Network.webSocketClosed", value);
            }
        }

        /// <summary>Fired upon WebSocket creation.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketCreatedEventArgs> WebSocketCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketCreatedEventArgs>("Network.webSocketCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketCreatedEventArgs>("Network.webSocketCreated", value);
            }
        }

        /// <summary>
        /// Fired when WebSocket message error occurs.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameErrorEventArgs> WebSocketFrameError 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameErrorEventArgs>("Network.webSocketFrameError", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameErrorEventArgs>("Network.webSocketFrameError", value);
            }
        }

        /// <summary>
        /// Fired when WebSocket message is received.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameReceivedEventArgs> WebSocketFrameReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameReceivedEventArgs>("Network.webSocketFrameReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameReceivedEventArgs>("Network.webSocketFrameReceived", value);
            }
        }

        /// <summary>Fired when WebSocket message is sent.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameSentEventArgs> WebSocketFrameSent 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameSentEventArgs>("Network.webSocketFrameSent", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketFrameSentEventArgs>("Network.webSocketFrameSent", value);
            }
        }

        /// <summary>
        /// Fired when WebSocket handshake response becomes available.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketHandshakeResponseReceivedEventArgs> WebSocketHandshakeResponseReceived 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketHandshakeResponseReceivedEventArgs>("Network.webSocketHandshakeResponseReceived", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketHandshakeResponseReceivedEventArgs>("Network.webSocketHandshakeResponseReceived", value);
            }
        }

        /// <summary>
        /// Fired when WebSocket is about to initiate handshake.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebSocketWillSendHandshakeRequestEventArgs> WebSocketWillSendHandshakeRequest 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebSocketWillSendHandshakeRequestEventArgs>("Network.webSocketWillSendHandshakeRequest", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebSocketWillSendHandshakeRequestEventArgs>("Network.webSocketWillSendHandshakeRequest", value);
            }
        }

        /// <summary>Fired when WebTransport is disposed.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebTransportClosedEventArgs> WebTransportClosed 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebTransportClosedEventArgs>("Network.webTransportClosed", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebTransportClosedEventArgs>("Network.webTransportClosed", value);
            }
        }

        /// <summary>
        /// Fired when WebTransport handshake is finished.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebTransportConnectionEstablishedEventArgs> WebTransportConnectionEstablished 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebTransportConnectionEstablishedEventArgs>("Network.webTransportConnectionEstablished", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebTransportConnectionEstablishedEventArgs>("Network.webTransportConnectionEstablished", value);
            }
        }

        /// <summary>Fired upon WebTransport creation.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Network.WebTransportCreatedEventArgs> WebTransportCreated 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Network.WebTransportCreatedEventArgs>("Network.webTransportCreated", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Network.WebTransportCreatedEventArgs>("Network.webTransportCreated", value);
            }
        }
    }
}
