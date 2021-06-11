//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Security
{
    public sealed class SecurityStateChangedEventArgs
        : System.EventArgs
    {
        /// <summary>Security state.</summary>
        public CefNet.DevTools.Protocol.Security.SecurityState SecurityState { get; set; }

        /// <summary>
        /// [Deprecated] True if the page was loaded over cryptographic transport such as HTTPS.
        /// </summary>
        [Obsolete]
        public bool SchemeIsCryptographic { get; set; }

        /// <summary>
        /// List of explanations for the security state. If the overall security state is `insecure` or
        /// `warning`, at least one corresponding explanation should be included.
        /// </summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Security.SecurityStateExplanation> Explanations { get; set; }

        /// <summary>
        /// [Deprecated] Information about insecure content on the page.
        /// </summary>
        [Obsolete]
        public CefNet.DevTools.Protocol.Security.InsecureContentStatus InsecureContentStatus { get; set; }

        /// <summary>
        /// Overrides user-visible description of the state.
        /// </summary>
        public string? Summary { get; set; }
    }
}
