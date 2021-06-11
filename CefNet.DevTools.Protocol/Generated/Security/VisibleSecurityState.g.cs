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
    /// [Experimental] Security state information about the page.
    /// </summary>
    public sealed class VisibleSecurityState
    {
        /// <summary>The security level of the page.</summary>
        public CefNet.DevTools.Protocol.Security.SecurityState SecurityState { get; set; }

        /// <summary>
        /// Security state details about the page certificate.
        /// </summary>
        public CefNet.DevTools.Protocol.Security.CertificateSecurityState? CertificateSecurityState { get; set; }

        /// <summary>
        /// The type of Safety Tip triggered on the page. Note that this field will be set even if the Safety Tip UI was not actually shown.
        /// </summary>
        public CefNet.DevTools.Protocol.Security.SafetyTipInfo? SafetyTipInfo { get; set; }

        /// <summary>Array of security state issues ids.</summary>
        public System.Collections.Generic.List<string> SecurityStateIssueIds { get; set; }
    }
}
