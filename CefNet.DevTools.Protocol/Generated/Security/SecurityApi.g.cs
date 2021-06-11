//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;

namespace CefNet.DevTools.Protocol.Security
{
    /// <summary>Security</summary>
    public readonly struct SecurityApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal SecurityApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Disables tracking security state changes.
        /// </summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Security.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>Enables tracking security state changes.</summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "Security.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Handles a certificate error that fired a certificateError event.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task HandleCertificateErrorAsync(
            CefNet.DevTools.Protocol.Security.HandleCertificateErrorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Security.HandleCertificateErrorRequest>(
                    "Security.handleCertificateError", parameters, cancellationToken);
        }

        /// <summary>
        /// [Experimental] Enable/disable whether all certificate errors should be ignored.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetIgnoreCertificateErrorsAsync(
            CefNet.DevTools.Protocol.Security.SetIgnoreCertificateErrorsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Security.SetIgnoreCertificateErrorsRequest>(
                    "Security.setIgnoreCertificateErrors", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] Enable/disable overriding certificate errors. If enabled, all certificate error events need to
        /// be handled by the DevTools client and should be answered with `handleCertificateError` commands.
        /// </summary>
        [Obsolete]
        public readonly System.Threading.Tasks.Task SetOverrideCertificateErrorsAsync(
            CefNet.DevTools.Protocol.Security.SetOverrideCertificateErrorsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.Security.SetOverrideCertificateErrorsRequest>(
                    "Security.setOverrideCertificateErrors", parameters, cancellationToken);
        }

        /// <summary>
        /// [Deprecated] There is a certificate error. If overriding certificate errors is enabled, then it should be
        /// handled with the `handleCertificateError` command. Note: this event does not fire if the
        /// certificate error has been allowed internally. Only one client per target should override
        /// certificate errors at the same time.
        /// </summary>
        [Obsolete]
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Security.CertificateErrorEventArgs> CertificateError 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Security.CertificateErrorEventArgs>("Security.certificateError", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Security.CertificateErrorEventArgs>("Security.certificateError", value);
            }
        }

        /// <summary>The security state of the page changed.</summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Security.SecurityStateChangedEventArgs> SecurityStateChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Security.SecurityStateChangedEventArgs>("Security.securityStateChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Security.SecurityStateChangedEventArgs>("Security.securityStateChanged", value);
            }
        }

        /// <summary>
        /// [Experimental] The security state of the page changed.
        /// </summary>
        public readonly event System.EventHandler<CefNet.DevTools.Protocol.Security.VisibleSecurityStateChangedEventArgs> VisibleSecurityStateChanged 
        {
            add
            {
                _session.AddEventHandler<CefNet.DevTools.Protocol.Security.VisibleSecurityStateChangedEventArgs>("Security.visibleSecurityStateChanged", value);
            }
            remove
            {
                _session.RemoveEventHandler<CefNet.DevTools.Protocol.Security.VisibleSecurityStateChangedEventArgs>("Security.visibleSecurityStateChanged", value);
            }
        }
    }
}
