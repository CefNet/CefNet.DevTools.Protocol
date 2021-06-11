//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.Audits
{
    /// <summary>
    /// [Experimental] Audits domain allows investigation of page violations and possible improvements.
    /// </summary>
    public readonly struct AuditsApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal AuditsApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Runs the contrast check for the target page. Found issues are reported
        /// using Audits.issueAdded event.
        /// </summary>
        public readonly System.Threading.Tasks.Task CheckContrastAsync(
            CefNet.DevTools.Protocol.Audits.CheckContrastRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Audits.CheckContrastRequest>(
                    "Audits.checkContrast", parameters, cancellationToken);
        }

        /// <summary>
        /// Disables issues domain, prevents further issues from being reported to the client.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Audits.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enables issues domain, sends the issues collected so far to the client by means of the
        /// `issueAdded` event.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Audits.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns the response body and size if it were re-encoded with the specified settings. Only
        /// applies to images.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.Audits.GetEncodedResponseResponse> GetEncodedResponseAsync(
            CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Audits.GetEncodedResponseRequest, CefNet.DevTools.Protocol.Audits.GetEncodedResponseResponse>(
                    "Audits.getEncodedResponse", parameters, cancellationToken);
        }

        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Audits.IssueAddedEventArgs> IssueAdded 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Audits.IssueAddedEventArgs>("Audits.issueAdded", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Audits.IssueAddedEventArgs>("Audits.issueAdded", value);
            }
        }
    }
}
