//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAuthn
{
    public sealed class Credential
    {
        public byte[] CredentialId { get; set; }

        public bool IsResidentCredential { get; set; }

        /// <summary>
        /// Relying Party ID the credential is scoped to. Must be set when adding a
        /// credential.
        /// </summary>
        public string? RpId { get; set; }

        /// <summary>
        /// The ECDSA P-256 private key in PKCS#8 format.
        /// </summary>
        public byte[] PrivateKey { get; set; }

        /// <summary>
        /// An opaque byte sequence with a maximum size of 64 bytes mapping the
        /// credential to a specific user.
        /// </summary>
        public byte[]? UserHandle { get; set; }

        /// <summary>
        /// Signature counter. This is incremented by one for each successful
        /// assertion.
        /// See https://w3c.github.io/webauthn/#signature-counter
        /// </summary>
        public int SignCount { get; set; }

        /// <summary>
        /// The large blob associated with the credential.
        /// See https://w3c.github.io/webauthn/#sctn-large-blob-extension
        /// </summary>
        public byte[]? LargeBlob { get; set; }
    }
}
