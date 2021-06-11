//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Fetch
{
    /// <summary>
    /// A domain for letting clients substitute browser's network layer with client code.
    /// </summary>
    public readonly struct FetchApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal FetchApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Continues the request, optionally modifying some of its parameters.
        /// </summary>
        public readonly System.Threading.Tasks.Task ContinueRequestAsync(
            CefNet.DevTools.Protocol.Fetch.ContinueRequestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.ContinueRequestRequest>(
                    "Fetch.continueRequest", parameters, cancellationToken);
        }

        /// <summary>
        /// Continues a request supplying authChallengeResponse following authRequired event.
        /// </summary>
        public readonly System.Threading.Tasks.Task ContinueWithAuthAsync(
            CefNet.DevTools.Protocol.Fetch.ContinueWithAuthRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.ContinueWithAuthRequest>(
                    "Fetch.continueWithAuth", parameters, cancellationToken);
        }

        /// <summary>Disables the fetch domain.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Fetch.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables issuing of requestPaused events. A request will be paused until client
        /// calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            CefNet.DevTools.Protocol.Fetch.EnableRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.EnableRequest>(
                    "Fetch.enable", parameters, cancellationToken);
        }

        /// <summary>
        /// Causes the request to fail with specified reason.
        /// </summary>
        public readonly System.Threading.Tasks.Task FailRequestAsync(
            CefNet.DevTools.Protocol.Fetch.FailRequestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.FailRequestRequest>(
                    "Fetch.failRequest", parameters, cancellationToken);
        }

        /// <summary>Provides response to the request.</summary>
        public readonly System.Threading.Tasks.Task FulfillRequestAsync(
            CefNet.DevTools.Protocol.Fetch.FulfillRequestRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.FulfillRequestRequest>(
                    "Fetch.fulfillRequest", parameters, cancellationToken);
        }

        /// <summary>
        /// Causes the body of the response to be received from the server and
        /// returned as a single string. May only be issued for a request that
        /// is paused in the Response stage and is mutually exclusive with
        /// takeResponseBodyForInterceptionAsStream. Calling other methods that
        /// affect the request or disabling fetch domain before body is received
        /// results in an undefined behavior.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Fetch.GetResponseBodyResponse> GetResponseBodyAsync(
            CefNet.DevTools.Protocol.Fetch.GetResponseBodyRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.GetResponseBodyRequest, CefNet.DevTools.Protocol.Fetch.GetResponseBodyResponse>(
                    "Fetch.getResponseBody", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a handle to the stream representing the response body.
        /// The request must be paused in the HeadersReceived stage.
        /// Note that after this command the request can't be continued
        /// as is -- client either needs to cancel it or to provide the
        /// response body.
        /// The stream only supports sequential read, IO.read will fail if the position
        /// is specified.
        /// This method is mutually exclusive with getResponseBody.
        /// Calling other methods that affect the request or disabling fetch
        /// domain before body is received results in an undefined behavior.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Fetch.TakeResponseBodyAsStreamResponse> TakeResponseBodyAsStreamAsync(
            CefNet.DevTools.Protocol.Fetch.TakeResponseBodyAsStreamRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Fetch.TakeResponseBodyAsStreamRequest, CefNet.DevTools.Protocol.Fetch.TakeResponseBodyAsStreamResponse>(
                    "Fetch.takeResponseBodyAsStream", parameters, cancellationToken);
        }

        /// <summary>
        /// Issued when the domain is enabled with handleAuthRequests set to true.
        /// The request is paused until client responds with continueWithAuth.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Fetch.AuthRequiredEventArgs> AuthRequired 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Fetch.AuthRequiredEventArgs>("Fetch.authRequired", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Fetch.AuthRequiredEventArgs>("Fetch.authRequired", value);
            }
        }

        /// <summary>
        /// Issued when the domain is enabled and the request URL matches the
        /// specified filter. The request is paused until the client responds
        /// with one of continueRequest, failRequest or fulfillRequest.
        /// The stage of the request can be determined by presence of responseErrorReason
        /// and responseStatusCode -- the request is at the response stage if either
        /// of these fields is present and in the request stage otherwise.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Fetch.RequestPausedEventArgs> RequestPaused 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Fetch.RequestPausedEventArgs>("Fetch.requestPaused", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Fetch.RequestPausedEventArgs>("Fetch.requestPaused", value);
            }
        }
    }
}
