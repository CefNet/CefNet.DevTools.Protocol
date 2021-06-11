//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    /// <summary>
    /// [Experimental] Information about a signed exchange signature.
    /// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#rfc.section.3.1
    /// </summary>
    public sealed class SignedExchangeSignature
    {
        /// <summary>Signed exchange signature label.</summary>
        public string Label { get; set; }

        /// <summary>
        /// The hex string of signed exchange signature.
        /// </summary>
        public string Signature { get; set; }

        /// <summary>Signed exchange signature integrity.</summary>
        public string Integrity { get; set; }

        /// <summary>Signed exchange signature cert Url.</summary>
        public string? CertUrl { get; set; }

        /// <summary>
        /// The hex string of signed exchange signature cert sha256.
        /// </summary>
        public string? CertSha256 { get; set; }

        /// <summary>Signed exchange signature validity Url.</summary>
        public string ValidityUrl { get; set; }

        /// <summary>Signed exchange signature date.</summary>
        public int Date { get; set; }

        /// <summary>Signed exchange signature expires.</summary>
        public int Expires { get; set; }

        /// <summary>The encoded certificates.</summary>
        public System.Collections.Generic.List<string>? Certificates { get; set; }
    }
}
