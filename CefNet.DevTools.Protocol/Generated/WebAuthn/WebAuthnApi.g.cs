//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable

namespace CefNet.DevTools.Protocol.WebAuthn
{
    /// <summary>
    /// [Experimental] This domain allows configuring virtual authenticators to test the WebAuthn
    /// API.
    /// </summary>
    public readonly struct WebAuthnApi
    {
        private readonly CefNet.DevTools.CrdtpSession _session;

        internal WebAuthnApi(
            CefNet.DevTools.CrdtpSession session)
        {
            _session = session;
        }

        /// <summary>
        /// Adds the credential to the specified authenticator.
        /// </summary>
        public readonly System.Threading.Tasks.Task AddCredentialAsync(
            CefNet.DevTools.Protocol.WebAuthn.AddCredentialRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.AddCredentialRequest>(
                    "WebAuthn.addCredential", parameters, cancellationToken);
        }

        /// <summary>
        /// Creates and adds a virtual authenticator.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.WebAuthn.AddVirtualAuthenticatorResponse> AddVirtualAuthenticatorAsync(
            CefNet.DevTools.Protocol.WebAuthn.AddVirtualAuthenticatorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.AddVirtualAuthenticatorRequest, CefNet.DevTools.Protocol.WebAuthn.AddVirtualAuthenticatorResponse>(
                    "WebAuthn.addVirtualAuthenticator", parameters, cancellationToken);
        }

        /// <summary>
        /// Clears all the credentials from the specified device.
        /// </summary>
        public readonly System.Threading.Tasks.Task ClearCredentialsAsync(
            CefNet.DevTools.Protocol.WebAuthn.ClearCredentialsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.ClearCredentialsRequest>(
                    "WebAuthn.clearCredentials", parameters, cancellationToken);
        }

        /// <summary>Disable the WebAuthn domain.</summary>
        public readonly System.Threading.Tasks.Task DisableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "WebAuthn.disable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Enable the WebAuthn domain and start intercepting credential storage and
        /// retrieval with a virtual authenticator.
        /// </summary>
        public readonly System.Threading.Tasks.Task EnableAsync(
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<Xilium.Crdtp.Core.Unit>(
                    "WebAuthn.enable", default(Xilium.Crdtp.Core.Unit)!, cancellationToken);
        }

        /// <summary>
        /// Returns a single credential stored in the given virtual authenticator that
        /// matches the credential ID.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.WebAuthn.GetCredentialResponse> GetCredentialAsync(
            CefNet.DevTools.Protocol.WebAuthn.GetCredentialRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.GetCredentialRequest, CefNet.DevTools.Protocol.WebAuthn.GetCredentialResponse>(
                    "WebAuthn.getCredential", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns all the credentials stored in the given virtual authenticator.
        /// </summary>
        public readonly System.Threading.Tasks.Task<CefNet.DevTools.Protocol.WebAuthn.GetCredentialsResponse> GetCredentialsAsync(
            CefNet.DevTools.Protocol.WebAuthn.GetCredentialsRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.GetCredentialsRequest, CefNet.DevTools.Protocol.WebAuthn.GetCredentialsResponse>(
                    "WebAuthn.getCredentials", parameters, cancellationToken);
        }

        /// <summary>
        /// Removes a credential from the authenticator.
        /// </summary>
        public readonly System.Threading.Tasks.Task RemoveCredentialAsync(
            CefNet.DevTools.Protocol.WebAuthn.RemoveCredentialRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.RemoveCredentialRequest>(
                    "WebAuthn.removeCredential", parameters, cancellationToken);
        }

        /// <summary>Removes the given authenticator.</summary>
        public readonly System.Threading.Tasks.Task RemoveVirtualAuthenticatorAsync(
            CefNet.DevTools.Protocol.WebAuthn.RemoveVirtualAuthenticatorRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.RemoveVirtualAuthenticatorRequest>(
                    "WebAuthn.removeVirtualAuthenticator", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
        /// The default is true.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetAutomaticPresenceSimulationAsync(
            CefNet.DevTools.Protocol.WebAuthn.SetAutomaticPresenceSimulationRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.SetAutomaticPresenceSimulationRequest>(
                    "WebAuthn.setAutomaticPresenceSimulation", parameters, cancellationToken);
        }

        /// <summary>
        /// Sets whether User Verification succeeds or fails for an authenticator.
        /// The default is true.
        /// </summary>
        public readonly System.Threading.Tasks.Task SetUserVerifiedAsync(
            CefNet.DevTools.Protocol.WebAuthn.SetUserVerifiedRequest parameters, 
            System.Threading.CancellationToken cancellationToken = default)
        {
            return _session
                .ExecuteCommandAsync<CefNet.DevTools.Protocol.WebAuthn.SetUserVerifiedRequest>(
                    "WebAuthn.setUserVerified", parameters, cancellationToken);
        }
    }
}
