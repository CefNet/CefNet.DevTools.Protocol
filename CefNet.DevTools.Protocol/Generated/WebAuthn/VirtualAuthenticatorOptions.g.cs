//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAuthn
{
    public sealed class VirtualAuthenticatorOptions
    {
        public CefNet.DevTools.Protocol.WebAuthn.AuthenticatorProtocol Protocol { get; set; }

        /// <summary>
        /// Defaults to ctap2_0. Ignored if |protocol| == u2f.
        /// </summary>
        public CefNet.DevTools.Protocol.WebAuthn.Ctap2Version? Ctap2Version { get; set; }

        public CefNet.DevTools.Protocol.WebAuthn.AuthenticatorTransport Transport { get; set; }

        /// <summary>Defaults to false.</summary>
        public bool? HasResidentKey { get; set; }

        /// <summary>Defaults to false.</summary>
        public bool? HasUserVerification { get; set; }

        /// <summary>
        /// If set to true, the authenticator will support the largeBlob extension.
        /// https://w3c.github.io/webauthn#largeBlob
        /// Defaults to false.
        /// </summary>
        public bool? HasLargeBlob { get; set; }

        /// <summary>
        /// If set to true, the authenticator will support the credBlob extension.
        /// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
        /// Defaults to false.
        /// </summary>
        public bool? HasCredBlob { get; set; }

        /// <summary>
        /// If set to true, tests of user presence will succeed immediately.
        /// Otherwise, they will not be resolved. Defaults to true.
        /// </summary>
        public bool? AutomaticPresenceSimulation { get; set; }

        /// <summary>
        /// Sets whether User Verification succeeds or fails for an authenticator.
        /// Defaults to false.
        /// </summary>
        public bool? IsUserVerified { get; set; }
    }
}
