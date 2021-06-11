//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class TrustedWebActivityIssueDetails
    {
        /// <summary>The url that triggers the violation.</summary>
        public string Url { get; set; }

        public CefNet.DevTools.Protocol.Audits.TwaQualityEnforcementViolationType ViolationType { get; set; }

        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The package name of the Trusted Web Activity client app. This field is
        /// only used when violation type is kDigitalAssetLinks.
        /// </summary>
        public string? PackageName { get; set; }

        /// <summary>
        /// The signature of the Trusted Web Activity client app. This field is only
        /// used when violation type is kDigitalAssetLinks.
        /// </summary>
        public string? Signature { get; set; }
    }
}
