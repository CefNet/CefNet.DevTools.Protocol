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
    /// [Deprecated] Information about insecure content on the page.
    /// </summary>
    [Obsolete]
    public sealed class InsecureContentStatus
    {
        /// <summary>Always false.</summary>
        public bool RanMixedContent { get; set; }

        /// <summary>Always false.</summary>
        public bool DisplayedMixedContent { get; set; }

        /// <summary>Always false.</summary>
        public bool ContainedMixedForm { get; set; }

        /// <summary>Always false.</summary>
        public bool RanContentWithCertErrors { get; set; }

        /// <summary>Always false.</summary>
        public bool DisplayedContentWithCertErrors { get; set; }

        /// <summary>Always set to unknown.</summary>
        public CefNet.DevTools.Protocol.Security.SecurityState RanInsecureContentStyle { get; set; }

        /// <summary>Always set to unknown.</summary>
        public CefNet.DevTools.Protocol.Security.SecurityState DisplayedInsecureContentStyle { get; set; }
    }
}
