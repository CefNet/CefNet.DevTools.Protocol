//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class FrameRequestedNavigationEventArgs
        : System.EventArgs
    {
        /// <summary>Id of the frame that is being navigated.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>The reason for the navigation.</summary>
        public CefNet.DevTools.Protocol.Page.ClientNavigationReason Reason { get; set; }

        /// <summary>
        /// The destination URL for the requested navigation.
        /// </summary>
        public string Url { get; set; }

        /// <summary>The disposition for the navigation.</summary>
        public CefNet.DevTools.Protocol.Page.ClientNavigationDisposition Disposition { get; set; }
    }
}
