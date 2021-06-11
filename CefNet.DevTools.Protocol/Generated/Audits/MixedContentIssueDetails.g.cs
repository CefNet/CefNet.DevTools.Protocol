//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Audits
{
    public sealed class MixedContentIssueDetails
    {
        /// <summary>
        /// The type of resource causing the mixed content issue (css, js, iframe,
        /// form,...). Marked as optional because it is mapped to from
        /// blink::mojom::RequestContextType, which will be replaced
        /// by network::mojom::RequestDestination
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.MixedContentResourceType? ResourceType { get; set; }

        /// <summary>
        /// The way the mixed content issue is being resolved.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.MixedContentResolutionStatus ResolutionStatus { get; set; }

        /// <summary>
        /// The unsafe http url causing the mixed content issue.
        /// </summary>
        public string InsecureURL { get; set; }

        /// <summary>
        /// The url responsible for the call to an unsafe url.
        /// </summary>
        public string MainResourceURL { get; set; }

        /// <summary>
        /// The mixed content request.
        /// Does not always exist (e.g. for unsafe form submission urls).
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.AffectedRequest? Request { get; set; }

        /// <summary>
        /// Optional because not every mixed content issue is necessarily linked to a frame.
        /// </summary>
        public CefNet.DevTools.Protocol.Audits.AffectedFrame? Frame { get; set; }
    }
}
