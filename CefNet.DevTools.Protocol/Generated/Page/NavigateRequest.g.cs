//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class NavigateRequest
    {
        /// <summary>URL to navigate the page to.</summary>
        public string Url { get; set; }

        /// <summary>Referrer URL.</summary>
        public string? Referrer { get; set; }

        /// <summary>Intended transition type.</summary>
        public CefNet.DevTools.Protocol.Page.TransitionType? TransitionType { get; set; }

        /// <summary>
        /// Frame id to navigate, if not specified navigates the top frame.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId? FrameId { get; set; }

        /// <summary>
        /// [Experimental] Referrer-policy used for the navigation.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.ReferrerPolicy? ReferrerPolicy { get; set; }
    }
}
