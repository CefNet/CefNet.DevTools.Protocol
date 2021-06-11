//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Security
{
    /// <summary>
    /// [Experimental] Details about the security state of the page certificate.
    /// </summary>
    public sealed class CertificateSecurityState
    {
        /// <summary>
        /// Protocol name (e.g. "TLS 1.2" or "QUIC").
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Key Exchange used by the connection, or the empty string if not applicable.
        /// </summary>
        public string KeyExchange { get; set; }

        /// <summary>
        /// (EC)DH group used by the connection, if applicable.
        /// </summary>
        public string? KeyExchangeGroup { get; set; }

        /// <summary>Cipher name.</summary>
        public string Cipher { get; set; }

        /// <summary>
        /// TLS MAC. Note that AEAD ciphers do not have separate MACs.
        /// </summary>
        public string? Mac { get; set; }

        /// <summary>Page certificate.</summary>
        public System.Collections.Generic.List<string> Certificate { get; set; }

        /// <summary>Certificate subject name.</summary>
        public string SubjectName { get; set; }

        /// <summary>Name of the issuing CA.</summary>
        public string Issuer { get; set; }

        /// <summary>Certificate valid from date.</summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch ValidFrom { get; set; }

        /// <summary>Certificate valid to (expiration) date</summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch ValidTo { get; set; }

        /// <summary>
        /// The highest priority network error code, if the certificate has an error.
        /// </summary>
        public string? CertificateNetworkError { get; set; }

        /// <summary>
        /// True if the certificate uses a weak signature aglorithm.
        /// </summary>
        public bool CertificateHasWeakSignature { get; set; }

        /// <summary>
        /// True if the certificate has a SHA1 signature in the chain.
        /// </summary>
        public bool CertificateHasSha1Signature { get; set; }

        /// <summary>True if modern SSL</summary>
        public bool ModernSSL { get; set; }

        /// <summary>
        /// True if the connection is using an obsolete SSL protocol.
        /// </summary>
        public bool ObsoleteSslProtocol { get; set; }

        /// <summary>
        /// True if the connection is using an obsolete SSL key exchange.
        /// </summary>
        public bool ObsoleteSslKeyExchange { get; set; }

        /// <summary>
        /// True if the connection is using an obsolete SSL cipher.
        /// </summary>
        public bool ObsoleteSslCipher { get; set; }

        /// <summary>
        /// True if the connection is using an obsolete SSL signature.
        /// </summary>
        public bool ObsoleteSslSignature { get; set; }
    }
}
