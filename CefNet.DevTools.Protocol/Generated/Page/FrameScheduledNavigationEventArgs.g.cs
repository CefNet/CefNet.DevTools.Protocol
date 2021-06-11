//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Page
{
    public sealed class FrameScheduledNavigationEventArgs
        : System.EventArgs
    {
        /// <summary>
        /// Id of the frame that has scheduled a navigation.
        /// </summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// Delay (in seconds) until the navigation is scheduled to begin. The navigation is not
        /// guaranteed to start.
        /// </summary>
        public double Delay { get; set; }

        /// <summary>The reason for the navigation.</summary>
        public CefNet.DevTools.Protocol.Page.ClientNavigationReason Reason { get; set; }

        /// <summary>
        /// The destination URL for the scheduled navigation.
        /// </summary>
        public string Url { get; set; }
    }
}
